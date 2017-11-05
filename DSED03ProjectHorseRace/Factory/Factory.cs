using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSED03ProjectHorseRace.Guy;
using DSED03ProjectHorseRace.Horse;

namespace DSED03ProjectHorseRace.Factory
{
    class Factory
    {
        // decides which class to instantiate
        public static Guy.Guy GetAGuy(int id)
        {
            switch (id)
            {
                case 0:
                    return new Guy01();
                case 1:
                    return new Guy02();
                case 2:
                    return new Guy03();

                default:
                    return new Guy01();
            }
        }

        public static Horse.Horse GetAHorse(int id)
        {
            switch (id)
            {
                case 0:
                    return new Horse01();
                case 1:
                    return new Horse02();
                case 2:
                    return new Horse03();
                case 3:
                    return new Horse04();

                default:
                    return new Horse01();
            }
        }
    }
}
