using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class Kino : Form
    {

        internal static int idZaposlenika;
        KinoDao DB;

        public Kino(string PathToDB)
        {
            DB = new KinoDao(PathToDB);
            InitializeComponent();
        }

        private void prijava(object sender, EventArgs e)
        {
            // provjeri ima li u bazi ime tog zaposlenika
            // ako ima otvori formu GlavniIzbornik
            // ako nema prikazi odgovarajucu poruku
            idZaposlenika = KinoDao.checkIfZaposlenikExists(txtUsername.Text);
            if (idZaposlenika > 0)
            {
                GlavniIzbornik glavniIzbornik = new GlavniIzbornik("Dobrodošli " + txtUsername.Text + "!");
                this.Hide();
                glavniIzbornik.ShowDialog();
                this.Close();
            }
            else
            {
                // pokazi neki dialog prozor
                MessageBox.Show("Ime ne postoji u bazi!");
            }
        }
    }
}
