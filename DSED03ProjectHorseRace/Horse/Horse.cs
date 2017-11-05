using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED03ProjectHorseRace.Horse
{
    abstract class Horse
    {
        public int HorseID { get; set; }
        public string HorseName { get; set; }

        public Horse()
        {
            HorseID = 1;
            HorseName = "Phar Lap";
        }
    }
}
