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
    public partial class DodajTerminFilma : Form
    {
        public DodajTerminFilma()
        {
            InitializeComponent();
        }

        private void ucitajFilmovePoslijeDatuma(DateTime datum)
        {
            DataTable filmovi = KinoDao.getAktualniFilmovi(datum);
            comboBox1.DataSource = filmovi.DefaultView;
            comboBox1.DisplayMember = "NAZIV_FILMA";
            comboBox1.ValueMember = "ID_FILMA";
            comboBox1.BindingContext = this.BindingContext;
        }

        private void DodajTerminFilma_Load(object sender, EventArgs e)
        {
            ucitajFilmovePoslijeDatuma(dateTimePicker1.Value);

            DataTable dvorane = KinoDao.getAllDvorane();
            comboBox2.DataSource = dvorane.DefaultView;
            comboBox2.DisplayMember = "BROJ_DVORANE";
            comboBox2.ValueMember = "BROJ_DVORANE";
            comboBox2.BindingContext = this.BindingContext;

            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ucitajFilmovePoslijeDatuma(dateTimePicker1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Niti jedan film se ne prikazuje na odabrani datum!", "Greška!");
            }
            else if (KinoDao.addTerminFilma(Int32.Parse(comboBox1.SelectedValue.ToString()), 
                                            Int32.Parse(comboBox2.SelectedValue.ToString()), 
                                            dateTimePicker1.Value, 
                                            dateTimePicker2.Value.TimeOfDay, 
                                            Int32.Parse(numericUpDown1.Value.ToString())
                                            ) > 0)
            {
                MessageBox.Show("Novi termin spremljen.", "Obavijest");
                Close();
            }
            else
                MessageBox.Show("Novi termin nije spremljen.", "Obavijest");
        }
    }
}
