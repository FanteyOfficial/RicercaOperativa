using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RicercaOperativa
{
    public partial class Form1 : Form
    {
        private int nRows = 2;
        private int nCols = 2;

        static public bool owWasClosed = false;
        static public bool owIsOpened = false;

        private bool tableTotalsValid = false;

        OutputWindow ow = new OutputWindow();

        public Form1()
        {
            InitializeComponent();

            Frames.Controls.Remove(NordOvestFrame);
            Frames.Controls.Remove(MinimalCostsFrame);
        }

        private void CreateTable_OnClick(object sender, EventArgs e)
        {
            DataTable.Columns.Clear();
            DataTable.Rows.Clear();

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
            FillTableBTN.Enabled = true;
            TotalsGeneratorBTN.Enabled = true;
            FillTotalTableBTN.Enabled = true;

            controlTotal();
            WireUpDataGridViewEvents(DataTable);
        }


        private void WireUpDataGridViewEvents(DataGridView dataGridView)
        {
            dataGridView.CellValueChanged += CellEndEditHandler;
        }

        private void CellEndEditHandler(object sender, DataGridViewCellEventArgs e)
        {
            controlTotal();
            BtnAlgorithmActivationControlSystem();
        }

        private int totalRowSum()
        {
            int rowSum = 0;

            if (nRows >= 0 && nRows < DataTable.Rows.Count)
            {
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
            }
            else
            {
                return -1;
            }

            return rowSum;
        }
        private int totalColumnSum()
        {
            int columnSum = 0;

            if (nCols >= 0 && nCols < DataTable.Columns.Count)
            {
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
            }
            else
            {
                return -1;
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
            controlTotal();
            if (!tableTotalsValid)
            {
                MessageBox.Show("La somma dei valori non corrisponde o le celle non sono tutte piene!");
            }
        }

        private void controlTotal()
        {
            if (TotalRowsController())
            {
                DataTable.Rows[nRows].Cells[nCols].Value = totalRowSum();
                TotalsVerifiedLabel.Text = "✔";
                TotalsVerifiedLabel.ForeColor = Color.Green;

                tableTotalsValid = true;
            }
            else
            {
                TotalsVerifiedLabel.Text = "X";
                TotalsVerifiedLabel.ForeColor = Color.Red;

                tableTotalsValid = false;
            }

            BtnAlgorithmActivationControlSystem();
        }

        private bool CellsContainOnlyNumberControl()
        {
            foreach (DataGridViewRow row in DataTable.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!IsNumeric(cell.FormattedValue.ToString())) return false;
                }
            }
            return true;
        }

        private bool IsNumeric(string value)
        {
            double result;
            return double.TryParse(value, out result);
        }

        private void BtnAlgorithmActivationControlSystem()
        {
            if (tableTotalsValid && ControlTableFilled() && CellsContainOnlyNumberControl())
            {
                NordOvestBTN.Enabled = true;
                MinimalCostsBTN.Enabled = true;
                AllMetodsBTN.Enabled = true;
            }
            else
            {
                NordOvestBTN.Enabled = false;
                MinimalCostsBTN.Enabled = false;
                AllMetodsBTN.Enabled = false;
            }
        }

        private bool ControlTableFilled()
        {
            foreach (DataGridViewRow row in DataTable.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || cell.Value.ToString() == "")
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void FillTable(object sender, EventArgs e)
        {
            Frames.SelectedTab = MainFrame;
            FillTable();
        }

        private void FillTable()
        {
            SetDefaultNumberGenerator();

            int min = (int)MinNum.Value;
            int max = (int)MaxNum.Value;

            Random r = new Random();

            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nCols; j++)
                {
                    DataTable.Rows[i].Cells[j].Value = r.Next(min, max);
                }
            }
        }

        private void SetDefaultNumberGenerator()
        {
            if (MinNum.Value == 0) MinNum.Value = 10;
            if (MaxNum.Value == 0) MaxNum.Value = 100;
            if (MinNum.Value > MaxNum.Value) MaxNum.Value = MinNum.Value+1;
        }

        // riempimento casuale dei totali
        private void FillTotals(object sender, EventArgs e)
        {
            Frames.SelectedTab = MainFrame;
            FillTotals();
        }

        private void FillTotals()
        {
            SetDefaultNumberGenerator();

            Random r = new Random();

            int min = (int)MinNum.Value;
            int max = (int)MaxNum.Value;

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
                    DataTable.Rows[nRows - 1].Cells[nCols].Value = (int)DataTable.Rows[nRows - 1].Cells[nCols].Value + (totalRowSum() - totalColumnSum());
                }
                else
                {
                    DataTable.Rows[nRows].Cells[nCols - 1].Value = (int)DataTable.Rows[nRows].Cells[nCols - 1].Value + (totalColumnSum() - totalRowSum());
                }

            }
            controlTotal();
        }

        private void FillTotalTable(object sender, EventArgs e)
        {
            Frames.SelectedTab = MainFrame;
            FillTable();
            FillTotals();
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

        private void NordOvestAlgorithm_Click(object sender, EventArgs e)
        {
            NordOvestAlgorithmInitialize();
        }

        private void NordOvestAlgorithmInitialize()
        {
            /*if (NordOvestFrame.Controls.Count > 0)
            {
                NordOvestFrame.Controls.Clear();
            }*/
            DataGridView nordOvestGrid = CloneDataGrid(DataTable);
            nordOvestGrid.Dock = DockStyle.Fill;
            nordOvestGrid.AutoResizeColumnHeadersHeight();
            nordOvestGrid.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);
            nordOvestGrid.ReadOnly = true;

            //NordOvestFrame.Controls.Add(nordOvestGrid);
            //Frames.SelectedTab = NordOvestFrame;

            OutputWindowSystem();

            NordOvestAlgorithm(nordOvestGrid);
        }

        private void NordOvestAlgorithm(DataGridView grid)
        {
            int costoTot = 0;
            int currentD = 0;
            int currentUP = 0;

            int[,] arr = TableToMatrix(grid);

            ow.addLineString("Nord Ovest:");
            ow.addSeparator();

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
                //Frames.SelectedTab = NordOvestFrame;

                int UPn = arr[currentUP, arr.GetLength(1) - 1];
                int Dn = arr[arr.GetLength(0) - 1, currentD];
                int price = arr[currentUP, currentD];

                int unitaVendute;
                int nUpCorrente = currentUP+1;
                int nDCorrente = currentD+1;
                int costoTemp;

                if (UPn >= Dn)
                {
                    costoTot += price * Dn;
                    arr[currentUP, arr.GetLength(1) - 1] -= Dn;
                    arr[arr.GetLength(0) - 1, currentD] = 0;
                    //Console.WriteLine(price * Dn);
                    currentD++;

                    unitaVendute = Dn;
                    costoTemp = price * Dn;
                }
                else
                {
                    costoTot += price * UPn;
                    arr[currentUP, arr.GetLength(1) - 1] = 0;
                    arr[arr.GetLength(0) - 1, currentD] -= UPn;
                    //Console.WriteLine(price * UPn);
                    currentUP++;

                    unitaVendute = UPn;
                    costoTemp = price * UPn;
                }

                ow.addLineString($"Da Produttore UP nr.{nUpCorrente} a Consumatore D nr.{nDCorrente} : {unitaVendute} unità a {price.ToString("N2")} € = {costoTemp.ToString("N2")} €");

            }

            ow.addSeparator();
            ow.addLineString($"Costo totale: {costoTot.ToString("N2")} €");
            ow.addSeparator();
            ow.addBreakLine();
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

        private void ResetOutputWindow()
        {
            ow = new OutputWindow();
        }

        private void MinimalCostsAlgorithm_Click(object sender, EventArgs e)
        {
            MinimalCostsAlgorithmInitialize();
        }

        private void MinimalCostsAlgorithmInitialize()
        {
            /*if (MinimalCostsFrame.Controls.Count > 0)
            {
                MinimalCostsFrame.Controls.Clear();
            }*/
            DataGridView minimalCostsGrid = CloneDataGrid(DataTable);
            minimalCostsGrid.Dock = DockStyle.Fill;
            minimalCostsGrid.AutoResizeColumnHeadersHeight();
            minimalCostsGrid.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);
            minimalCostsGrid.ReadOnly = true;

            //MinimalCostsFrame.Controls.Add(minimalCostsGrid);
            //Frames.SelectedTab = MinimalCostsFrame;

            OutputWindowSystem();

            MinimalCostsAlgorithm(minimalCostsGrid);
        }

        private void MinimalCostsAlgorithm(DataGridView grid)
        {
            int costoTot = 0;
            int currentD = 0;
            int currentUP = 0;

            int[,] arr = TableToMatrix(grid);

            ow.addLineString("Minimi Costi:");
            ow.addSeparator();

            while (currentUP < arr.GetLength(0) - 1 && currentD < arr.GetLength(1) - 1)
            {
                int minCost = int.MaxValue;
                int minCostRow = -1;
                int minCostCol = -1;

                for (int i = 0; i < arr.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < arr.GetLength(1) - 1; j++)
                    {
                        if (arr[i, j] < minCost && arr[i, arr.GetLength(1) - 1] > 0 && arr[arr.GetLength(0) - 1, j] > 0)
                        {
                            minCost = arr[i, j];
                            minCostRow = i;
                            minCostCol = j;
                        }
                    }
                }

                if (minCostRow == -1 || minCostCol == -1)
                {
                    break;
                }

                int minSupply = arr[minCostRow, arr.GetLength(1) - 1];
                int minDemand = arr[arr.GetLength(0) - 1, minCostCol];
                int transferQuantity = Math.Min(minSupply, minDemand);

                costoTot += transferQuantity * minCost;
                arr[minCostRow, arr.GetLength(1) - 1] -= transferQuantity;
                arr[arr.GetLength(0) - 1, minCostCol] -= transferQuantity;

                ow.addLineString($"Da Produttore UP nr.{minCostRow + 1} a Consumatore D nr.{minCostCol + 1} : {transferQuantity} unità a {minCost.ToString("N2")} € = {(transferQuantity * minCost).ToString("N2")} €");

                if (arr[minCostRow, arr.GetLength(1) - 1] == 0)
                {
                    currentUP++;
                }

                if (arr[arr.GetLength(0) - 1, minCostCol] == 0)
                {
                    currentD++;
                }
            }

            ow.addSeparator();
            ow.addLineString($"Costo totale: {costoTot.ToString("N2")} €");
            ow.addSeparator();
            ow.addBreakLine();
        }

        public void OutputWindowSystem()
        {
            if (!owWasClosed && !owIsOpened)
            {
                ow.Show();
                owIsOpened = true;
            }
            else if (!owIsOpened && owWasClosed)
            {
                ResetOutputWindow();
                ow.Show();
                owIsOpened = true;
                owWasClosed = false;
            }
        }

        private void AllMethods_Click(object sender, EventArgs e)
        {
            NordOvestAlgorithmInitialize();
            MinimalCostsAlgorithmInitialize();
        }
    }

    public partial class OutputWindow : Form
    {
        ListBox outputListBox = new ListBox();
        public OutputWindow()
        {
            this.TopMost = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Text = "Output";

            this.Width = 700;
            this.Height = 700;
            
            outputListBox.Font = new Font("Arial", 12, FontStyle.Regular);
            outputListBox.Dock = DockStyle.Fill;

            this.Controls.Add(outputListBox);

            this.FormClosed += (sender, e) => {
                Form1.owWasClosed = true;
                Form1.owIsOpened = false;
            };
        }

        public void addLineString(String str)
        {
            outputListBox.Items.Add(str);
        }

        public void addSeparator()
        {
            outputListBox.Items.Add("---------------------------");
        }

        public void addBreakLine()
        {
            outputListBox.Items.Add('\n');
        }
    }
}
