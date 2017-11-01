using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED03ProjectHorseRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TransparentBackground();
        }

        private void TransparentBackground()
        {
            //Makes Backgrounds transparent for pictureboxes
            this.PointToScreen(panel1.Location);
            panel1.Parent = pbRaceTrack;
            panel1.BackColor = Color.Transparent;
        }
    }
}
