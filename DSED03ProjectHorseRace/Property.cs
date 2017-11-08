using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED03ProjectHorseRace
{
    class Property
    {
        public string NotBetYet { get; set; } = " has not placed a bet.";
        public RadioButton FakeRB { get; set; } = new RadioButton();

        //public bool isTrue { get; set; } = false;

        public int Tortoise { get; set; }
        public int Guy { get; set; }


    }
}
