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
            this.lblTip = new System.Windows.Forms.Label();
            this.tableSjedala = new System.Windows.Forms.TableLayoutPanel();
            this.panelPlatno = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDvorana
            // 
            this.lblDvorana.AutoSize = true;
            this.lblDvorana.Location = new System.Drawing.Point(3, 0);
            this.lblDvorana.Name = "lblDvorana";
            this.lblDvorana.Size = new System.Drawing.Size(62, 17);
            this.lblDvorana.TabIndex = 0;
            this.lblDvorana.Text = "Dvorana";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(71, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(88, 17);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "Tip dvorane:";
            // 
            // tableSjedala
            // 
            this.tableSjedala.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableSjedala.ColumnCount = 2;
            this.tableSjedala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSjedala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSjedala.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableSjedala.Location = new System.Drawing.Point(0, 144);
            this.tableSjedala.Name = "tableSjedala";
            this.tableSjedala.RowCount = 2;
            this.tableSjedala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSjedala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSjedala.Size = new System.Drawing.Size(897, 388);
            this.tableSjedala.TabIndex = 4;
            // 
            // panelPlatno
            // 
            this.panelPlatno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPlatno.BackColor = System.Drawing.Color.White;
            this.panelPlatno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPlatno.BackgroundImage")));
            this.panelPlatno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPlatno.Location = new System.Drawing.Point(3, 20);
            this.panelPlatno.Name = "panelPlatno";
            this.panelPlatno.Size = new System.Drawing.Size(894, 118);
            this.panelPlatno.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblDvorana);
            this.flowLayoutPanel1.Controls.Add(this.lblTip);
            this.flowLayoutPanel1.Controls.Add(this.panelPlatno);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(897, 138);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // PregledDvorane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 532);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableSjedala);
            this.Name = "PregledDvorane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Pregled dvorane";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDvorana;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TableLayoutPanel tableSjedala;
        private System.Windows.Forms.Panel panelPlatno;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}