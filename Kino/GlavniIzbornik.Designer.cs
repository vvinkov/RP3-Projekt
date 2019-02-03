using System.Windows.Forms;

namespace Kino
{
    partial class GlavniIzbornik : Form
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.izbornik = new System.Windows.Forms.TableLayoutPanel();
            this.btnPregledDvorana = new System.Windows.Forms.Button();
            this.btnPregledZaduzenja = new System.Windows.Forms.Button();
            this.btnPregledFilmova = new System.Windows.Forms.Button();
            this.btnPregledTermina = new System.Windows.Forms.Button();
            this.izbornik.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.Control;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblWelcome.Location = new System.Drawing.Point(802, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 17);
            this.lblWelcome.TabIndex = 0;
            // 
            // izbornik
            // 
            this.izbornik.ColumnCount = 1;
            this.izbornik.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.izbornik.Controls.Add(this.btnPregledDvorana, 0, 0);
            this.izbornik.Controls.Add(this.btnPregledZaduzenja, 0, 3);
            this.izbornik.Controls.Add(this.btnPregledFilmova, 0, 2);
            this.izbornik.Controls.Add(this.btnPregledTermina, 0, 1);
            this.izbornik.Dock = System.Windows.Forms.DockStyle.Left;
            this.izbornik.Location = new System.Drawing.Point(0, 0);
            this.izbornik.Name = "izbornik";
            this.izbornik.RowCount = 4;
            this.izbornik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.izbornik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.izbornik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.izbornik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.izbornik.Size = new System.Drawing.Size(407, 443);
            this.izbornik.TabIndex = 1;
            // 
            // btnPregledDvorana
            // 
            this.btnPregledDvorana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPregledDvorana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledDvorana.Location = new System.Drawing.Point(3, 3);
            this.btnPregledDvorana.Name = "btnPregledDvorana";
            this.btnPregledDvorana.Size = new System.Drawing.Size(401, 104);
            this.btnPregledDvorana.TabIndex = 0;
            this.btnPregledDvorana.Text = "Pregled dvorana";
            this.btnPregledDvorana.UseVisualStyleBackColor = true;
            this.btnPregledDvorana.Click += new System.EventHandler(this.pregledDvorana);
            // 
            // btnPregledZaduzenja
            // 
            this.btnPregledZaduzenja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPregledZaduzenja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledZaduzenja.Location = new System.Drawing.Point(3, 333);
            this.btnPregledZaduzenja.Name = "btnPregledZaduzenja";
            this.btnPregledZaduzenja.Size = new System.Drawing.Size(401, 107);
            this.btnPregledZaduzenja.TabIndex = 2;
            this.btnPregledZaduzenja.Text = "Pregled zaduženja";
            this.btnPregledZaduzenja.UseVisualStyleBackColor = true;
            this.btnPregledZaduzenja.Click += new System.EventHandler(this.pregledZaduzenja);
            // 
            // btnPregledFilmova
            // 
            this.btnPregledFilmova.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPregledFilmova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledFilmova.Location = new System.Drawing.Point(3, 223);
            this.btnPregledFilmova.Name = "btnPregledFilmova";
            this.btnPregledFilmova.Size = new System.Drawing.Size(401, 104);
            this.btnPregledFilmova.TabIndex = 1;
            this.btnPregledFilmova.Text = "Pregled filmova";
            this.btnPregledFilmova.UseVisualStyleBackColor = true;
            this.btnPregledFilmova.Click += new System.EventHandler(this.pregledFilmova);
            // 
            // btnPregledTermina
            // 
            this.btnPregledTermina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPregledTermina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledTermina.Location = new System.Drawing.Point(3, 113);
            this.btnPregledTermina.Name = "btnPregledTermina";
            this.btnPregledTermina.Size = new System.Drawing.Size(401, 104);
            this.btnPregledTermina.TabIndex = 3;
            this.btnPregledTermina.Text = "Pregled termina filmova";
            this.btnPregledTermina.UseVisualStyleBackColor = true;
            this.btnPregledTermina.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pregledTermina);
            // 
            // GlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 443);
            this.Controls.Add(this.izbornik);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GlavniIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni izbornik";
            this.izbornik.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private TableLayoutPanel izbornik;
        private Button btnPregledDvorana;
        private Button btnPregledFilmova;
        private Button btnPregledZaduzenja;
        private Button btnPregledTermina;
    }
}