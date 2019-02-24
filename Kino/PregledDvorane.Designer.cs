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
            this.lblDvorana.Location = new System.Drawing.Point(2, 0);
            this.lblDvorana.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDvorana.Name = "lblDvorana";
            this.lblDvorana.Size = new System.Drawing.Size(48, 13);
            this.lblDvorana.TabIndex = 0;
            this.lblDvorana.Text = "Dvorana";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(54, 0);
            this.lblTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(67, 13);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "Tip dvorane:";
            // 
            // tableSjedala
            // 
            this.tableSjedala.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableSjedala.ColumnCount = 1;
            this.tableSjedala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSjedala.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableSjedala.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableSjedala.Location = new System.Drawing.Point(0, 147);
            this.tableSjedala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableSjedala.Name = "tableSjedala";
            this.tableSjedala.RowCount = 1;
            this.tableSjedala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSjedala.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableSjedala.Size = new System.Drawing.Size(677, 285);
            this.tableSjedala.TabIndex = 4;
            // 
            // panelPlatno
            // 
            this.panelPlatno.BackColor = System.Drawing.Color.White;
            this.panelPlatno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPlatno.BackgroundImage")));
            this.panelPlatno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPlatno.Location = new System.Drawing.Point(2, 15);
            this.panelPlatno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPlatno.Name = "panelPlatno";
            this.panelPlatno.Size = new System.Drawing.Size(670, 96);
            this.panelPlatno.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblDvorana);
            this.flowLayoutPanel1.Controls.Add(this.lblTip);
            this.flowLayoutPanel1.Controls.Add(this.panelPlatno);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(677, 112);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // PregledDvorane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 432);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableSjedala);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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