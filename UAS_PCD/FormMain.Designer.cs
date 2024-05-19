namespace UAS_PCD
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonUji = new System.Windows.Forms.Button();
            this.buttonUlang = new System.Windows.Forms.Button();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Original = new System.Windows.Forms.DataGridViewImageColumn();
            this.Hasil = new System.Windows.Forms.DataGridViewImageColumn();
            this.StepButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewHasil, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSimpan);
            this.panel1.Controls.Add(this.buttonUji);
            this.panel1.Controls.Add(this.buttonUlang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 34);
            this.panel1.TabIndex = 0;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSimpan.Location = new System.Drawing.Point(662, 8);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(123, 23);
            this.buttonSimpan.TabIndex = 2;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonUji
            // 
            this.buttonUji.Location = new System.Drawing.Point(138, 3);
            this.buttonUji.Name = "buttonUji";
            this.buttonUji.Size = new System.Drawing.Size(123, 23);
            this.buttonUji.TabIndex = 1;
            this.buttonUji.Text = "Uji";
            this.buttonUji.UseVisualStyleBackColor = true;
            this.buttonUji.Click += new System.EventHandler(this.buttonUji_Click);
            // 
            // buttonUlang
            // 
            this.buttonUlang.Location = new System.Drawing.Point(9, 3);
            this.buttonUlang.Name = "buttonUlang";
            this.buttonUlang.Size = new System.Drawing.Size(123, 23);
            this.buttonUlang.TabIndex = 0;
            this.buttonUlang.Text = "Ulang";
            this.buttonUlang.UseVisualStyleBackColor = true;
            this.buttonUlang.Click += new System.EventHandler(this.buttonUlang_Click);
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.AllowUserToAddRows = false;
            this.dataGridViewHasil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHasil.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.NamaFile,
            this.Original,
            this.Hasil,
            this.StepButton});
            this.dataGridViewHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHasil.Location = new System.Drawing.Point(3, 43);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.Size = new System.Drawing.Size(794, 374);
            this.dataGridViewHasil.TabIndex = 1;
            this.dataGridViewHasil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHasil_CellClick);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.FillWeight = 31.49243F;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 40;
            // 
            // NamaFile
            // 
            this.NamaFile.FillWeight = 147.2271F;
            this.NamaFile.HeaderText = "Nama File";
            this.NamaFile.Name = "NamaFile";
            // 
            // Original
            // 
            this.Original.FillWeight = 147.2271F;
            this.Original.HeaderText = "Original";
            this.Original.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Original.Name = "Original";
            this.Original.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Hasil
            // 
            this.Hasil.FillWeight = 147.2271F;
            this.Hasil.HeaderText = "Hasil";
            this.Hasil.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Hasil.Name = "Hasil";
            // 
            // StepButton
            // 
            this.StepButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StepButton.FillWeight = 25.30341F;
            this.StepButton.HeaderText = "Detail";
            this.StepButton.Name = "StepButton";
            this.StepButton.Text = "Detail";
            this.StepButton.UseColumnTextForButtonValue = true;
            this.StepButton.Width = 70;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 423);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(794, 24);
            this.progressBar1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_ShownAsync);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUlang;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaFile;
        private System.Windows.Forms.DataGridViewImageColumn Original;
        private System.Windows.Forms.DataGridViewImageColumn Hasil;
        private System.Windows.Forms.DataGridViewButtonColumn StepButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonUji;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonSimpan;
    }
}