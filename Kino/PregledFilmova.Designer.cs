namespace Kino
{
    partial class PregledFilmova
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
            this.pregledFilmovi = new System.Windows.Forms.DataGridView();
            this.iDFILMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZIVFILMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATPOCPRIKAZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATZAVRPRIKAZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAJANJEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoDataSet = new KinoDataSet();
            this.filmTableAdapter = new KinoDataSetTableAdapters.FilmTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pregledFilmovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pregledFilmovi
            // 
            this.pregledFilmovi.AllowUserToAddRows = false;
            this.pregledFilmovi.AllowUserToDeleteRows = false;
            this.pregledFilmovi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pregledFilmovi.AutoGenerateColumns = false;
            this.pregledFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pregledFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledFilmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFILMADataGridViewTextBoxColumn,
            this.nAZIVFILMADataGridViewTextBoxColumn,
            this.dATPOCPRIKAZDataGridViewTextBoxColumn,
            this.dATZAVRPRIKAZDataGridViewTextBoxColumn,
            this.tRAJANJEDataGridViewTextBoxColumn});
            this.pregledFilmovi.DataSource = this.filmBindingSource;
            this.pregledFilmovi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.pregledFilmovi.Location = new System.Drawing.Point(1, 50);
            this.pregledFilmovi.Name = "pregledFilmovi";
            this.pregledFilmovi.RowTemplate.Height = 24;
            this.pregledFilmovi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pregledFilmovi.Size = new System.Drawing.Size(597, 434);
            this.pregledFilmovi.TabIndex = 1;
            // 
            // iDFILMADataGridViewTextBoxColumn
            // 
            this.iDFILMADataGridViewTextBoxColumn.DataPropertyName = "ID_FILMA";
            this.iDFILMADataGridViewTextBoxColumn.HeaderText = "ID_FILMA";
            this.iDFILMADataGridViewTextBoxColumn.Name = "iDFILMADataGridViewTextBoxColumn";
            this.iDFILMADataGridViewTextBoxColumn.Visible = false;
            // 
            // nAZIVFILMADataGridViewTextBoxColumn
            // 
            this.nAZIVFILMADataGridViewTextBoxColumn.DataPropertyName = "NAZIV_FILMA";
            this.nAZIVFILMADataGridViewTextBoxColumn.HeaderText = "Naziv filma";
            this.nAZIVFILMADataGridViewTextBoxColumn.Name = "nAZIVFILMADataGridViewTextBoxColumn";
            // 
            // dATPOCPRIKAZDataGridViewTextBoxColumn
            // 
            this.dATPOCPRIKAZDataGridViewTextBoxColumn.DataPropertyName = "DAT_POC_PRIKAZ";
            this.dATPOCPRIKAZDataGridViewTextBoxColumn.HeaderText = "Datum početka prikazivanja";
            this.dATPOCPRIKAZDataGridViewTextBoxColumn.Name = "dATPOCPRIKAZDataGridViewTextBoxColumn";
            // 
            // dATZAVRPRIKAZDataGridViewTextBoxColumn
            // 
            this.dATZAVRPRIKAZDataGridViewTextBoxColumn.DataPropertyName = "DAT_ZAVR_PRIKAZ";
            this.dATZAVRPRIKAZDataGridViewTextBoxColumn.HeaderText = "Datum kraja prikazivanja";
            this.dATZAVRPRIKAZDataGridViewTextBoxColumn.Name = "dATZAVRPRIKAZDataGridViewTextBoxColumn";
            // 
            // tRAJANJEDataGridViewTextBoxColumn
            // 
            this.tRAJANJEDataGridViewTextBoxColumn.DataPropertyName = "TRAJANJE";
            this.tRAJANJEDataGridViewTextBoxColumn.HeaderText = "Trajanja (u minutama)";
            this.tRAJANJEDataGridViewTextBoxColumn.Name = "tRAJANJEDataGridViewTextBoxColumn";
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.kinoDataSet;
            // 
            // kinoDataSet
            // 
            this.kinoDataSet.DataSetName = "KinoDataSet";
            this.kinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(312, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(330, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Traži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // PregledFilmova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 449);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pregledFilmovi);
            this.Name = "PregledFilmova";
            this.Text = "Pregled filmova";
            this.Load += new System.EventHandler(this.PregledFilmova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pregledFilmovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pregledFilmovi;
        private KinoDataSet kinoDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private KinoDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFILMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZIVFILMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATPOCPRIKAZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATZAVRPRIKAZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAJANJEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}