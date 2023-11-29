namespace RicercaOperativa
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimalCostsBTN = new System.Windows.Forms.Button();
            this.FillTotalTableBTN = new System.Windows.Forms.Button();
            this.NordOvestBTN = new System.Windows.Forms.Button();
            this.TotalsGeneratorBTN = new System.Windows.Forms.Button();
            this.TotalsVerifiedLabel = new System.Windows.Forms.Label();
            this.FillTableBTN = new System.Windows.Forms.Button();
            this.CreateTableBTN = new System.Windows.Forms.Button();
            this.ControlTotalsBTN = new System.Windows.Forms.Button();
            this.MaxNum = new System.Windows.Forms.NumericUpDown();
            this.MinNum = new System.Windows.Forms.NumericUpDown();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.RandomValuesInfoLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.ColumnNum = new System.Windows.Forms.NumericUpDown();
            this.RowNum = new System.Windows.Forms.NumericUpDown();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.RowLabel = new System.Windows.Forms.Label();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.Frames = new System.Windows.Forms.TabControl();
            this.MainFrame = new System.Windows.Forms.TabPage();
            this.NordOvestFrame = new System.Windows.Forms.TabPage();
            this.MinimalCostsFrame = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.Frames.SuspendLayout();
            this.MainFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MinimalCostsBTN);
            this.panel1.Controls.Add(this.FillTotalTableBTN);
            this.panel1.Controls.Add(this.NordOvestBTN);
            this.panel1.Controls.Add(this.TotalsGeneratorBTN);
            this.panel1.Controls.Add(this.TotalsVerifiedLabel);
            this.panel1.Controls.Add(this.FillTableBTN);
            this.panel1.Controls.Add(this.CreateTableBTN);
            this.panel1.Controls.Add(this.ControlTotalsBTN);
            this.panel1.Controls.Add(this.MaxNum);
            this.panel1.Controls.Add(this.MinNum);
            this.panel1.Controls.Add(this.MaxLabel);
            this.panel1.Controls.Add(this.RandomValuesInfoLabel);
            this.panel1.Controls.Add(this.MinLabel);
            this.panel1.Controls.Add(this.ColumnNum);
            this.panel1.Controls.Add(this.RowNum);
            this.panel1.Controls.Add(this.ColumnLabel);
            this.panel1.Controls.Add(this.RowLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 102);
            this.panel1.TabIndex = 0;
            // 
            // MinimalCostsBTN
            // 
            this.MinimalCostsBTN.Enabled = false;
            this.MinimalCostsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MinimalCostsBTN.Location = new System.Drawing.Point(978, 9);
            this.MinimalCostsBTN.Margin = new System.Windows.Forms.Padding(2);
            this.MinimalCostsBTN.Name = "MinimalCostsBTN";
            this.MinimalCostsBTN.Size = new System.Drawing.Size(164, 37);
            this.MinimalCostsBTN.TabIndex = 16;
            this.MinimalCostsBTN.Text = "Minimi Costi";
            this.MinimalCostsBTN.UseVisualStyleBackColor = true;
            this.MinimalCostsBTN.Click += new System.EventHandler(this.MinimalCostsAlgorithm_Click);
            // 
            // FillTotalTableBTN
            // 
            this.FillTotalTableBTN.Enabled = false;
            this.FillTotalTableBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FillTotalTableBTN.Location = new System.Drawing.Point(764, 53);
            this.FillTotalTableBTN.Margin = new System.Windows.Forms.Padding(2);
            this.FillTotalTableBTN.Name = "FillTotalTableBTN";
            this.FillTotalTableBTN.Size = new System.Drawing.Size(240, 37);
            this.FillTotalTableBTN.TabIndex = 15;
            this.FillTotalTableBTN.Text = "Riempi TUTTA la Tabella";
            this.FillTotalTableBTN.UseVisualStyleBackColor = true;
            this.FillTotalTableBTN.Click += new System.EventHandler(this.FillTotalTable);
            // 
            // NordOvestBTN
            // 
            this.NordOvestBTN.Enabled = false;
            this.NordOvestBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NordOvestBTN.Location = new System.Drawing.Point(810, 9);
            this.NordOvestBTN.Margin = new System.Windows.Forms.Padding(2);
            this.NordOvestBTN.Name = "NordOvestBTN";
            this.NordOvestBTN.Size = new System.Drawing.Size(164, 37);
            this.NordOvestBTN.TabIndex = 14;
            this.NordOvestBTN.Text = "Nord Ovest";
            this.NordOvestBTN.UseVisualStyleBackColor = true;
            this.NordOvestBTN.Click += new System.EventHandler(this.NordOvestAlgorithm_Click);
            // 
            // TotalsGeneratorBTN
            // 
            this.TotalsGeneratorBTN.Enabled = false;
            this.TotalsGeneratorBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TotalsGeneratorBTN.Location = new System.Drawing.Point(596, 53);
            this.TotalsGeneratorBTN.Margin = new System.Windows.Forms.Padding(2);
            this.TotalsGeneratorBTN.Name = "TotalsGeneratorBTN";
            this.TotalsGeneratorBTN.Size = new System.Drawing.Size(164, 37);
            this.TotalsGeneratorBTN.TabIndex = 13;
            this.TotalsGeneratorBTN.Text = "Genera Totali";
            this.TotalsGeneratorBTN.UseVisualStyleBackColor = true;
            this.TotalsGeneratorBTN.Click += new System.EventHandler(this.FillTotals);
            // 
            // TotalsVerifiedLabel
            // 
            this.TotalsVerifiedLabel.AutoSize = true;
            this.TotalsVerifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.TotalsVerifiedLabel.ForeColor = System.Drawing.Color.Red;
            this.TotalsVerifiedLabel.Location = new System.Drawing.Point(764, 11);
            this.TotalsVerifiedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalsVerifiedLabel.Name = "TotalsVerifiedLabel";
            this.TotalsVerifiedLabel.Size = new System.Drawing.Size(31, 29);
            this.TotalsVerifiedLabel.TabIndex = 12;
            this.TotalsVerifiedLabel.Text = "X";
            // 
            // FillTableBTN
            // 
            this.FillTableBTN.Enabled = false;
            this.FillTableBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FillTableBTN.Location = new System.Drawing.Point(427, 53);
            this.FillTableBTN.Margin = new System.Windows.Forms.Padding(2);
            this.FillTableBTN.Name = "FillTableBTN";
            this.FillTableBTN.Size = new System.Drawing.Size(164, 37);
            this.FillTableBTN.TabIndex = 10;
            this.FillTableBTN.Text = "Riempi Tabella";
            this.FillTableBTN.UseVisualStyleBackColor = true;
            this.FillTableBTN.Click += new System.EventHandler(this.FillTable);
            // 
            // CreateTableBTN
            // 
            this.CreateTableBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateTableBTN.Location = new System.Drawing.Point(427, 9);
            this.CreateTableBTN.Margin = new System.Windows.Forms.Padding(2);
            this.CreateTableBTN.Name = "CreateTableBTN";
            this.CreateTableBTN.Size = new System.Drawing.Size(164, 37);
            this.CreateTableBTN.TabIndex = 9;
            this.CreateTableBTN.Text = "Genera Tabella";
            this.CreateTableBTN.UseVisualStyleBackColor = true;
            this.CreateTableBTN.Click += new System.EventHandler(this.CreateTable_OnClick);
            // 
            // ControlTotalsBTN
            // 
            this.ControlTotalsBTN.Enabled = false;
            this.ControlTotalsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ControlTotalsBTN.Location = new System.Drawing.Point(596, 9);
            this.ControlTotalsBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ControlTotalsBTN.Name = "ControlTotalsBTN";
            this.ControlTotalsBTN.Size = new System.Drawing.Size(164, 37);
            this.ControlTotalsBTN.TabIndex = 11;
            this.ControlTotalsBTN.Text = "Controlla Totali";
            this.ControlTotalsBTN.UseVisualStyleBackColor = true;
            this.ControlTotalsBTN.Click += new System.EventHandler(this.controlTotal);
            // 
            // MaxNum
            // 
            this.MaxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.MaxNum.Location = new System.Drawing.Point(322, 62);
            this.MaxNum.Margin = new System.Windows.Forms.Padding(2);
            this.MaxNum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.MaxNum.Name = "MaxNum";
            this.MaxNum.Size = new System.Drawing.Size(69, 35);
            this.MaxNum.TabIndex = 8;
            // 
            // MinNum
            // 
            this.MinNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.MinNum.Location = new System.Drawing.Point(306, 24);
            this.MinNum.Margin = new System.Windows.Forms.Padding(2);
            this.MinNum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.MinNum.Name = "MinNum";
            this.MinNum.Size = new System.Drawing.Size(74, 35);
            this.MinNum.TabIndex = 7;
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLabel.Location = new System.Drawing.Point(212, 63);
            this.MaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(116, 29);
            this.MaxLabel.TabIndex = 6;
            this.MaxLabel.Text = "Massimo:";
            // 
            // RandomValuesInfoLabel
            // 
            this.RandomValuesInfoLabel.AutoSize = true;
            this.RandomValuesInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RandomValuesInfoLabel.Location = new System.Drawing.Point(213, 0);
            this.RandomValuesInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RandomValuesInfoLabel.Name = "RandomValuesInfoLabel";
            this.RandomValuesInfoLabel.Size = new System.Drawing.Size(185, 24);
            this.RandomValuesInfoLabel.TabIndex = 5;
            this.RandomValuesInfoLabel.Text = "Genera valori casuali";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLabel.Location = new System.Drawing.Point(212, 24);
            this.MinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(98, 29);
            this.MinLabel.TabIndex = 4;
            this.MinLabel.Text = "Minimo:";
            // 
            // ColumnNum
            // 
            this.ColumnNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ColumnNum.Location = new System.Drawing.Point(115, 51);
            this.ColumnNum.Margin = new System.Windows.Forms.Padding(2);
            this.ColumnNum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ColumnNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ColumnNum.Name = "ColumnNum";
            this.ColumnNum.Size = new System.Drawing.Size(58, 35);
            this.ColumnNum.TabIndex = 3;
            this.ColumnNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // RowNum
            // 
            this.RowNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.RowNum.Location = new System.Drawing.Point(77, 6);
            this.RowNum.Margin = new System.Windows.Forms.Padding(2);
            this.RowNum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.RowNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RowNum.Name = "RowNum";
            this.RowNum.Size = new System.Drawing.Size(58, 35);
            this.RowNum.TabIndex = 2;
            this.RowNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.AllowDrop = true;
            this.ColumnLabel.AutoSize = true;
            this.ColumnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnLabel.Location = new System.Drawing.Point(9, 53);
            this.ColumnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(109, 29);
            this.ColumnLabel.TabIndex = 1;
            this.ColumnLabel.Text = "Colonna:";
            // 
            // RowLabel
            // 
            this.RowLabel.AutoSize = true;
            this.RowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowLabel.Location = new System.Drawing.Point(9, 7);
            this.RowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RowLabel.Name = "RowLabel";
            this.RowLabel.Size = new System.Drawing.Size(69, 29);
            this.RowLabel.TabIndex = 0;
            this.RowLabel.Text = "Riga:";
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTable.Location = new System.Drawing.Point(2, 2);
            this.DataTable.Margin = new System.Windows.Forms.Padding(2);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.RowTemplate.Height = 24;
            this.DataTable.Size = new System.Drawing.Size(1164, 303);
            this.DataTable.TabIndex = 1;
            // 
            // Frames
            // 
            this.Frames.Controls.Add(this.MainFrame);
            this.Frames.Controls.Add(this.MinimalCostsFrame);
            this.Frames.Controls.Add(this.NordOvestFrame);
            this.Frames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Frames.Location = new System.Drawing.Point(0, 102);
            this.Frames.Margin = new System.Windows.Forms.Padding(2);
            this.Frames.Name = "Frames";
            this.Frames.SelectedIndex = 0;
            this.Frames.Size = new System.Drawing.Size(1176, 333);
            this.Frames.TabIndex = 15;
            // 
            // MainFrame
            // 
            this.MainFrame.Controls.Add(this.DataTable);
            this.MainFrame.Location = new System.Drawing.Point(4, 22);
            this.MainFrame.Margin = new System.Windows.Forms.Padding(2);
            this.MainFrame.Name = "MainFrame";
            this.MainFrame.Padding = new System.Windows.Forms.Padding(2);
            this.MainFrame.Size = new System.Drawing.Size(1168, 307);
            this.MainFrame.TabIndex = 0;
            this.MainFrame.Text = "Main View";
            this.MainFrame.UseVisualStyleBackColor = true;
            // 
            // NordOvestFrame
            // 
            this.NordOvestFrame.Location = new System.Drawing.Point(4, 22);
            this.NordOvestFrame.Margin = new System.Windows.Forms.Padding(2);
            this.NordOvestFrame.Name = "NordOvestFrame";
            this.NordOvestFrame.Padding = new System.Windows.Forms.Padding(2);
            this.NordOvestFrame.Size = new System.Drawing.Size(1168, 307);
            this.NordOvestFrame.TabIndex = 1;
            this.NordOvestFrame.Text = "NordOvest";
            this.NordOvestFrame.UseVisualStyleBackColor = true;
            // 
            // MinimalCostsFrame
            // 
            this.MinimalCostsFrame.Location = new System.Drawing.Point(4, 22);
            this.MinimalCostsFrame.Margin = new System.Windows.Forms.Padding(2);
            this.MinimalCostsFrame.Name = "MinimalCostsFrame";
            this.MinimalCostsFrame.Padding = new System.Windows.Forms.Padding(2);
            this.MinimalCostsFrame.Size = new System.Drawing.Size(1168, 307);
            this.MinimalCostsFrame.TabIndex = 2;
            this.MinimalCostsFrame.Text = "MinimalCosts";
            this.MinimalCostsFrame.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1176, 435);
            this.Controls.Add(this.Frames);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ricerca Operativa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.Frames.ResumeLayout(false);
            this.MainFrame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ColumnLabel;
        private System.Windows.Forms.Label RowLabel;
        private System.Windows.Forms.NumericUpDown ColumnNum;
        private System.Windows.Forms.NumericUpDown RowNum;
        private System.Windows.Forms.NumericUpDown MaxNum;
        private System.Windows.Forms.NumericUpDown MinNum;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label RandomValuesInfoLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Button FillTableBTN;
        private System.Windows.Forms.Button CreateTableBTN;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Button ControlTotalsBTN;
        private System.Windows.Forms.Label TotalsVerifiedLabel;
        private System.Windows.Forms.Button TotalsGeneratorBTN;
        private System.Windows.Forms.Button NordOvestBTN;
        private System.Windows.Forms.TabControl Frames;
        private System.Windows.Forms.TabPage MainFrame;
        private System.Windows.Forms.TabPage NordOvestFrame;
        private System.Windows.Forms.Button FillTotalTableBTN;
        private System.Windows.Forms.Button MinimalCostsBTN;
        private System.Windows.Forms.TabPage MinimalCostsFrame;
    }
}

