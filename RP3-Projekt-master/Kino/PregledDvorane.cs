using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kino
{
    public partial class PregledDvorane : Form
    {
        int idTermina;
        internal static bool odustaniFlag = true;
        int brojDvorane = -1;
        DataTable infoDvorane = null;
        DataTable kupljenaSjedala = null;
        HashSet<Tuple<int, int>> koordinateSjedala = new HashSet<Tuple<int, int>>();
        int brojRedova;
        int brojSjedala;

        public PregledDvorane()
        {
            InitializeComponent();
        }

        public PregledDvorane(int idTermina)
        {
            InitializeComponent();

            this.idTermina = idTermina;
            lblDvorana.Text = "";
            lblTip.Text = "";
            loadAndDraw();
        }

        private void loadAndDraw()
        {
            if(brojDvorane == -1)
            {
                brojDvorane = KinoDao.getBrojDvorane(idTermina);
            }

            if(infoDvorane == null)
            {
                infoDvorane = KinoDao.getInfoDvorana(brojDvorane);
                
                if (infoDvorane.Rows.Count == 1)
                {
                    foreach (DataRow row in infoDvorane.Rows)
                    {
                        if(lblDvorana.Text == null || lblDvorana.Text.Length == 0)
                            lblDvorana.Text += "Dvorana: " + row["BROJ_DVORANE"].ToString();
                        if (lblTip.Text == null || lblTip.Text.Length == 0)
                            lblTip.Text += "Tip: " + row["TIP_DVORANE"].ToString();

                        brojSjedala = Int32.Parse(row["BROJ_SJEDALA"].ToString());
                        brojRedova = Int32.Parse(row["BROJ_REDOVA"].ToString());
                    }
                }
            }

            if(kupljenaSjedala == null)
            {
                kupljenaSjedala = KinoDao.getAllKupljenaSjedala(idTermina);

                koordinateSjedala = new HashSet<Tuple<int, int>>();
                ArrayList poljeBrojKarta = new ArrayList(kupljenaSjedala.Rows.Count);

                foreach (DataRow row in kupljenaSjedala.Rows)
                {
                    koordinateSjedala.Add(new Tuple<int, int>(Int32.Parse(row["RED_SJEDALA"].ToString()),
                                                              Int32.Parse(row["BROJ_SJEDALA"].ToString())));
                    poljeBrojKarta.Add(Int32.Parse(row["BROJ_KARTE"].ToString()));
                }
            }

            if (kupljenaSjedala.Rows.Count > 0 && brojRedova > 0 && brojSjedala > 0)
            {
                int brojSjedalaURedu = brojSjedala / brojRedova;

                formatTable(brojSjedalaURedu, brojRedova);
                tableSjedala.SuspendLayout();
                // nacrtaj labele za broj i red sjedala
                for(int i = 0; i < brojSjedalaURedu + 1; ++i)
                {
                    Label sjedalo = new Label();
                    sjedalo.Name = "" + 0 + "." + i;
                    sjedalo.AutoSize = true;
                    sjedalo.Dock = DockStyle.Fill;

                    if (i == 0)
                        sjedalo.Text = "";
                    else
                        sjedalo.Text = "" + i;
                    tableSjedala.Controls.Add(sjedalo);

                }

                for (int i = 1; i < brojRedova + 1; ++i)
                {
                    for (int j = 0; j < brojSjedalaURedu + 1; ++j)
                    {
                        
                        Label sjedalo = new Label();
                        sjedalo.Name = "" + i + "." + j;
                        sjedalo.AutoSize = true;
                        sjedalo.Dock = DockStyle.Fill;

                        if(j == 0)
                        {
                            char c = 'A';
                            int k = (int)c;
                            --k;
                            sjedalo.Text = "" + ((char)(i + k));
                        }
                        else
                        {
                            if (koordinateSjedala.Contains(new Tuple<int, int>(i, j)))
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
                        }
                        tableSjedala.Controls.Add(sjedalo);
                    }
                }
                tableSjedala.ResumeLayout();
            }
        }

        private void formatTable(int brojSjedalaURedu, int brojRedova)
        {
            tableSjedala.ColumnStyles.Clear();
            tableSjedala.RowStyles.Clear();
            tableSjedala.ColumnCount = brojSjedalaURedu + 1;
            tableSjedala.RowCount = brojRedova + 1;

            for(int i = 0; i < brojSjedalaURedu + 1; ++i)
                tableSjedala.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / (brojSjedalaURedu + 1)));
            for(int i = 0; i < brojRedova + 1; ++i)
                tableSjedala.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / (brojRedova + 1)));
        }

        private void kupiKartu(object sender, MouseEventArgs e)
        {
            Label lblKlik = (Label)sender;
            KupiKartu karta = new KupiKartu(idTermina, lblKlik.Name); 
            Hide();
            karta.ShowDialog();
            // neki refresh
            if (!odustaniFlag)
            {
                tableSjedala = new TableLayoutPanel();
                kupljenaSjedala = null;
                loadAndDraw();
                odustaniFlag = true;
                Refresh();
            }

            Show();
        }
    }
}
