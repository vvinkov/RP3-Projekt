using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kino
{
    public partial class PregledZaduzenja : Form
    {
        public PregledZaduzenja()
        {
            InitializeComponent();
        }

        private void PregledZaduzenja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kinoDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            // this.zaposlenikTableAdapter.Fill(this.kinoDataSet.Zaposlenik);
            // TODO: This line of code loads data into the 'kinoDataSet.Smjena' table. You can move, or remove it, as needed.
            // this.smjenaTableAdapter.Fill(this.kinoDataSet.Smjena);
            DataTable table = KinoDao.getAllZaduzenja();
            dataGridZaduzenja.DataSource = table.DefaultView;
            formatTable();
        }

        private void formatTable()
        {
            dataGridZaduzenja.Columns[0].HeaderText = "Ime";
            dataGridZaduzenja.Columns[1].HeaderText = "Prezime";
            dataGridZaduzenja.Columns[2].HeaderText = "Datum početka";
            dataGridZaduzenja.Columns[3].HeaderText = "Vrijeme početka";
            dataGridZaduzenja.Columns[3].DefaultCellStyle.Format = "HH:mm";
            dataGridZaduzenja.Columns[4].HeaderText = "Datum kraja";
            dataGridZaduzenja.Columns[5].HeaderText = "Vrijeme kraja";
            dataGridZaduzenja.Columns[5].DefaultCellStyle.Format = "HH:mm";
            dataGridZaduzenja.Columns[6].HeaderText = "Zaduženje";
        }

        private void dodajZaduzenje(object sender, EventArgs e)
        {
            DodajZaduzenje dodaj = new DodajZaduzenje();
            this.Hide();
            dodaj.ShowDialog();
            this.Close();
        }
    }
}
