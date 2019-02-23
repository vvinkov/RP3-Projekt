namespace Kino
{
    partial class DodajDvoranu
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
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblSjedala = new System.Windows.Forms.Label();
            this.lblRedovi = new System.Windows.Forms.Label();
            this.txtTipDvorane = new System.Windows.Forms.TextBox();
            this.numBrojRedova = new System.Windows.Forms.NumericUpDown();
            this.numBrojSjedala = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojRedova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojSjedala)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanel1.Controls.Add(this.lblTip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSjedala, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRedovi, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numBrojSjedala, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTipDvorane, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numBrojRedova, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 215);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(12, 233);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(112, 35);
            this.btnPotvrdi.TabIndex = 4;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.potvrdi);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(130, 233);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(112, 35);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.odustani);
            // 
            // lblTip
            // 
            this.lblTip.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(35, 27);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(88, 17);
            this.lblTip.TabIndex = 1;
            this.lblTip.Text = "Tip dvorane:";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSjedala
            // 
            this.lblSjedala.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSjedala.AutoSize = true;
            this.lblSjedala.Location = new System.Drawing.Point(37, 98);
            this.lblSjedala.Name = "lblSjedala";
            this.lblSjedala.Size = new System.Drawing.Size(86, 17);
            this.lblSjedala.TabIndex = 2;
            this.lblSjedala.Text = "Broj sjedala:";
            this.lblSjedala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRedovi
            // 
            this.lblRedovi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRedovi.AutoSize = true;
            this.lblRedovi.Location = new System.Drawing.Point(38, 170);
            this.lblRedovi.Name = "lblRedovi";
            this.lblRedovi.Size = new System.Drawing.Size(85, 17);
            this.lblRedovi.TabIndex = 3;
            this.lblRedovi.Text = "Broj redova:";
            this.lblRedovi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTipDvorane
            // 
            this.txtTipDvorane.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTipDvorane.Location = new System.Drawing.Point(129, 24);
            this.txtTipDvorane.Name = "txtTipDvorane";
            this.txtTipDvorane.Size = new System.Drawing.Size(120, 22);
            this.txtTipDvorane.TabIndex = 1;
            // 
            // numBrojRedova
            // 
            this.numBrojRedova.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numBrojRedova.Location = new System.Drawing.Point(129, 167);
            this.numBrojRedova.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numBrojRedova.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBrojRedova.Name = "numBrojRedova";
            this.numBrojRedova.Size = new System.Drawing.Size(120, 22);
            this.numBrojRedova.TabIndex = 3;
            this.numBrojRedova.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numBrojSjedala
            // 
            this.numBrojSjedala.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numBrojSjedala.Location = new System.Drawing.Point(129, 95);
            this.numBrojSjedala.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numBrojSjedala.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBrojSjedala.Name = "numBrojSjedala";
            this.numBrojSjedala.Size = new System.Drawing.Size(120, 22);
            this.numBrojSjedala.TabIndex = 2;
            this.numBrojSjedala.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DodajDvoranu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 280);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajDvoranu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj dvoranu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojRedova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojSjedala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblSjedala;
        private System.Windows.Forms.Label lblRedovi;
        private System.Windows.Forms.NumericUpDown numBrojSjedala;
        private System.Windows.Forms.NumericUpDown numBrojRedova;
        private System.Windows.Forms.TextBox txtTipDvorane;
    }
}