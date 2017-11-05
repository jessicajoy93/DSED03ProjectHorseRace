using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSED03ProjectHorseRace.Horse;

namespace DSED03ProjectHorseRace
{
    public partial class Form1 : Form
    {
        //private Horse.Horse DefaultHorse = new Horse01();

        Guy.Guy[] myGuy = new Guy.Guy[3];

        public Form1()
        {
            InitializeComponent();
            TransparentBackground();
            LoadData();
        }

        private void TransparentBackground()
        {
            //Makes Backgrounds transparent for pictureboxes
            this.PointToScreen(panel1.Location);
            panel1.Parent = pbRaceTrack;
            panel1.BackColor = Color.Transparent;
        }

        private void LoadData()
        {
            for (int i = 0; i < 3; i++)
            {
                myGuy[i] = Factory.Factory.GetAGuy(i);
                myGuy[i].GuyID = i;
            }

            myGuy[0].MyRadioButton = radioButton1;
            myGuy[1].MyRadioButton = radioButton2;
            myGuy[2].MyRadioButton = radioButton3;

            myGuy[0].MyRadioButton.Text = "Joe";
            myGuy[1].MyRadioButton.Text = "Sam";
            myGuy[2].MyRadioButton.Text = "Joshua";
        }

        private void allRB_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton FakeRB = new RadioButton();
            FakeRB = (RadioButton)sender;

            if (FakeRB.Checked)
            {
                panelBetting.Visible = true;
                lblMaxBet.Visible = true;
                int i = Convert.ToInt16(FakeRB.Tag);
                lblBettor.Text = myGuy[i].GuyName;
                lblMaxBet.Text = myGuy[i].GuyName + "'s max bet is $" + myGuy[i].MaxCash;
                nudCash.Maximum = myGuy[i].MaxCash;
                nudCash.Text = myGuy[i].MaxCash.ToString();
                nudHorseNumber.Minimum = 1;
                nudHorseNumber.Maximum = 4;
            }
        }
    }
}
