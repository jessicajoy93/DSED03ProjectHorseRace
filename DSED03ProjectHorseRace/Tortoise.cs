using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED03ProjectHorseRace
{

    class Tortoise //: Punter
    {
        public int TortoiseID { get; set; }
        public string Name { get; set; }
        public PictureBox MyPictureBox { get; set; }
        private int newDistance = 29;


        public void UpdatePostition()
        {
            MyPictureBox.Left = newDistance;
        }
        public void StartingPostition()
        {
            newDistance = 29;
            UpdatePostition();
        }
        public void Run()
        {
            newDistance += Factory.Number();
            UpdatePostition();
        }



    }
}
