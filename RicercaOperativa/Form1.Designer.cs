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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 125);
            this.panel1.TabIndex = 0;
            // 
            // NordOvestBTN
            // 
            this.NordOvestBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NordOvestBTN.Location = new System.Drawing.Point(1080, 11);
            this.NordOvestBTN.Name = "NordOvestBTN";
            this.NordOvestBTN.Size = new System.Drawing.Size(219, 45);
            this.NordOvestBTN.TabIndex = 14;
            this.NordOvestBTN.Text = "Nord Ovest";
            this.NordOvestBTN.UseVisualStyleBackColor = true;
            this.NordOvestBTN.Click += new System.EventHandler(this.NordOvestAlgorithm);
            // 
            // TotalsGeneratorBTN
            // 
            this.TotalsGeneratorBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TotalsGeneratorBTN.Location = new System.Drawing.Point(794, 65);
            this.TotalsGeneratorBTN.Name = "TotalsGeneratorBTN";
            this.TotalsGeneratorBTN.Size = new System.Drawing.Size(219, 45);
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
            this.TotalsVerifiedLabel.Location = new System.Drawing.Point(1019, 13);
            this.TotalsVerifiedLabel.Name = "TotalsVerifiedLabel";
            this.TotalsVerifiedLabel.Size = new System.Drawing.Size(37, 36);
            this.TotalsVerifiedLabel.TabIndex = 12;
            this.TotalsVerifiedLabel.Text = "X";
            // 
            // FillTableBTN
            // 
            this.FillTableBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FillTableBTN.Location = new System.Drawing.Point(569, 65);
            this.FillTableBTN.Name = "FillTableBTN";
            this.FillTableBTN.Size = new System.Drawing.Size(219, 45);
            this.FillTableBTN.TabIndex = 10;
            this.FillTableBTN.Text = "Riempi Tabella";
            this.FillTableBTN.UseVisualStyleBackColor = true;
            this.FillTableBTN.Click += new System.EventHandler(this.FillTable);
            // 
            // CreateTableBTN
            // 
            this.CreateTableBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateTableBTN.Location = new System.Drawing.Point(569, 11);
            this.CreateTableBTN.Name = "CreateTableBTN";
            this.CreateTableBTN.Size = new System.Drawing.Size(219, 45);
            this.CreateTableBTN.TabIndex = 9;
            this.CreateTableBTN.Text = "Genera Tabella";
            this.CreateTableBTN.UseVisualStyleBackColor = true;
            this.CreateTableBTN.Click += new System.EventHandler(this.CreateTable_OnClick);
            // 
            // ControlTotalsBTN
            // 
            this.ControlTotalsBTN.Enabled = false;
            this.ControlTotalsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ControlTotalsBTN.Location = new System.Drawing.Point(794, 11);
            this.ControlTotalsBTN.Name = "ControlTotalsBTN";
            this.ControlTotalsBTN.Size = new System.Drawing.Size(219, 45);
            this.ControlTotalsBTN.TabIndex = 11;
            this.ControlTotalsBTN.Text = "Controlla Totali";
            this.ControlTotalsBTN.UseVisualStyleBackColor = true;
            this.ControlTotalsBTN.Click += new System.EventHandler(this.controlTotal);
            // 
            // MaxNum
            // 
            this.MaxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.MaxNum.Location = new System.Drawing.Point(430, 76);
            this.MaxNum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.MaxNum.Name = "MaxNum";
            this.MaxNum.Size = new System.Drawing.Size(92, 41);
            this.MaxNum.TabIndex = 8;
            // 
            // MinNum
            // 
            this.MinNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.MinNum.Location = new System.Drawing.Point(408, 29);
            this.MinNum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.MinNum.Name = "MinNum";
            this.MinNum.Size = new System.Drawing.Size(99, 41);
            this.MinNum.TabIndex = 7;
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLabel.Location = new System.Drawing.Point(283, 78);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(141, 36);
            this.MaxLabel.TabIndex = 6;
            this.MaxLabel.Text = "Massimo:";
            // 
            // RandomValuesInfoLabel
            // 
            this.RandomValuesInfoLabel.AutoSize = true;
            this.RandomValuesInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RandomValuesInfoLabel.Location = new System.Drawing.Point(284, 0);
            this.RandomValuesInfoLabel.Name = "RandomValuesInfoLabel";
            this.RandomValuesInfoLabel.Size = new System.Drawing.Size(238, 29);
            this.RandomValuesInfoLabel.TabIndex = 5;
            this.RandomValuesInfoLabel.Text = "Genera valori casuali";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLabel.Location = new System.Drawing.Point(283, 29);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(119, 36);
            this.MinLabel.TabIndex = 4;
            this.MinLabel.Text = "Minimo:";
            // 
            // ColumnNum
            // 
            this.ColumnNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ColumnNum.Location = new System.Drawing.Point(153, 63);
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
            this.ColumnNum.Size = new System.Drawing.Size(77, 41);
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
            this.RowNum.Location = new System.Drawing.Point(103, 7);
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
            this.RowNum.Size = new System.Drawing.Size(77, 41);
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
            this.ColumnLabel.Location = new System.Drawing.Point(12, 65);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(135, 36);
            this.ColumnLabel.TabIndex = 1;
            this.ColumnLabel.Text = "Colonna:";
            // 
            // RowLabel
            // 
            this.RowLabel.AutoSize = true;
            this.RowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowLabel.Location = new System.Drawing.Point(12, 9);
            this.RowLabel.Name = "RowLabel";
            this.RowLabel.Size = new System.Drawing.Size(85, 36);
            this.RowLabel.TabIndex = 0;
            this.RowLabel.Text = "Riga:";
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTable.Location = new System.Drawing.Point(3, 3);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.RowTemplate.Height = 24;
            this.DataTable.Size = new System.Drawing.Size(1341, 375);
            this.DataTable.TabIndex = 1;
            // 
            // Frames
            // 
            this.Frames.Controls.Add(this.MainFrame);
            this.Frames.Controls.Add(this.NordOvestFrame);
            this.Frames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Frames.Location = new System.Drawing.Point(0, 125);
            this.Frames.Name = "Frames";
            this.Frames.SelectedIndex = 0;
            this.Frames.Size = new System.Drawing.Size(1355, 410);
            this.Frames.TabIndex = 15;
            // 
            // MainFrame
            // 
            this.MainFrame.Controls.Add(this.DataTable);
            this.MainFrame.Location = new System.Drawing.Point(4, 25);
            this.MainFrame.Name = "MainFrame";
            this.MainFrame.Padding = new System.Windows.Forms.Padding(3);
            this.MainFrame.Size = new System.Drawing.Size(1347, 381);
            this.MainFrame.TabIndex = 0;
            this.MainFrame.Text = "Main View";
            this.MainFrame.UseVisualStyleBackColor = true;
            // 
            // NordOvestFrame
            // 
            this.NordOvestFrame.Location = new System.Drawing.Point(4, 25);
            this.NordOvestFrame.Name = "NordOvestFrame";
            this.NordOvestFrame.Padding = new System.Windows.Forms.Padding(3);
            this.NordOvestFrame.Size = new System.Drawing.Size(1347, 381);
            this.NordOvestFrame.TabIndex = 1;
            this.NordOvestFrame.Text = "NordOvest";
            this.NordOvestFrame.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1355, 535);
            this.Controls.Add(this.Frames);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}

