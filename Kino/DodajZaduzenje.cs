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
    public partial class DodajZaduzenje : Form
    {
        public DodajZaduzenje()
        {
            InitializeComponent();
        }

        private void dodajZaduzenje_DB(object sender, EventArgs e)
        {
            int idZaposlenika = checkIfPersonExists(txtIme.Text, txtPrezime.Text);
            if(txtUloga.Text.Length <= 0)
            {
                MessageBox.Show("Uloga ne smije biti prazna!");
            }
            else if (idZaposlenika > 0 &&
                checkDates(pocDatum.Value, pocVrijeme.Value, krajDatum.Value, krajVrijeme.Value))
            {
                // dodaj zaduženje u bazu
                // osvježi formu?
                int result = KinoDao.addNovoZaduzenje(idZaposlenika,
                                                     txtUloga.Text,
                                                     pocDatum.Value.Date,
                                                     pocVrijeme.Value.TimeOfDay,
                                                     krajDatum.Value.Date,
                                                     krajVrijeme.Value.TimeOfDay);

                // poruka o uspješnom dodavanju
                if(result != 1)
                    MessageBox.Show("Zaduženje nije uspješno dodano!");
                else
                    MessageBox.Show("Zaduženje uspješno dodano!");

                this.Close();
            }

        }

        private void odustani(object sender, EventArgs e)
        {
            this.Close();
        }

        private int checkIfPersonExists(string ime, string prezime)
        {
            int idZaposlenika = KinoDao.checkIfNameOfZaposlenikExists(ime, prezime);
            if(idZaposlenika > 0)
            {
                return idZaposlenika;
            }
            else
            {
                MessageBox.Show("Zaposlenik ne postoji!");
                return -1;
            }
        }

        private bool checkDates(DateTime pocDatum, DateTime pocVrijeme, DateTime krajDatum, DateTime krajVrijeme)
        {
            // datum početka treba biti > od današnjeg datuma
            DateTime today = DateTime.Today;

            if (DateTime.Compare(pocDatum.Date, DateTime.Today) <= 0)
            {
                MessageBox.Show("Datum početka zaduženja treba biti veći od današnjeg datuma!");
                return false;
            }
            // datum početka treba biti <= datuma kraja
            if(DateTime.Compare(pocDatum.Date, krajDatum.Date) > 0)
            {
                MessageBox.Show("Datum početka treba biti manji ili jednak od datuma kraja zaduženja!");
                return false;
            }
            // ako je isti datum, onda vrijeme pocetka treba biti < od kraja vremena
            else if(DateTime.Compare(pocDatum.Date, krajDatum.Date) == 0 &&
                    pocVrijeme.TimeOfDay >= krajVrijeme.TimeOfDay)
            {
                MessageBox.Show("Vrijeme početka treba biti manje od kraja vremena zaduženja!");
                return false;
            }

            return true;
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
