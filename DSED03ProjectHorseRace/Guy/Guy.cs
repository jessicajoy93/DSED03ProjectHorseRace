using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED03ProjectHorseRace.Guy
{
    abstract class Guy
    {

        public int GuyID { get; set; }
        public string GuyName { get; set; }
        public int MaxCash { get; set; }

        public RadioButton MyRadioButton { get; set; }

    }
}

