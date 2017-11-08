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

        public bool Run()
        {
            Point p = MyPictureBox.Location;
            p.X += Factory.Number();
            MyPictureBox.Location = p;
            return true;
        }
    }
}
