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
    public partial class PregledTerminaFilmova : Form
    {
        public PregledTerminaFilmova()
        {
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

        // mozda se ovaj search stavi u neku Utility klasu ovdje  cijepam atome
        private void search(object sender, EventArgs e)
        {
            dataGridTermini.ClearSelection();

            string text = txtSearch.Text;

            if (text.Length > 0)
            {
                bool searchFlag = false;
                
                dataGridTermini.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in dataGridTermini.Rows)
                    {
                        if (row.Cells[1].Value.ToString().StartsWith(text))
                        {
                            row.Selected = true;
                            searchFlag = true;
                            // break;
                        }
                        else
                        {
                            try
                            {
                                DateTime datum = DateTime.Parse(text);

                                if (((DateTime)row.Cells[2].Value).Day.Equals(datum.Day))
                                {
                                    row.Selected = true;
                                    searchFlag = true;
                                    // break;
                                }
                                else if (((DateTime)row.Cells[3].Value).Day.Equals(datum.Day))
                                {
                                    row.Selected = true;
                                    searchFlag = true;
                                    // break;
                                }
                            }
                            catch (Exception exc)
                            {
                                System.Console.Out.WriteLine(exc.ToString());
                            }
                        }

                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

                if (!searchFlag)
                    MessageBox.Show("Nema rezultata pretraživanja!");
            }
        }

        private void PregledTerminaFilmova_Load(object sender, EventArgs e)
        {
            DataTable table = KinoDao.getAllTermini();
            dataGridTermini.DataSource = table.DefaultView;
            formatTable();
        }

        private void formatTable()
        {
            if(dataGridTermini.Columns.Count > 0)
            {
                dataGridTermini.Columns[0].Visible = false; // tu je id_termina
                dataGridTermini.Columns[1].HeaderText = "Naziv filma";
                dataGridTermini.Columns[2].HeaderText = "Datum";
                dataGridTermini.Columns[3].HeaderText = "Vrijeme";
                dataGridTermini.Columns[3].DefaultCellStyle.Format = "HH:mm";
                dataGridTermini.Columns[4].HeaderText = "Broj dvorane";
                dataGridTermini.Columns[5].HeaderText = "Cijena";
                dataGridTermini.Columns[6].HeaderText = "Trajanje";

                dataGridTermini.ReadOnly = true;
                dataGridTermini.MouseDoubleClick += new MouseEventHandler(prikaziDvoranu);
            }
            
        }

        private void prikaziDvoranu(object sender, EventArgs e)
        {
            var selectedRows = dataGridTermini.SelectedRows;
            if(selectedRows.Count == 1)
            {
                foreach(DataGridViewRow row in selectedRows)
                {
                    do
                    {
                        PregledDvorane dvorana = new PregledDvorane((int) row.Cells[0].Value);
                        Hide();
                        dvorana.ShowDialog();
                    }
                    while (PregledDvorane.odustaniFlag == false);
                    Show();
                }
               
            }
        }

        private void dodajTerminFilma(object sender, EventArgs e)
        {
            DodajTerminFilma noviTermin = new DodajTerminFilma();
            noviTermin.ShowDialog();
            dataGridTermini.DataSource = KinoDao.getAllTermini().DefaultView;
            formatTable();
        }
    }
}
