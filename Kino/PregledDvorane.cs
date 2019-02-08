using System;
using System.Collections;
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
    public partial class PregledDvorane : Form
    {
        int idTermina;
        internal static bool odustaniFlag = true;

        public PregledDvorane()
        {
            InitializeComponent();
        }

        public PregledDvorane(int idTermina)
        {
            InitializeComponent();

            this.idTermina = idTermina;
            loadAndDraw();
        }

        private void loadAndDraw()
        {
            int brojDvorane = KinoDao.getBrojDvorane(idTermina);
            DataTable infoDvorane = KinoDao.getInfoDvorana(brojDvorane);
            int brojSjedala = 0;
            int brojRedova = 0;
            if (infoDvorane.Rows.Count == 1)
            {
                foreach (DataRow row in infoDvorane.Rows)
                {
                    lblDvorana.Text += " " + row["BROJ_DVORANE"].ToString();
                    lblTip.Text += " " + row["TIP_DVORANE"].ToString();
                    brojSjedala = Int32.Parse(row["BROJ_SJEDALA"].ToString());
                    brojRedova = Int32.Parse(row["BROJ_REDOVA"].ToString());
                }
            }
            DataTable kupljenaSjedala = KinoDao.getAllKupljenaSjedala(idTermina);

            HashSet<Tuple<int, int>> koordinateSjedala = new HashSet<Tuple<int, int>>();
            ArrayList poljeBrojKarta = new ArrayList(kupljenaSjedala.Rows.Count);

            foreach (DataRow row in kupljenaSjedala.Rows)
            {
                koordinateSjedala.Add(new Tuple<int, int>(Int32.Parse(row["RED_SJEDALA"].ToString()),
                                                          Int32.Parse(row["BROJ_SJEDALA"].ToString())));
                poljeBrojKarta.Add(Int32.Parse(row["BROJ_KARTE"].ToString()));
            }

            if (kupljenaSjedala.Rows.Count > 0 && brojRedova > 0 && brojSjedala > 0)
            {
                int brojSjedalaURedu = brojSjedala / brojRedova;
                tableSjedala.Width = (brojSjedalaURedu + 1) * 30;
                tableSjedala.Height = (brojRedova + 1) * 30;

                formatTable(brojSjedalaURedu, brojRedova);

                for (int i = 0; i < brojRedova; ++i)
                {
                    for (int j = 0; j < brojSjedalaURedu; ++j)
                    {
                        Label sjedalo = new Label();
                        sjedalo.Name = "" + i + "." + j;
                        sjedalo.AutoSize = true;
                        sjedalo.Dock = DockStyle.Fill;

                        if (koordinateSjedala.Contains(new Tuple<int, int>(i+1, j+1)))
                        {
                            sjedalo.BackColor = Color.Red;
                            sjedalo.ForeColor = Color.Red;
                        }
                        else
                        {
                            sjedalo.BackColor = Color.Yellow;
                            sjedalo.ForeColor = Color.Yellow;
                            // ako nije kupljeno dodaj event za double click
                            sjedalo.MouseDoubleClick += new MouseEventHandler(kupiKartu);
                        }

                        tableSjedala.Controls.Add(sjedalo);
                    }
                }
            }
        }

        private void formatTable(int brojSjedalaURedu, int brojRedova)
        {
            tableSjedala.ColumnStyles.Clear();
            tableSjedala.RowStyles.Clear();
            tableSjedala.ColumnCount = brojSjedalaURedu;
            tableSjedala.RowCount = brojRedova;
            for(int i = 0; i < brojSjedalaURedu; ++i)
                tableSjedala.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30));
            for(int i = 0; i < brojRedova; ++i)
                tableSjedala.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
        }

        private void kupiKartu(object sender, MouseEventArgs e)
        {
            Label lblKlik = (Label)sender;
            KupiKartu karta = new KupiKartu(idTermina, lblKlik.Name); 
            this.Hide();
            karta.ShowDialog();
            // neki refresh
            if (!odustaniFlag)
            {
                loadAndDraw();
                odustaniFlag = true;
            }
            
            this.Show();
        }
    }
}
