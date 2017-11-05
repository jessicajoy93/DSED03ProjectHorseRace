﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED03ProjectHorseRace
{
    abstract class Punter
    {
        public int GuyID { get; set; }
        public string GuyName { get; set; }
        public int MaxCash { get; set; }
        public int AmountBet { get; set; }
        public int Dog { get; set; }

        public RadioButton MyRadioButton { get; set; }

        public int HorseID { get; set; }
        public string HorseName { get; set; }
    }
}