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
    public partial class GlavniIzbornik : Form
    {
        public GlavniIzbornik()
        {
            InitializeComponent();
        }

        public GlavniIzbornik(string welcomeMessage)
        {
            InitializeComponent();
            lblWelcome.Text = welcomeMessage;
        }

        private void pregledDvorana(object sender, EventArgs e)
        {

        }

        private void pregledFilmova(object sender, EventArgs e)
        {
            PregledFilmova filmovi = new PregledFilmova();
            this.Hide();
            filmovi.ShowDialog();
            this.Show();
        }

        private void pregledZaduzenja(object sender, EventArgs e)
        {
            PregledZaduzenja zaduzenja = new PregledZaduzenja();
            this.Hide();
            zaduzenja.ShowDialog();
            this.Show();
            
        }

        private void pregledTermina(object sender, MouseEventArgs e)
        {
            PregledTerminaFilmova termini = new PregledTerminaFilmova();
            this.Hide();
            termini.ShowDialog();
            this.Show();
        }
    }
}
