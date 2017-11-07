using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED03ProjectHorseRace
{

    class Horse01 : Punter
    {
        public Horse01()
        {
            HorseID = 1;
            HorseName = "Who Shot Thebarman";
        }
    }

    class Horse02 : Punter
    {
        public Horse02()
        {
            HorseID = 2;
            HorseName = "Wall Of Fire";
        }
    }

    class Horse03 : Punter
    {
        public Horse03()
        {
            HorseID = 3;
            HorseName = "Max Dynamite";
        }
    }

    class Horse04 : Punter
    {
        public Horse04()
        {
            HorseID = 4;
            HorseName = "Boom Time";
        }
    }
}
