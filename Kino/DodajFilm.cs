using System;
using System.Windows.Forms;

namespace Kino
{
    public partial class DodajFilm : Form
    {
        public DodajFilm()
        {
            InitializeComponent();
        }

        private void potvrdi(object sender, EventArgs e)
        {
            bool dateFlag = true;
            bool nazivFlag = true;
            bool existsFlag = false;

            if(txtNaziv.Text == null || txtNaziv.Text.Length == 0)
            {
                nazivFlag = false;
                MessageBox.Show("Morate unijeti naziv filma!");
            }
            if (KinoDao.checkIfFilmExists(txtNaziv.Text))
            {
                existsFlag = true;
                MessageBox.Show("Film već postoji u bazi!");
            }

            dateFlag = checkDates(datPocPrikaz.Value.Date, datZavrPrikaz.Value.Date);
            
            if(dateFlag && nazivFlag && !existsFlag)
            {
                int addedRows = KinoDao.dodajNoviFilm(txtNaziv.Text, datPocPrikaz.Value.Date, datZavrPrikaz.Value.Date, numTrajanje.Value);
                if(addedRows == 1)
                {
                    MessageBox.Show("Uspješno ste dodali film!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Film nije dodan!");
                }
            }
            
        }

        private void odustani(object sender, EventArgs e)
        {
            Close();
        }

        private bool checkDates(DateTime pocDatum, DateTime krajDatum)
        {
            // datum početka treba biti > od današnjeg datuma
            DateTime today = DateTime.Today;

            if (DateTime.Compare(pocDatum.Date, DateTime.Today) <= 0)
            {
                MessageBox.Show("Datum početka prikazivanja treba biti veći od današnjeg datuma!");
                return false;
            }
            // datum početka treba biti <= datuma kraja
            if (DateTime.Compare(pocDatum.Date, krajDatum.Date) > 0)
            {
                MessageBox.Show("Datum početka treba biti manji ili jednak od datuma kraja prikazivanja!");
                return false;
            }

            return true;
        }
    }
}
