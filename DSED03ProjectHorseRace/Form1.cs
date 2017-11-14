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
        Tortoise[] myTortoise = new Tortoise[8];
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

            this.PointToScreen(pb5.Location);
            pb5.Parent = pbRaceTrack;
            pb5.BackColor = Color.Transparent;

            this.PointToScreen(pb6.Location);
            pb6.Parent = pbRaceTrack;
            pb6.BackColor = Color.Transparent;

            this.PointToScreen(pb7.Location);
            pb7.Parent = pbRaceTrack;
            pb7.BackColor = Color.Transparent;

            this.PointToScreen(pb8.Location);
            pb8.Parent = pbRaceTrack;
            pb8.BackColor = Color.Transparent;
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

            myTortoise[0] = new Tortoise() { TortoiseID = 1, Name = "Shell Shock" };
            myTortoise[1] = new Tortoise() { TortoiseID = 2, Name = "MiShell" };
            myTortoise[2] = new Tortoise() { TortoiseID = 3, Name = "Slowpoke" };
            myTortoise[3] = new Tortoise() { TortoiseID = 4, Name = "Sally Monella" };
            myTortoise[4] = new Tortoise() { TortoiseID = 5, Name = "Shelldon" };
            myTortoise[5] = new Tortoise() { TortoiseID = 6, Name = "Voldetort" };
            myTortoise[6] = new Tortoise() { TortoiseID = 7, Name = "Aristurtle" };
            myTortoise[7] = new Tortoise() { TortoiseID = 8, Name = "Zippy" };

            myTortoise[0].MyPictureBox = pb1;
            myTortoise[1].MyPictureBox = pb2;
            myTortoise[2].MyPictureBox = pb3;
            myTortoise[3].MyPictureBox = pb4;
            myTortoise[4].MyPictureBox = pb5;
            myTortoise[5].MyPictureBox = pb6;
            myTortoise[6].MyPictureBox = pb7;
            myTortoise[7].MyPictureBox = pb8;


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
                nudTortoiseNumber.Maximum = Factory.TortoiseCount - 1;
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
                else
                {
                    myGuy[myProperty.Guy].MyRadioButton.Enabled = true;
                    btnBet.Enabled = true;
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
            myGuy[myProperty.Guy].BettorTortoiseNum = myProperty.Tortoise;
            if (myProperty.Guy == 0)
            {
                lblJoe.Text = myGuy[0].GuyName + " has bet $" + myGuy[0].AmountBet + " on #" + (myProperty.Tortoise + 1) + " " + myTortoise[myProperty.Tortoise].Name + ".";
            }
            else if (myProperty.Guy == 1)
            {
                lblSam.Text = myGuy[1].GuyName + " has bet $" + myGuy[1].AmountBet + " on #" + (myProperty.Tortoise + 1) + " " + myTortoise[myProperty.Tortoise].Name + ".";

            }
            else
            {
                lblJoshua.Text = myGuy[2].GuyName + " has bet $" + myGuy[2].AmountBet + " on #" + (myProperty.Tortoise + 1) + " " + myTortoise[myProperty.Tortoise].Name + ".";
            }
            btnRace.Visible = true;
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            StartRace();
            //IsWinner();

        }

        private void StartRace()
        {
            Factory.RaceTrackLength = Form1.ActiveForm.Width - pb1.Width - (pb1.Width / 2);
            while (pb1.Location.X < Factory.RaceTrackLength &&
                                 pb2.Location.X < Factory.RaceTrackLength &&
                                 pb3.Location.X < Factory.RaceTrackLength &&
                                 pb4.Location.X < Factory.RaceTrackLength &&
                                 pb5.Location.X < Factory.RaceTrackLength &&
                                 pb6.Location.X < Factory.RaceTrackLength &&
                                 pb7.Location.X < Factory.RaceTrackLength &&
                                 pb8.Location.X < Factory.RaceTrackLength
                        )
            //do
            {
                for (myProperty.Tortoise = 0; myProperty.Tortoise < 8; myProperty.Tortoise++)
                {
                    myTortoise[myProperty.Tortoise].Run();
                    Application.DoEvents();
                    if (myTortoise[myProperty.Tortoise].MyPictureBox.Location.X >= Factory.RaceTrackLength)
                    {
                        myProperty.TortoiseWinner = myTortoise[myProperty.Tortoise].TortoiseID;
                        if (myProperty.TortoiseWinner == 0)
                        {
                            myProperty.TortoiseWinner = 1;
                        }

                        //MessageBox.Show("Winner is Tortoise #" + myProperty.TortoiseWinner + " Name: " + myTortoise[myProperty.Tortoise].Name);
                        lblWinner.Text = "Winner is Tortoise #" + myProperty.TortoiseWinner + " Name: " + myTortoise[myProperty.Tortoise].Name;
                        IsWinner();
                    }
                }

            };



            btnRace.Visible = false;
            btnBet.Visible = false;
            btnNewRace.Visible = true;




        }

        private void IsWinner()
        {
            if (myGuy[0].BettorTortoiseNum == myProperty.TortoiseWinner - 1)
            {
                myProperty.isWinner = true;
                myGuy[0].MaxCash += (myGuy[0].AmountBet * 2);
                lblMaxBet.Text = myGuy[0].GuyName + "'s max bet is $" + myGuy[0].MaxCash;
                //Cash();
                MaxCashUsed();
            }
            else if (myGuy[1].BettorTortoiseNum == myProperty.TortoiseWinner)
            {
                myProperty.isWinner = true;
                myGuy[1].MaxCash += (myGuy[1].AmountBet * 2);
                lblMaxBet.Text = myGuy[1].GuyName + "'s max bet is $" + myGuy[1].MaxCash;
                //Cash();
                MaxCashUsed();
            }
            else if (myGuy[2].BettorTortoiseNum == myProperty.TortoiseWinner)
            {
                myProperty.isWinner = true;
                myGuy[2].MaxCash += (myGuy[2].AmountBet * 2);
                lblMaxBet.Text = myGuy[2].GuyName + "'s max bet is $" + myGuy[2].MaxCash;
                //Cash();
                MaxCashUsed();
            }

        }



        private void btnNewRace_Click(object sender, EventArgs e)
        {//Moves all the Tortoises back to their starting positions
            for (myProperty.Tortoise = 0; myProperty.Tortoise < 8; myProperty.Tortoise++)
            {
                myTortoise[myProperty.Tortoise].StartingPostition();
            }
            myProperty.Tortoise = 0;
            //LoadData();
            GuyNotBetYet();





            //btnRace.Visible = true;
            btnBet.Visible = true;
            btnNewRace.Visible = false;
        }
    }
}

