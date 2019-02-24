using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class KupiKartu : Form
    {
        private int idTermina;
        private string nazivFilma = "";
        private string datum = "";
        private string vrijeme = "";
        private string brojDvorane = "";
        private string cijena = "";
        private string trajanje = "";
        private int idFilma = -1;
        private int brojReda;
        private int brojSjedala;
        private int maxIdKarte;
        private Bitmap imageToPrint;

        public KupiKartu()
        {
            InitializeComponent();
        }

        public KupiKartu(int idTermina, string brojIRedSjedala)
        {
            InitializeComponent();
            getAllData(idTermina, brojIRedSjedala);
            drawLabels();
        }

        private void getAllData(int idTermina, string brojIRedSjedala)
        {
            this.idTermina = idTermina;
            int indeksTocke = brojIRedSjedala.IndexOf('.');
            brojReda = Int32.Parse(brojIRedSjedala.Substring(0, indeksTocke)) - 1;
            brojSjedala = Int32.Parse(brojIRedSjedala.Substring(indeksTocke + 1, brojIRedSjedala.Length - indeksTocke - 1)) - 1;
            maxIdKarte = KinoDao.getMaxIdKarte() + 1;

            DataTable infoTermin = KinoDao.getInfoTermin(idTermina);
            foreach (DataRow row in infoTermin.Rows)
            {
                idFilma = (int)row["ID_FILMA"];
                datum = ((DateTime)row["DATUM"]).Date.ToShortDateString();
                vrijeme = ((DateTime)row["VRIJEME"]).TimeOfDay.ToString();
                brojDvorane = row["BROJ_DVORANE"].ToString();
                cijena = row["CIJENA"].ToString();
            }

            DataTable infoFilm = KinoDao.getFilmById(idFilma);
            foreach (DataRow row in infoFilm.Rows)
            {
                nazivFilma = row["NAZIV_FILMA"].ToString();
                trajanje = row["TRAJANJE"].ToString();
            }
        }

        private void drawLabels()
        {
            tableKarta.Controls.Add(new Label
            {
                Text = maxIdKarte.ToString(),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter

            }, 1, 0);
            tableKarta.Controls.Add(new Label
            {
                Text = nazivFilma,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter

            }, 1, 1);
            tableKarta.Controls.Add(new Label
            {
                Text = datum,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter

            }, 1, 2);
            tableKarta.Controls.Add(new Label
            {
                Text = vrijeme,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter

            }, 1, 3);
            tableKarta.Controls.Add(new Label
            {
                Text = brojDvorane,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter

            }, 1, 4);
            tableKarta.Controls.Add(new Label
            {
                Text = (brojReda + 1) + "",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            }, 1, 5);
            tableKarta.Controls.Add(new Label
            {
                Text = (brojSjedala + 1) + "",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            }, 1, 6);
            tableKarta.Controls.Add(new Label
            {
                Text = trajanje + " minuta",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            }, 1, 7);
            tableKarta.Controls.Add(new Label
            {
                Text = cijena,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            }, 1, 8);
        }

        private void odustani(object sender, EventArgs e)
        {
            PregledDvorane.odustaniFlag = true;
            Close();
        }

        private void potvrdi(object sender, EventArgs e)
        {
            
            // dodaj u tablicu
            int rowsAdded = KinoDao.addNovuKartu(idTermina,
                                    Kino.idZaposlenika,
                                    brojSjedala,
                                    brojReda,
                                    maxIdKarte);

            if(rowsAdded != 1)
            {
                MessageBox.Show("Karta nije uspješno uvedena u bazu!");
            }
            else
            {
                //isprintaj
                printImage();
                PregledDvorane.odustaniFlag = false;
            }
            Close();
        }

        private void printImage()
        {
            imageToPrint = new Bitmap(tableKarta.Width, tableKarta.Height);
            tableKarta.DrawToBitmap(imageToPrint, new Rectangle(0, 0, tableKarta.Height, tableKarta.Height));
            printPreview.Document = printDoc;
            printPreview.ShowDialog();
        }

        private void btnPotvrdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Enter))
            {
                potvrdi(sender, e);
            }
        }

        private void printPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(imageToPrint, 0, 0);
        }
    }
}
