using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSED03ProjectHorseRace;

namespace DSED03ProjectHorseRace
{
    public partial class Form1 : Form
    {
        //private Horse.Horse DefaultHorse = new Horse01();

        Punter[] myGuy = new Punter[3];
        Tortoise[] myTortoise = new Tortoise[4];
        Property myProperty = new Property();



        public Form1()
        {
            InitializeComponent();
            TransparentBackground();
            LoadData();
        }

        #region Transparent Background
        private void TransparentBackground()
        {
            //Makes Backgrounds transparent for pictureboxes
            this.PointToScreen(pb1.Location);
            pb1.Parent = pbRaceTrack;
            pb1.BackColor = Color.Transparent;

            this.PointToScreen(pb2.Location);
            pb2.Parent = pbRaceTrack;
            pb2.BackColor = Color.Transparent;

            this.PointToScreen(pb3.Location);
            pb3.Parent = pbRaceTrack;
            pb3.BackColor = Color.Transparent;

            this.PointToScreen(pb4.Location);
            pb4.Parent = pbRaceTrack;
            pb4.BackColor = Color.Transparent;
        }
        #endregion

        private void LoadData()
        {
            for (myProperty.Guy = 0; myProperty.Guy < 3; myProperty.Guy++)
            {
                myGuy[myProperty.Guy] = Factory.GetAGuy(myProperty.Guy);
                myGuy[myProperty.Guy].GuyID = myProperty.Guy;
            }

            //for (int j = 0; j < 4; j++)
            //{
            //    myHorse[j] = Factory.GetAHorse(j);
            //    myHorse[j].HorseID = j;
            //}

            GuyNotBetYet();

            myGuy[0].MyRadioButton.Text = "Joe";
            myGuy[1].MyRadioButton.Text = "Sam";
            myGuy[2].MyRadioButton.Text = "Joshua";

            myTortoise[0] = new Tortoise() { TortoiseID = 1, Name = "Who Shot Thebarman" };
            myTortoise[1] = new Tortoise() { TortoiseID = 2, Name = "Wall Of Fire" };
            myTortoise[2] = new Tortoise() { TortoiseID = 3, Name = "Max Dynamite" };
            myTortoise[3] = new Tortoise() { TortoiseID = 4, Name = "Boom Time" };

            myTortoise[0].MyPictureBox = pb1;
            myTortoise[1].MyPictureBox = pb2;
            myTortoise[2].MyPictureBox = pb3;
            myTortoise[3].MyPictureBox = pb4;

            // will give me how many tortoises I have
            foreach (var id in myTortoise)
            {
                if (Factory.TortoiseCount < id.TortoiseID)
                {
                    Factory.TortoiseCount = id.TortoiseID;
                }
                Factory.TortoiseCount += 1;
            }
        }

        private void GuyNotBetYet()
        {
            myGuy[0].MyRadioButton = radioButton1;
            lblJoe.Text = myGuy[0].GuyName + myProperty.NotBetYet;
            myGuy[1].MyRadioButton = radioButton2;
            lblSam.Text = myGuy[1].GuyName + myProperty.NotBetYet;
            myGuy[2].MyRadioButton = radioButton3;
            lblJoshua.Text = myGuy[2].GuyName + myProperty.NotBetYet;
        }

        private void allRB_CheckedChanged(object sender, EventArgs e)
        {

            // RadioButton FakeRB = new RadioButton();
            myProperty.FakeRB = (RadioButton)sender;

            if (myProperty.FakeRB.Checked)
            {
                panelBetting.Visible = true;
                panelBets.Visible = true;
                lblMaxBet.Visible = true;
                myProperty.Guy = Convert.ToInt16(myProperty.FakeRB.Tag);
                lblBettor.Text = myGuy[myProperty.Guy].GuyName;
                Cash();
                nudTortoiseNumber.Minimum = 1;
                nudTortoiseNumber.Maximum = 4;
                btnBet.Text = "Place Bet for " + lblBettor.Text;// myGuy[myProperty.Guy].GuyName;
                btnBet.Enabled = true;
            }
        }

        private void MaxCashUsed()
        {
            for (myProperty.Guy = 0; myProperty.Guy < 3; myProperty.Guy++)
            {
                if (myGuy[myProperty.Guy].MaxCash == 0)
                {
                    myGuy[myProperty.Guy].MyRadioButton.Enabled = false;
                    btnBet.Enabled = false;
                }
            }
        }

        private void Cash()
        {
            lblMaxBet.Text = myGuy[myProperty.Guy].GuyName + "'s max bet is $" + myGuy[myProperty.Guy].MaxCash;
            nudCash.Maximum = myGuy[myProperty.Guy].MaxCash;
            nudCash.Text = myGuy[myProperty.Guy].MaxCash.ToString();

            MaxCashUsed();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            myProperty.Guy = Convert.ToInt16(myProperty.FakeRB.Tag);
            myGuy[myProperty.Guy].AmountBet = Convert.ToInt32(nudCash.Text);
            myGuy[myProperty.Guy].MaxCash = myGuy[myProperty.Guy].MaxCash - myGuy[myProperty.Guy].AmountBet;

            AmountBetText();
            Cash();
        }

        private void AmountBetText()
        {
            myProperty.Tortoise = myTortoise[myProperty.Tortoise].TortoiseID = Convert.ToInt32(nudTortoiseNumber.Text) - 1;
            if (myProperty.Guy == 0)
            {
                lblJoe.Text = myGuy[0].GuyName + " has bet $" + myGuy[0].AmountBet + " on Tortoise " + myTortoise[myProperty.Tortoise].Name + ".";
            }
            else if (myProperty.Guy == 1)
            {
                lblSam.Text = myGuy[1].GuyName + " has bet $" + myGuy[1].AmountBet + " on Tortoise " + myTortoise[myProperty.Tortoise].Name + ".";

            }
            else
            {
                lblJoshua.Text = myGuy[2].GuyName + " has bet $" + myGuy[2].AmountBet + " on Tortoise " + myTortoise[myProperty.Tortoise].Name + ".";
            }
            btnRace.Visible = true;
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            StartRace();

        }

        private void StartRace()
        {
            Factory.RaceTrackLength = Form1.ActiveForm.Width - pb1.Width - 15;

            while (myTortoise[myProperty.Tortoise].Run() < Factory.RaceTrackLength)
            {
                myTortoise[0].Run();
                myTortoise[1].Run();
                myTortoise[2].Run();
                myTortoise[3].Run();
            }

            //while (
            //    pb1.Location.X < Factory.RaceTrackLength &&
            //    pb2.Location.X < Factory.RaceTrackLength &&
            //    pb3.Location.X < Factory.RaceTrackLength &&
            //    pb4.Location.X < Factory.RaceTrackLength
            //    )
            //{
            //    //for (myProperty.Tortoise = 0; myProperty.Tortoise < Factory.TortoiseCount; myProperty.Tortoise++)


            //    pb1.Location = new Point(pb1.Location.X + Factory.Number(), pb1.Location.Y);
            //    pb2.Location = new Point(pb2.Location.X + Factory.Number(), pb2.Location.Y);
            //    pb3.Location = new Point(pb3.Location.X + Factory.Number(), pb3.Location.Y);
            //    pb4.Location = new Point(pb4.Location.X + Factory.Number(), pb4.Location.Y);
            //    Application.DoEvents();

            //}

            //while (pb1.Location.X < Factory.FormWidth && pb2.Location.X < Factory.FormWidth && pb3.Location.X < Factory.FormWidth && pb4.Location.X < Factory.FormWidth)
            //{


            //}

            btnRace.Visible = false;
            btnBet.Visible = false;
            btnNewRace.Visible = true;

            //if (pbHorse1.Location.X >= Factory.FormWidth)
            //{
            //    Factory.HorseWinner = 0;
            //}
            //else if (pbHorse2.Location.X >= Factory.FormWidth)
            //{
            //    Factory.HorseWinner = 1;
            //}
            //else if (pbHorse3.Location.X >= Factory.FormWidth)
            //{
            //    Factory.HorseWinner = 2;
            //}
            //else if (pbHorse4.Location.X >= Factory.FormWidth)
            //{
            //    Factory.HorseWinner = 3;
            //}
            //MessageBox.Show("Horse #" + Factory.HorseWinner);
        }

        private void btnNewRace_Click(object sender, EventArgs e)
        {
            // LoadData();
            GuyNotBetYet();

            var pbHorse1Location = pb1.Location;
            pb1.Location = new Point(pbHorse1Location.X = 3, pb1.Location.Y);

            var pbHorse2Location = pb2.Location;
            pb2.Location = new Point(pbHorse2Location.X = 3, pb2.Location.Y);

            var pbHorse3Location = pb3.Location;
            pb3.Location = new Point(pbHorse3Location.X = 3, pb3.Location.Y);

            var pbHorse4Location = pb4.Location;
            pb4.Location = new Point(pbHorse4Location.X = 3, pb4.Location.Y);

            //btnRace.Visible = true;
            btnBet.Visible = true;
            btnNewRace.Visible = false;
        }
    }
}

