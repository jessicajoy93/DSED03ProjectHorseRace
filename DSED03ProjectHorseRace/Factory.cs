using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSED03ProjectHorseRace;

namespace DSED03ProjectHorseRace
{
    static class Factory
    {
        private static Random Random = new Random();
        //public static int Number = Random.Next(0, 10);
        private static int newNumber;

        public static int FormWidth { get; set; }

        public static int HorseWinner { get; set; }
        public static int TortoiseCount { get; set; } = 0;

        public static int StartingPosition { get; set; } = 3;
        public static int RaceTrackLength { get; set; }
        public static int Location { get; set; } = 0;




        public static int Number()
        {
            return newNumber = Random.Next(0, 4);
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
    }
}
