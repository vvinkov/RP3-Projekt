namespace Kino
{
    partial class KupiKartu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KupiKartu));
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.tableKarta = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdKarte = new System.Windows.Forms.Label();
            this.lblNazivFilma = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.lblBrojDvorane = new System.Windows.Forms.Label();
            this.lblBrojSjedala = new System.Windows.Forms.Label();
            this.lblBrojReda = new System.Windows.Forms.Label();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.tableKarta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(276, 403);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(108, 35);
            this.btnOdustani.TabIndex = 0;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.odustani);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(158, 403);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(112, 35);
            this.btnPotvrdi.TabIndex = 1;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.potvrdi);
            this.btnPotvrdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnPotvrdi_KeyPress);
            // 
            // tableKarta
            // 
            this.tableKarta.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableKarta.ColumnCount = 2;
            this.tableKarta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableKarta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableKarta.Controls.Add(this.lblIdKarte, 0, 0);
            this.tableKarta.Controls.Add(this.lblNazivFilma, 0, 1);
            this.tableKarta.Controls.Add(this.lblDatum, 0, 2);
            this.tableKarta.Controls.Add(this.lblVrijeme, 0, 3);
            this.tableKarta.Controls.Add(this.lblBrojDvorane, 0, 4);
            this.tableKarta.Controls.Add(this.lblBrojSjedala, 0, 6);
            this.tableKarta.Controls.Add(this.lblBrojReda, 0, 5);
            this.tableKarta.Controls.Add(this.lblTrajanje, 0, 7);
            this.tableKarta.Controls.Add(this.lblCijena, 0, 8);
            this.tableKarta.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableKarta.Location = new System.Drawing.Point(0, 0);
            this.tableKarta.Name = "tableKarta";
            this.tableKarta.RowCount = 9;
            this.tableKarta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableKarta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableKarta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableKarta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableKarta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableKarta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableKarta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableKarta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableKarta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableKarta.Size = new System.Drawing.Size(392, 393);
            this.tableKarta.TabIndex = 2;
            // 
            // lblIdKarte
            // 
            this.lblIdKarte.AutoSize = true;
            this.lblIdKarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIdKarte.Location = new System.Drawing.Point(4, 1);
            this.lblIdKarte.Name = "lblIdKarte";
            this.lblIdKarte.Size = new System.Drawing.Size(188, 42);
            this.lblIdKarte.TabIndex = 0;
            this.lblIdKarte.Text = "Id karte:";
            this.lblIdKarte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNazivFilma
            // 
            this.lblNazivFilma.AutoSize = true;
            this.lblNazivFilma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNazivFilma.Location = new System.Drawing.Point(4, 44);
            this.lblNazivFilma.Name = "lblNazivFilma";
            this.lblNazivFilma.Size = new System.Drawing.Size(188, 42);
            this.lblNazivFilma.TabIndex = 1;
            this.lblNazivFilma.Text = "Naziv filma:";
            this.lblNazivFilma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatum.Location = new System.Drawing.Point(4, 87);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(188, 42);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum:";
            this.lblDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVrijeme.Location = new System.Drawing.Point(4, 130);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(188, 42);
            this.lblVrijeme.TabIndex = 3;
            this.lblVrijeme.Text = "Vrijeme:";
            this.lblVrijeme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrojDvorane
            // 
            this.lblBrojDvorane.AutoSize = true;
            this.lblBrojDvorane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrojDvorane.Location = new System.Drawing.Point(4, 173);
            this.lblBrojDvorane.Name = "lblBrojDvorane";
            this.lblBrojDvorane.Size = new System.Drawing.Size(188, 42);
            this.lblBrojDvorane.TabIndex = 5;
            this.lblBrojDvorane.Text = "Broj dvorane:";
            this.lblBrojDvorane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrojSjedala
            // 
            this.lblBrojSjedala.AutoSize = true;
            this.lblBrojSjedala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrojSjedala.Location = new System.Drawing.Point(4, 259);
            this.lblBrojSjedala.Name = "lblBrojSjedala";
            this.lblBrojSjedala.Size = new System.Drawing.Size(188, 42);
            this.lblBrojSjedala.TabIndex = 6;
            this.lblBrojSjedala.Text = "Broj sjedala:";
            this.lblBrojSjedala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrojReda
            // 
            this.lblBrojReda.AutoSize = true;
            this.lblBrojReda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrojReda.Location = new System.Drawing.Point(4, 216);
            this.lblBrojReda.Name = "lblBrojReda";
            this.lblBrojReda.Size = new System.Drawing.Size(188, 42);
            this.lblBrojReda.TabIndex = 7;
            this.lblBrojReda.Text = "Broj reda:";
            this.lblBrojReda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrajanje.Location = new System.Drawing.Point(4, 302);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(188, 42);
            this.lblTrajanje.TabIndex = 8;
            this.lblTrajanje.Text = "Trajanje:";
            this.lblTrajanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCijena.Location = new System.Drawing.Point(4, 345);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(188, 47);
            this.lblCijena.TabIndex = 9;
            this.lblCijena.Text = "Cijena:";
            this.lblCijena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printPreview
            // 
            this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.Visible = false;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printPage);
            // 
            // KupiKartu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 445);
            this.Controls.Add(this.tableKarta);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnOdustani);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KupiKartu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kupnja karte";
            this.tableKarta.ResumeLayout(false);
            this.tableKarta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.TableLayoutPanel tableKarta;
        private System.Windows.Forms.Label lblIdKarte;
        private System.Windows.Forms.Label lblNazivFilma;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.Label lblBrojDvorane;
        private System.Windows.Forms.Label lblBrojSjedala;
        private System.Windows.Forms.Label lblBrojReda;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
        private System.Drawing.Printing.PrintDocument printDoc;
    }
}