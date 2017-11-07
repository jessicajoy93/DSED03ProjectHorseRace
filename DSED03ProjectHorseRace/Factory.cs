using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSED03ProjectHorseRace;

namespace DSED03ProjectHorseRace
{
    static class Factory
    {
        private static Random Random = new Random();
        //public static int Number = Random.Next(0, 10);
        private static int newNumber;

        public static int Number()
        {
            return newNumber = Random.Next(0, 20);
        }

        // decides which class to instantiate
        public static Punter GetAGuy(int id)
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

        public static Punter GetAHorse(int id)
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
