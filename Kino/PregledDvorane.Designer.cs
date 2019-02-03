namespace Kino
{
    partial class PregledDvorane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledDvorane));
            this.lblDvorana = new System.Windows.Forms.Label();
            this.btnKupi = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.tableSjedala = new System.Windows.Forms.TableLayoutPanel();
            this.panelPlatno = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblDvorana
            // 
            this.lblDvorana.AutoSize = true;
            this.lblDvorana.Location = new System.Drawing.Point(70, 9);
            this.lblDvorana.Name = "lblDvorana";
            this.lblDvorana.Size = new System.Drawing.Size(62, 17);
            this.lblDvorana.TabIndex = 0;
            this.lblDvorana.Text = "Dvorana";
            // 
            // btnKupi
            // 
            this.btnKupi.Location = new System.Drawing.Point(648, 413);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(140, 35);
            this.btnKupi.TabIndex = 2;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.kupiKartu);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(302, 9);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(32, 17);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "Tip:";
            // 
            // tableSjedala
            // 
            this.tableSjedala.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableSjedala.ColumnCount = 2;
            this.tableSjedala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSjedala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSjedala.Location = new System.Drawing.Point(0, 102);
            this.tableSjedala.Name = "tableSjedala";
            this.tableSjedala.RowCount = 2;
            this.tableSjedala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSjedala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSjedala.Size = new System.Drawing.Size(802, 298);
            this.tableSjedala.TabIndex = 4;
            // 
            // panelPlatno
            // 
            this.panelPlatno.BackColor = System.Drawing.Color.White;
            this.panelPlatno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPlatno.BackgroundImage")));
            this.panelPlatno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPlatno.Location = new System.Drawing.Point(0, 33);
            this.panelPlatno.Name = "panelPlatno";
            this.panelPlatno.Size = new System.Drawing.Size(802, 69);
            this.panelPlatno.TabIndex = 5;
            // 
            // PregledDvorane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.panelPlatno);
            this.Controls.Add(this.tableSjedala);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.lblDvorana);
            this.Name = "PregledDvorane";
            this.Text = "PregledDvorane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDvorana;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TableLayoutPanel tableSjedala;
        private System.Windows.Forms.Panel panelPlatno;
    }
}