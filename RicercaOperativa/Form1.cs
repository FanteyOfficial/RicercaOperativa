using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RicercaOperativa
{
    public partial class Form1 : Form
    {
        private int nRows = 2;
        private int nCols = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateTable_OnClick(object sender, EventArgs e)
        {
            DataTable.Columns.Clear();

            DataTable.Dock = DockStyle.Fill;

            nRows = (int) RowNum.Value;
            nCols = (int) ColumnNum.Value;

            for (int i = 0; i < nCols; i++)
            {
                DataTable.Columns.Add("D" + (i+1), "D" + (i+1));
            }

            for (int i = 0; i < nRows; i++) {
                DataTable.Rows.Add();
                DataTable.Rows[i].HeaderCell.Value = "UP" + (i+1);
            }
            DataTable.Columns.Add("Totale", "Totale");
            DataTable.Rows.Add();
            DataTable.Rows[nRows].HeaderCell.Value = "Totale";
            DataTable.AutoResizeColumnHeadersHeight();
            DataTable.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);
            //DataTable.Width = DataTable.Columns.Count * 120;
            //DataTable.Height = DataTable.Rows.Count * 120;

            DataTable.Rows[nRows].Cells[nCols].Value = 0;
            DataTable.Rows[nRows].Cells[nCols].ReadOnly = true;

            DataTable.Refresh();
            
            ControlTotalsBTN.Enabled = true;
            NordOvestBTN.Enabled = true;
            FillTableBTN.Enabled = true;
            TotalsGeneratorBTN.Enabled = true;
        }

        private int totalRowSum()
        {
            int rowSum = 0;

            DataGridViewRow row = DataTable.Rows[nRows];

            for (int i = 0; i < row.Cells.Count - 1; i++)
            {
                DataGridViewCell cell = row.Cells[i];

                if (cell.Value != null && cell.Value.ToString() != "")
                {
                    rowSum += Convert.ToInt32(cell.Value);
                }
                else
                {
                    return -1;
                }
            }
            return rowSum;
        }
        private int totalColumnSum()
        {
            int columnSum = 0;

            foreach (DataGridViewRow row1 in DataTable.Rows)
            {
                if (row1.Cells[nCols].Value != null && row1.Cells[nCols].Value.ToString() != "")
                {
                    if (row1.Index != DataTable.Rows.Count - 1)
                    {
                        columnSum += Convert.ToInt32(row1.Cells[nCols].Value);
                    }
                }
                else
                {
                    return -1;
                }
            }
            return columnSum;
        }

        private bool TotalRowsController()
        {
            int rowSum = totalRowSum();
            int columnSum = totalColumnSum();

            if (rowSum != columnSum || rowSum == -1 || columnSum == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // controllo se i totali delle righe e colonne sono uguali
        private void controlTotal(object sender, EventArgs e)
        {
            if (TotalRowsController())
            {
                DataTable.Rows[nRows].Cells[nCols].Value = totalRowSum();
                TotalsVerifiedLabel.Text = "✔";
                TotalsVerifiedLabel.ForeColor = Color.Green;
            } 
            else
            {
                MessageBox.Show("La somma dei valori non corrisponde o le celle non sono tutte piene!");
                TotalsVerifiedLabel.Text = "X";
                TotalsVerifiedLabel.ForeColor = Color.Red;
            }
        }

        private void FillTable(object sender, EventArgs e)
        {
            int min = (int) MinNum.Value;
            int max = (int) MaxNum.Value;

            Random r = new Random();

            for (int i = 0; i < nRows; i++) { 
                for (int j = 0; j < nCols; j++)
                {
                    DataTable.Rows[i].Cells[j].Value = r.Next(min, max);
                }
            }
        }

        // riempimento casuale dei totali
        private void FillTotals(object sender, EventArgs e)
        {
            Random r = new Random();

            int min = (int) MinNum.Value;
            int max = (int) MaxNum.Value;

            for (int i = 0; i < nCols; i++)
            {
                //Console.WriteLine(nRows);
                //Console.WriteLine(i);

                DataTable.Rows[nRows].Cells[i].Value = r.Next(min, max);
            }

            foreach (DataGridViewRow row in DataTable.Rows)
            {
                if (!row.Cells[nCols].ReadOnly)
                {
                    row.Cells[nCols].Value = r.Next(min, max);
                }
            }
            
            if (!TotalRowsController())
            {
                if (totalRowSum() > totalColumnSum())
                {
                    DataTable.Rows[nRows-1].Cells[nCols].Value = (int) DataTable.Rows[nRows-1].Cells[nCols].Value + (totalRowSum() - totalColumnSum());
                }
                else
                {
                    DataTable.Rows[nRows].Cells[nCols-1].Value = (int) DataTable.Rows[nRows].Cells[nCols-1].Value + (totalColumnSum() - totalRowSum());
                }
                
            }
        }



        private DataGridView CloneDataGrid(DataGridView mainDataGridView)
        {
            DataGridView cloneDataGridView = new DataGridView();

            if (cloneDataGridView.Columns.Count == 0)
            {
                foreach (DataGridViewColumn datagrid in mainDataGridView.Columns)
                {
                    cloneDataGridView.Columns.Add(datagrid.Clone() as DataGridViewColumn);
                }
            }

            DataGridViewRow dataRow = new DataGridViewRow();

            for (int i = 0; i < mainDataGridView.Rows.Count; i++)
            {
                dataRow = (DataGridViewRow)mainDataGridView.Rows[i].Clone();
                int Index = 0;
                foreach (DataGridViewCell cell in mainDataGridView.Rows[i].Cells)
                {
                    dataRow.Cells[Index].Value = cell.Value;
                    Index++;
                }
                cloneDataGridView.Rows.Add(dataRow);
            }
            cloneDataGridView.AllowUserToAddRows = false;

            cloneDataGridView.Refresh();

            return cloneDataGridView;
        }

        private void NordOvestAlgorithm(object sender, EventArgs e)
        {
            if (NordOvestFrame.Controls.Count > 0)
            {
                NordOvestFrame.Controls.Clear();
            }
            DataGridView nordOvestGrid = CloneDataGrid(DataTable);
            nordOvestGrid.Dock = DockStyle.Fill;
            nordOvestGrid.AutoResizeColumnHeadersHeight();
            nordOvestGrid.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);
            nordOvestGrid.ReadOnly = true;

            NordOvestFrame.Controls.Add(nordOvestGrid);
            Frames.SelectedTab = NordOvestFrame;

            NordOvestAlgorithm(nordOvestGrid);
        }

        private void NordOvestAlgorithm(DataGridView grid)
        {
            int costoTot = 0;
            int currentD = 0;
            int currentUP = 0;

            int[,] arr = TableToMatrix(grid);

            while (currentUP < arr.GetLength(0) - 1 && currentD < arr.GetLength(1) - 1)
            {
                if (NordOvestFrame.Controls.Count > 0)
                {
                    NordOvestFrame.Controls.Clear();
                }
                DataGridView nordOvestGrid = DataGridFromMatrix(arr);
                nordOvestGrid.Dock = DockStyle.Fill;
                nordOvestGrid.AutoResizeColumnHeadersHeight();
                nordOvestGrid.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);
                nordOvestGrid.ReadOnly = true;

                NordOvestFrame.Controls.Add(nordOvestGrid);
                Frames.SelectedTab = NordOvestFrame;

                

                int UPn = arr[currentUP, arr.GetLength(1) - 1];
                int Dn = arr[arr.GetLength(0) - 1, currentD];
                int price = arr[currentUP, currentD];

                Console.WriteLine($"Da UP: {currentUP} a D: {currentD}");

                if (UPn >= Dn)
                {
                    costoTot += price * Dn;
                    arr[currentUP, arr.GetLength(1) - 1] -= Dn;
                    arr[arr.GetLength(0) - 1, currentD] = 0;
                    Console.WriteLine(price * Dn);
                    currentD++;
                }
                else
                {
                    costoTot += price * UPn;
                    arr[currentUP, arr.GetLength(1) - 1] = 0;
                    arr[arr.GetLength(0) - 1, currentD] -= UPn;
                    Console.WriteLine(price * UPn);
                    currentUP++;
                }
            }

            Console.WriteLine(costoTot);
        }

        private int[,] TableToMatrix(DataGridView grid)
        {
            int[,] arr2d = new int[grid.Rows.Count, grid.Columns.Count];

            for (int x = 0; x < arr2d.GetLength(0); x++)
                for (int i = 0; i < arr2d.GetLength(1); i++)
                    arr2d[x, i] = Convert.ToInt32(grid.Rows[x].Cells[i].Value);

            return arr2d;
        }

        private DataGridView DataGridFromMatrix(int[,] matrix)
        {
            DataGridView cloneDataGridView = new DataGridView();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (cloneDataGridView.Columns.Count == 0 && cols > 0)
            {
                for (int j = 0; j < cols; j++)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    cloneDataGridView.Columns.Add(column);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (matrix.GetLength(1) > 0 && matrix[i, 0] == 0)
                {
                    continue;
                }

                object[] rowData = new object[cols];
                for (int j = 0; j < cols; j++)
                {
                    rowData[j] = matrix[i, j];
                }
                cloneDataGridView.Rows.Add(rowData);
            }

            if (matrix.GetLength(0) > 0 && matrix[0, cols - 1] == 0)
            {
                cloneDataGridView.Columns.RemoveAt(cols - 1);
            }

            cloneDataGridView.AllowUserToAddRows = false;
            cloneDataGridView.Refresh();

            return cloneDataGridView;
        }
    }
}
