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
        public PregledDvorane()
        {
            InitializeComponent();
        }

        public PregledDvorane(int idTermina)
        {
            InitializeComponent();
            int brojDvorane = KinoDao.getBrojDvorane(idTermina);
            DataTable infoDvorane = KinoDao.getInfoDvorana(brojDvorane);
            int brojSjedala = 0;
            int brojRedova = 0;
            if(infoDvorane.Rows.Count == 1)
            {
                foreach(DataRow row in infoDvorane.Rows)
                {
                    lblDvorana.Text += " " + row["BROJ_DVORANE"].ToString();
                    lblTip.Text += " " + row["TIP_DVORANE"].ToString();
                    brojSjedala = Int32.Parse(row["BROJ_SJEDALA"].ToString());
                    brojRedova = Int32.Parse(row["BROJ_REDOVA"].ToString());
                }
            }
            DataTable kupljenaSjedala = KinoDao.getAllKupljenaSjedala(idTermina);

            ArrayList poljeBrojSjedala = new ArrayList(kupljenaSjedala.Rows.Count);
            ArrayList poljeBrojReda = new ArrayList(kupljenaSjedala.Rows.Count);
            ArrayList poljeBrojKarta = new ArrayList(kupljenaSjedala.Rows.Count);

            foreach(DataRow row in kupljenaSjedala.Rows)
            {
                poljeBrojSjedala.Add(Int32.Parse(row["BROJ_SJEDALA"].ToString()));
                poljeBrojReda.Add(Int32.Parse(row["RED_SJEDALA"].ToString()));
                poljeBrojKarta.Add(Int32.Parse(row["BROJ_KARTE"].ToString()));
            }

            if(kupljenaSjedala.Rows.Count > 0 && brojRedova > 0 && brojSjedala > 0)
            {
                int brojSjedalaURedu = brojSjedala / brojRedova;

                formatTable(brojSjedalaURedu, brojRedova);

                for (int i = 0; i < brojRedova; ++i)
                {
                    for(int j = 0; j < brojSjedalaURedu; ++j)
                    {
                        Label sjedalo = new Label();
                        sjedalo.Name = "lblSjedalo" + i + "" + j;
                        sjedalo.AutoSize = true;
                        sjedalo.Dock = DockStyle.Fill;

                        if (poljeBrojReda.IndexOf(i+1) >= 0 && poljeBrojSjedala.IndexOf(j+1) >= 0)
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

                       tableSjedala.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, tableSjedala.Width / brojSjedalaURedu));
                       tableSjedala.RowStyles.Add(new RowStyle(SizeType.Absolute, tableSjedala.Height / brojRedova));
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
            tableSjedala.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, tableSjedala.Width / brojSjedalaURedu));
            tableSjedala.RowStyles.Add(new RowStyle(SizeType.Absolute, tableSjedala.Height / brojRedova));
        }

        private void kupiKartu(object sender, EventArgs e)
        {

        }
    }
}
