using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefKlassesRecapWindowsFormsApp1708
{
    public partial class Oef4 : Form
    {
        public Oef4()
        {
            InitializeComponent();
        }

       

        private void lbHoeveelWater_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDownLengte_ValueChanged(object sender, EventArgs e)
        {
            int Lengte = Convert.ToInt32(Math.Round(numericUpDownLengte.Value, 0));
            decimal hoeveelheid = numericUpDownLengte.Value * numericUpDownBreedte.Value * numericUpDownDiepte.Value;
            lbHoeveelWater.Text = hoeveelheid.ToString();
        }

        private void numericUpDownBreedte_ValueChanged(object sender, EventArgs e)
        {
            int Breedte = Convert.ToInt32(Math.Round(numericUpDownBreedte.Value, 0));
            decimal hoeveelheid = numericUpDownLengte.Value * numericUpDownBreedte.Value * numericUpDownDiepte.Value;
            lbHoeveelWater.Text = hoeveelheid.ToString();
        }

        private void numericUpDownDiepte_ValueChanged(object sender, EventArgs e)
        {
            int Diepte = Convert.ToInt32(Math.Round(numericUpDownDiepte.Value, 0));
            decimal hoeveelheid = numericUpDownLengte.Value * numericUpDownBreedte.Value * numericUpDownDiepte.Value;
            lbHoeveelWater.Text = hoeveelheid.ToString();
        }
    }
}
