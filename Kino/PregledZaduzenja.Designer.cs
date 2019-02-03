namespace Kino
{
    partial class PregledZaduzenja
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
            this.btnDodajZaduzenje = new System.Windows.Forms.Button();
            this.dataGridZaduzenja = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridZaduzenja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajZaduzenje
            // 
            this.btnDodajZaduzenje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajZaduzenje.Location = new System.Drawing.Point(755, 438);
            this.btnDodajZaduzenje.Name = "btnDodajZaduzenje";
            this.btnDodajZaduzenje.Size = new System.Drawing.Size(170, 30);
            this.btnDodajZaduzenje.TabIndex = 2;
            this.btnDodajZaduzenje.Text = "Dodaj novo zaduženje";
            this.btnDodajZaduzenje.UseVisualStyleBackColor = true;
            this.btnDodajZaduzenje.Click += new System.EventHandler(this.dodajZaduzenje);
            // 
            // dataGridZaduzenja
            // 
            this.dataGridZaduzenja.AllowUserToAddRows = false;
            this.dataGridZaduzenja.AllowUserToDeleteRows = false;
            this.dataGridZaduzenja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridZaduzenja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridZaduzenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridZaduzenja.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridZaduzenja.Location = new System.Drawing.Point(0, 0);
            this.dataGridZaduzenja.Name = "dataGridZaduzenja";
            this.dataGridZaduzenja.ReadOnly = true;
            this.dataGridZaduzenja.RowTemplate.Height = 24;
            this.dataGridZaduzenja.Size = new System.Drawing.Size(937, 429);
            this.dataGridZaduzenja.TabIndex = 3;
            // 
            // PregledZaduzenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 475);
            this.Controls.Add(this.dataGridZaduzenja);
            this.Controls.Add(this.btnDodajZaduzenje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PregledZaduzenja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled zaduženja";
            this.Load += new System.EventHandler(this.PregledZaduzenja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridZaduzenja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodajZaduzenje;
        private System.Windows.Forms.DataGridView dataGridZaduzenja;
    }
}