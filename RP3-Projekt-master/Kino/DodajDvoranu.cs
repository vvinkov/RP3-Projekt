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
    public partial class DodajDvoranu : Form
    {
        public DodajDvoranu()
        {
            InitializeComponent();
        }

        private void odustani(object sender, EventArgs e)
        {
            Close();
        }

        private void potvrdi(object sender, EventArgs e)
        {
            if(txtTipDvorane.Text != null && txtTipDvorane.Text.Length > 0)
            {
                int addedRows = KinoDao.addNovaDvorana(txtTipDvorane.Text, numBrojSjedala.Value, numBrojRedova.Value);
                if(addedRows != 1)
                {
                    MessageBox.Show("Dvorana nije dodana!");
                }
                else
                {
                    MessageBox.Show("Dvorana je dodana!");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Morate unijeti tip dvorane!");
            }
        }
    }
}
