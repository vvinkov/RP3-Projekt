using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class PregledDvorana : Form
    {
        private KinoDataSetTableAdapters.DvoranaTableAdapter dvorane;
        public PregledDvorana()
        {
            dvorane = new KinoDataSetTableAdapters.DvoranaTableAdapter();
            InitializeComponent();
            if (Kino.admin)
            {
                dodajMenuItem.Visible = true;
            }
            else
            {
                dodajMenuItem.Visible = false;
            }
        }

        private void PregledDvorana_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kinoDataSet.Dvorana' table. You can move, or remove it, as needed.
            DataTable table = KinoDao.getAllDvorane();
            if(table != null)
            {
                dataGridDvorane.DataSource = table.DefaultView;
                formatTable();
            }
            
        }

        private void formatTable()
        {
            dataGridDvorane.Columns[0].HeaderText = "Broj dvorane";
            dataGridDvorane.Columns[1].HeaderText = "Tip dvorane";
            dataGridDvorane.Columns[2].HeaderText = "Broj sjedala";
            dataGridDvorane.Columns[3].HeaderText = "Broj redova";
        }

        private void dodajDvoranu(object sender, EventArgs e)
        {
            DodajDvoranu novaDvorana = new DodajDvoranu();
            novaDvorana.ShowDialog();

            // refresh tablice
            dataGridDvorane.DataSource = null;
            dataGridDvorane.DataSource = KinoDao.getAllDvorane().DefaultView;
            formatTable();
        }
    }
}
