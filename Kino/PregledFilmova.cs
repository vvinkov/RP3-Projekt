using System;
using System.Windows.Forms;

namespace Kino
{
    public partial class PregledFilmova : Form
    {
        public PregledFilmova()
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

        private void PregledFilmova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kinoDataSet.Film' table. You can move, or remove it, as needed.
            // filmTableAdapter.Fill(kinoDataSet.Film);
            // filmTableAdapter.ClearBeforeFill = true;

            pregledFilmovi.DataSource = KinoDao.getAllFilmovi();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // očisti selection od prije
            pregledFilmovi.ClearSelection();

            string text = txtSearch.Text;

            if (text.Length > 0)
            {
                bool searchFlag = false;

                pregledFilmovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in pregledFilmovi.Rows)
                    {
                        if (row.Cells[1].Value.ToString().StartsWith(text))
                        {
                            row.Selected = true;
                            searchFlag = true;
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
                            } catch(Exception exc)
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

                if(!searchFlag)
                    MessageBox.Show("Nema rezultata pretraživanja!");
            }
        }

        private void dodajNoviFilm(object sender, EventArgs e)
        {
            DodajFilm noviFilm = new DodajFilm();
            noviFilm.ShowDialog();
            pregledFilmovi.DataSource = KinoDao.getAllFilmovi();
            pregledFilmovi.Update();
            pregledFilmovi.Refresh();
        }
    }
}
