using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefKlassesRecapWindowsFormsApp1708
{
    class TellerKanaal
    {

        private int MijnTellerKanaal = 0;

        public TellerKanaal()
        {
        }

        public void BekijkenKanaal()
        {
            MessageBox.Show(MijnTellerKanaal.ToString());
        }

        public void ResetKanaal()
        {
            MijnTellerKanaal = 0;
        }

        public void VerhogenKanaal()
        {
            MijnTellerKanaal++;
        }

        public void VerlagenKanaal()
        {
            MijnTellerKanaal--;
        }

        public void ToonKanaal()
        {
            List<string> Channel = new List<string>(new string[12]);

            Channel[0] = "Een";
            Channel[1] = "Canvas";
            Channel[2] = "VTM";
            Channel[3] = "Kanaal2";
            Channel[4] = "Vijf";
            Channel[5] = "Ned1";
            Channel[6] = "Ned2";
            Channel[7] = "Ned3";
            Channel[8] = "BBC";
            Channel[9] = "RTBF";
            Channel[10] = "National Geographics";
            Channel[11] = "Youtube";

           string ShowChannel = (Channel[MijnTellerKanaal]);
           

        }
    }
}
