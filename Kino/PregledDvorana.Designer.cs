namespace Kino
{
    partial class PregledDvorana
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
            this.components = new System.ComponentModel.Container();
            this.dataGridDvorane = new System.Windows.Forms.DataGridView();
            this.dvoranaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoDataSet = new KinoDataSet();
            this.dvoranaTableAdapter = new KinoDataSetTableAdapters.DvoranaTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDvorane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvoranaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridDvorane
            // 
            this.dataGridDvorane.AllowUserToAddRows = false;
            this.dataGridDvorane.AllowUserToDeleteRows = false;
            this.dataGridDvorane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDvorane.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridDvorane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDvorane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDvorane.Location = new System.Drawing.Point(0, 28);
            this.dataGridDvorane.Name = "dataGridDvorane";
            this.dataGridDvorane.ReadOnly = true;
            this.dataGridDvorane.RowTemplate.Height = 24;
            this.dataGridDvorane.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridDvorane.Size = new System.Drawing.Size(800, 422);
            this.dataGridDvorane.TabIndex = 0;
            // 
            // dvoranaBindingSource
            // 
            this.dvoranaBindingSource.DataMember = "Dvorana";
            this.dvoranaBindingSource.DataSource = this.kinoDataSet;
            // 
            // kinoDataSet
            // 
            this.kinoDataSet.DataSetName = "KinoDataSet";
            this.kinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dvoranaTableAdapter
            // 
            this.dvoranaTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajMenuItem
            // 
            this.dodajMenuItem.Name = "dodajMenuItem";
            this.dodajMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dodajMenuItem.Text = "Dodaj";
            this.dodajMenuItem.Click += new System.EventHandler(this.dodajDvoranu);
            // 
            // PregledDvorana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridDvorane);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PregledDvorana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dvorane";
            this.Load += new System.EventHandler(this.PregledDvorana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDvorane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvoranaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDvorane;
        private KinoDataSet kinoDataSet;
        private System.Windows.Forms.BindingSource dvoranaBindingSource;
        private KinoDataSetTableAdapters.DvoranaTableAdapter dvoranaTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajMenuItem;
    }
}