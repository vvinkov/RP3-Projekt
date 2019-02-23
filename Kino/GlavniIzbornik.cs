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
            PregledDvorana sveDvorane = new PregledDvorana();
            Hide();
            sveDvorane.ShowDialog();
            Show();
        }

        private void pregledFilmova(object sender, EventArgs e)
        {
            PregledFilmova filmovi = new PregledFilmova();
            Hide();
            filmovi.ShowDialog();
            Show();
        }

        private void pregledZaduzenja(object sender, EventArgs e)
        {
            PregledZaduzenja zaduzenja = new PregledZaduzenja();
            Hide();
            zaduzenja.ShowDialog();
            Show();
            
        }

        private void pregledTermina(object sender, MouseEventArgs e)
        {
            PregledTerminaFilmova termini = new PregledTerminaFilmova();
            Hide();
            termini.ShowDialog();
            Show();
        }
    }
}
