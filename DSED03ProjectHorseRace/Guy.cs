using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED03ProjectHorseRace
{

    class Guy01 : Punter
    {
        public Guy01()
        {
            GuyID = 1;
            GuyName = "Joe";
            MaxCash = 50;
        }


    }

    class Guy02 : Punter
    {
        public Guy02()
        {
            GuyID = 2;
            GuyName = "Sam";
            MaxCash = 50;
        }
    }

    class Guy03 : Punter
    {
        public Guy03()
        {
            GuyID = 3;
            GuyName = "Joshua";
            MaxCash = 50;
        }
    }


}

