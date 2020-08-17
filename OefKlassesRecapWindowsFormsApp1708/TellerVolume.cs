using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefKlassesRecapWindowsFormsApp1708
{
    class TellerVolume
    {

        private int MijnTellerVolume = 0;

        public TellerVolume()
        {
        }

        public void BekijkenVolume()
        {
            MessageBox.Show(MijnTellerVolume.ToString());
        }

        public void ResetVolume()
        {
            MijnTellerVolume = 0;
        }

        public void VerhogenVolume()
        {
            MijnTellerVolume++;
        }

        public void VerlagenVolume()
        {
            MijnTellerVolume--;
        }
    }
}
