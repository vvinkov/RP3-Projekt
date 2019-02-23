namespace Kino
{
    partial class DodajFilm
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
            this.tableNoviFilm = new System.Windows.Forms.TableLayoutPanel();
            this.datZavrPrikaz = new System.Windows.Forms.DateTimePicker();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblDatPoc = new System.Windows.Forms.Label();
            this.lblDatKraj = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.datPocPrikaz = new System.Windows.Forms.DateTimePicker();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.numTrajanje = new System.Windows.Forms.NumericUpDown();
            this.tableNoviFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrajanje)).BeginInit();
            this.SuspendLayout();
            // 
            // tableNoviFilm
            // 
            this.tableNoviFilm.ColumnCount = 2;
            this.tableNoviFilm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableNoviFilm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableNoviFilm.Controls.Add(this.lblTrajanje, 0, 3);
            this.tableNoviFilm.Controls.Add(this.datZavrPrikaz, 1, 2);
            this.tableNoviFilm.Controls.Add(this.lblNaziv, 0, 0);
            this.tableNoviFilm.Controls.Add(this.lblDatPoc, 0, 1);
            this.tableNoviFilm.Controls.Add(this.lblDatKraj, 0, 2);
            this.tableNoviFilm.Controls.Add(this.txtNaziv, 1, 0);
            this.tableNoviFilm.Controls.Add(this.datPocPrikaz, 1, 1);
            this.tableNoviFilm.Controls.Add(this.numTrajanje, 1, 3);
            this.tableNoviFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableNoviFilm.Location = new System.Drawing.Point(0, 0);
            this.tableNoviFilm.Name = "tableNoviFilm";
            this.tableNoviFilm.RowCount = 4;
            this.tableNoviFilm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableNoviFilm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableNoviFilm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableNoviFilm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableNoviFilm.Size = new System.Drawing.Size(393, 151);
            this.tableNoviFilm.TabIndex = 0;
            // 
            // datZavrPrikaz
            // 
            this.datZavrPrikaz.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.datZavrPrikaz.Location = new System.Drawing.Point(199, 81);
            this.datZavrPrikaz.Name = "datZavrPrikaz";
            this.datZavrPrikaz.Size = new System.Drawing.Size(191, 22);
            this.datZavrPrikaz.TabIndex = 5;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNaziv.Location = new System.Drawing.Point(113, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(80, 37);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv filma:";
            this.lblNaziv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatPoc
            // 
            this.lblDatPoc.AutoSize = true;
            this.lblDatPoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDatPoc.Location = new System.Drawing.Point(7, 37);
            this.lblDatPoc.Name = "lblDatPoc";
            this.lblDatPoc.Size = new System.Drawing.Size(186, 37);
            this.lblDatPoc.TabIndex = 1;
            this.lblDatPoc.Text = "Datum početka prikazivanja:";
            this.lblDatPoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatKraj
            // 
            this.lblDatKraj.AutoSize = true;
            this.lblDatKraj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatKraj.Location = new System.Drawing.Point(3, 74);
            this.lblDatKraj.Name = "lblDatKraj";
            this.lblDatKraj.Size = new System.Drawing.Size(190, 37);
            this.lblDatKraj.TabIndex = 2;
            this.lblDatKraj.Text = "Datum završetka prikazivanja:";
            this.lblDatKraj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNaziv.Location = new System.Drawing.Point(199, 7);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(191, 22);
            this.txtNaziv.TabIndex = 3;
            // 
            // datPocPrikaz
            // 
            this.datPocPrikaz.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.datPocPrikaz.Location = new System.Drawing.Point(199, 44);
            this.datPocPrikaz.Name = "datPocPrikaz";
            this.datPocPrikaz.Size = new System.Drawing.Size(191, 22);
            this.datPocPrikaz.TabIndex = 4;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(131, 190);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(112, 35);
            this.btnPotvrdi.TabIndex = 1;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.potvrdi);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(269, 190);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(112, 35);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.odustani);
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrajanje.Location = new System.Drawing.Point(3, 111);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(190, 40);
            this.lblTrajanje.TabIndex = 6;
            this.lblTrajanje.Text = "Trajanje (u minutama):";
            this.lblTrajanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numTrajanje
            // 
            this.numTrajanje.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numTrajanje.Location = new System.Drawing.Point(199, 120);
            this.numTrajanje.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numTrajanje.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrajanje.Name = "numTrajanje";
            this.numTrajanje.Size = new System.Drawing.Size(191, 22);
            this.numTrajanje.TabIndex = 7;
            this.numTrajanje.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // DodajFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 237);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.tableNoviFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj film";
            this.tableNoviFilm.ResumeLayout(false);
            this.tableNoviFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrajanje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableNoviFilm;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblDatPoc;
        private System.Windows.Forms.Label lblDatKraj;
        private System.Windows.Forms.DateTimePicker datZavrPrikaz;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.DateTimePicker datPocPrikaz;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.NumericUpDown numTrajanje;
    }
}