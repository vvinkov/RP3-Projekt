namespace Kino
{
    partial class DodajZaduzenje
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblUloga = new System.Windows.Forms.Label();
            this.lblPocDatum = new System.Windows.Forms.Label();
            this.lblPocVrijeme = new System.Windows.Forms.Label();
            this.lblKrajDatum = new System.Windows.Forms.Label();
            this.lblKrajVrijeme = new System.Windows.Forms.Label();
            this.tblDodajZaduzenje = new System.Windows.Forms.TableLayoutPanel();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.pocDatum = new System.Windows.Forms.DateTimePicker();
            this.pocVrijeme = new System.Windows.Forms.DateTimePicker();
            this.krajDatum = new System.Windows.Forms.DateTimePicker();
            this.krajVrijeme = new System.Windows.Forms.DateTimePicker();
            this.txtUloga = new System.Windows.Forms.TextBox();
            this.tblDodajZaduzenje.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Location = new System.Drawing.Point(344, 302);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(97, 30);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.dodajZaduzenje_DB);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Location = new System.Drawing.Point(447, 302);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(97, 30);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.odustani);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblIme.Location = new System.Drawing.Point(238, 1);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 41);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime:";
            this.lblIme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPrezime.Location = new System.Drawing.Point(209, 43);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 41);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime:";
            this.lblPrezime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUloga.Location = new System.Drawing.Point(223, 85);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(49, 41);
            this.lblUloga.TabIndex = 4;
            this.lblUloga.Text = "Uloga:";
            this.lblUloga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPocDatum
            // 
            this.lblPocDatum.AutoSize = true;
            this.lblPocDatum.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPocDatum.Location = new System.Drawing.Point(165, 127);
            this.lblPocDatum.Name = "lblPocDatum";
            this.lblPocDatum.Size = new System.Drawing.Size(107, 41);
            this.lblPocDatum.TabIndex = 5;
            this.lblPocDatum.Text = "Datum početka:";
            this.lblPocDatum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPocVrijeme
            // 
            this.lblPocVrijeme.AutoSize = true;
            this.lblPocVrijeme.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPocVrijeme.Location = new System.Drawing.Point(159, 169);
            this.lblPocVrijeme.Name = "lblPocVrijeme";
            this.lblPocVrijeme.Size = new System.Drawing.Size(113, 41);
            this.lblPocVrijeme.TabIndex = 6;
            this.lblPocVrijeme.Text = "Vrijeme početka:";
            this.lblPocVrijeme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKrajDatum
            // 
            this.lblKrajDatum.AutoSize = true;
            this.lblKrajDatum.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblKrajDatum.Location = new System.Drawing.Point(184, 211);
            this.lblKrajDatum.Name = "lblKrajDatum";
            this.lblKrajDatum.Size = new System.Drawing.Size(88, 41);
            this.lblKrajDatum.TabIndex = 7;
            this.lblKrajDatum.Text = "Datum kraja:";
            this.lblKrajDatum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKrajVrijeme
            // 
            this.lblKrajVrijeme.AutoSize = true;
            this.lblKrajVrijeme.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblKrajVrijeme.Location = new System.Drawing.Point(178, 253);
            this.lblKrajVrijeme.Name = "lblKrajVrijeme";
            this.lblKrajVrijeme.Size = new System.Drawing.Size(94, 42);
            this.lblKrajVrijeme.TabIndex = 8;
            this.lblKrajVrijeme.Text = "Vrijeme kraja:";
            this.lblKrajVrijeme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblDodajZaduzenje
            // 
            this.tblDodajZaduzenje.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblDodajZaduzenje.ColumnCount = 2;
            this.tblDodajZaduzenje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDodajZaduzenje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDodajZaduzenje.Controls.Add(this.lblIme, 0, 0);
            this.tblDodajZaduzenje.Controls.Add(this.lblKrajVrijeme, 0, 6);
            this.tblDodajZaduzenje.Controls.Add(this.lblPrezime, 0, 1);
            this.tblDodajZaduzenje.Controls.Add(this.lblKrajDatum, 0, 5);
            this.tblDodajZaduzenje.Controls.Add(this.lblUloga, 0, 2);
            this.tblDodajZaduzenje.Controls.Add(this.lblPocVrijeme, 0, 4);
            this.tblDodajZaduzenje.Controls.Add(this.lblPocDatum, 0, 3);
            this.tblDodajZaduzenje.Controls.Add(this.txtIme, 1, 0);
            this.tblDodajZaduzenje.Controls.Add(this.txtPrezime, 1, 1);
            this.tblDodajZaduzenje.Controls.Add(this.pocDatum, 1, 3);
            this.tblDodajZaduzenje.Controls.Add(this.pocVrijeme, 1, 4);
            this.tblDodajZaduzenje.Controls.Add(this.krajDatum, 1, 5);
            this.tblDodajZaduzenje.Controls.Add(this.krajVrijeme, 1, 6);
            this.tblDodajZaduzenje.Controls.Add(this.txtUloga, 1, 2);
            this.tblDodajZaduzenje.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDodajZaduzenje.Location = new System.Drawing.Point(0, 0);
            this.tblDodajZaduzenje.Name = "tblDodajZaduzenje";
            this.tblDodajZaduzenje.RowCount = 7;
            this.tblDodajZaduzenje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblDodajZaduzenje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblDodajZaduzenje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblDodajZaduzenje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblDodajZaduzenje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblDodajZaduzenje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblDodajZaduzenje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblDodajZaduzenje.Size = new System.Drawing.Size(552, 296);
            this.tblDodajZaduzenje.TabIndex = 9;
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIme.Location = new System.Drawing.Point(279, 10);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(150, 22);
            this.txtIme.TabIndex = 9;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrezime.Location = new System.Drawing.Point(279, 52);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(150, 22);
            this.txtPrezime.TabIndex = 10;
            // 
            // pocDatum
            // 
            this.pocDatum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pocDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pocDatum.Location = new System.Drawing.Point(279, 136);
            this.pocDatum.Name = "pocDatum";
            this.pocDatum.Size = new System.Drawing.Size(150, 22);
            this.pocDatum.TabIndex = 17;
            this.pocDatum.Value = new System.DateTime(2019, 1, 30, 0, 0, 0, 0);
            // 
            // pocVrijeme
            // 
            this.pocVrijeme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pocVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pocVrijeme.Location = new System.Drawing.Point(279, 178);
            this.pocVrijeme.Name = "pocVrijeme";
            this.pocVrijeme.Size = new System.Drawing.Size(150, 22);
            this.pocVrijeme.TabIndex = 18;
            this.pocVrijeme.Value = new System.DateTime(2019, 1, 30, 18, 4, 25, 0);
            // 
            // krajDatum
            // 
            this.krajDatum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.krajDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.krajDatum.Location = new System.Drawing.Point(279, 220);
            this.krajDatum.Name = "krajDatum";
            this.krajDatum.Size = new System.Drawing.Size(150, 22);
            this.krajDatum.TabIndex = 19;
            this.krajDatum.Value = new System.DateTime(2019, 1, 30, 0, 0, 0, 0);
            // 
            // krajVrijeme
            // 
            this.krajVrijeme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.krajVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.krajVrijeme.Location = new System.Drawing.Point(279, 263);
            this.krajVrijeme.Name = "krajVrijeme";
            this.krajVrijeme.Size = new System.Drawing.Size(150, 22);
            this.krajVrijeme.TabIndex = 20;
            this.krajVrijeme.Value = new System.DateTime(2019, 1, 30, 18, 5, 0, 0);
            // 
            // txtUloga
            // 
            this.txtUloga.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUloga.Location = new System.Drawing.Point(279, 94);
            this.txtUloga.Name = "txtUloga";
            this.txtUloga.Size = new System.Drawing.Size(150, 22);
            this.txtUloga.TabIndex = 16;
            // 
            // DodajZaduzenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 338);
            this.Controls.Add(this.tblDodajZaduzenje);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DodajZaduzenje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj zaduženje";
            this.tblDodajZaduzenje.ResumeLayout(false);
            this.tblDodajZaduzenje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.Label lblPocDatum;
        private System.Windows.Forms.Label lblPocVrijeme;
        private System.Windows.Forms.Label lblKrajDatum;
        private System.Windows.Forms.Label lblKrajVrijeme;
        private System.Windows.Forms.TableLayoutPanel tblDodajZaduzenje;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.DateTimePicker pocDatum;
        private System.Windows.Forms.DateTimePicker pocVrijeme;
        private System.Windows.Forms.DateTimePicker krajDatum;
        private System.Windows.Forms.DateTimePicker krajVrijeme;
        private System.Windows.Forms.TextBox txtUloga;
    }
}