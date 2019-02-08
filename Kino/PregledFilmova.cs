using System;
using System.Windows.Forms;

namespace Kino
{
    public partial class PregledFilmova : Form
    {
        public PregledFilmova()
        {
            InitializeComponent();
        }

        private void PregledFilmova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kinoDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.kinoDataSet.Film);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // očisti selection od prije
            this.pregledFilmovi.ClearSelection();

            string text = txtSearch.Text;

            if (text.Length > 0)
            {
                bool searchFlag = false;

                this.pregledFilmovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
    }
}
