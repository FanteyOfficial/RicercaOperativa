using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
                Console.WriteLine(nRows);
                Console.WriteLine(i);

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
            DataGridView nordOvestGrid = CloneDataGrid(DataTable);
            nordOvestGrid.Dock = DockStyle.Fill;
            nordOvestGrid.AutoResizeColumnHeadersHeight();
            nordOvestGrid.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);

            NordOvestFrame.Controls.Add(nordOvestGrid);
        }
    }
}
