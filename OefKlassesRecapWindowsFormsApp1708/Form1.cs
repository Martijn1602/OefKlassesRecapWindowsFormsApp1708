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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TellerVolume mijnTellerVolume = new TellerVolume();
        private TellerKanaal mijnTellerKanaal = new TellerKanaal();


        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnKanaalMin_Click(object sender, EventArgs e)
        {
            mijnTellerKanaal.VerlagenKanaal();
        }

        private void btnKanaalPlus_Click(object sender, EventArgs e)
        {
            mijnTellerKanaal.VerhogenKanaal();
        }

        private void btnVolumeMin_Click(object sender, EventArgs e)
        {
            mijnTellerVolume.VerlagenVolume();
        }

        private void btnVolumePlus_Click(object sender, EventArgs e)
        {
            mijnTellerVolume.VerhogenVolume();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            mijnTellerVolume.ResetVolume();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblKanaalShow_Click(object sender, EventArgs e)
        {
            mijnTellerKanaal.ToonKanaal();
            lblKanaalShow.Text = mijnTellerKanaal.ToString();
        }

        private void lblVolumeShow_Click(object sender, EventArgs e)
        {
            lblVolumeShow.Text = mijnTellerVolume.ToString();
        }

        private void btnOef3_Click(object sender, EventArgs e)
        {
            Oef3 oef3 = new Oef3();
            oef3.Show();
        }
    }
}
