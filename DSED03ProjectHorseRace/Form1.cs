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
using Timer = System.Threading.Timer;

namespace DSED03ProjectHorseRace
{
    public partial class Form1 : Form
    {
        //private Horse.Horse DefaultHorse = new Horse01();

        Punter[] myGuy = new Punter[3];
        Punter[] myHorse = new Punter[4];
        Bet myBet = new Bet();



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
            this.PointToScreen(pbHorse1.Location);
            pbHorse1.Parent = pbRaceTrack;
            pbHorse1.BackColor = Color.Transparent;

            this.PointToScreen(pbHorse2.Location);
            pbHorse2.Parent = pbRaceTrack;
            pbHorse2.BackColor = Color.Transparent;

            this.PointToScreen(pbHorse3.Location);
            pbHorse3.Parent = pbRaceTrack;
            pbHorse3.BackColor = Color.Transparent;

            this.PointToScreen(pbHorse4.Location);
            pbHorse4.Parent = pbRaceTrack;
            pbHorse4.BackColor = Color.Transparent;
        }
        #endregion

        private void LoadData()
        {
            for (int i = 0; i < 3; i++)
            {
                myGuy[i] = Factory.GetAGuy(i);
                myGuy[i].GuyID = i;
            }

            for (int j = 0; j < 4; j++)
            {
                myHorse[j] = Factory.GetAHorse(j);
                myHorse[j].HorseID = j;
            }

            myGuy[0].MyRadioButton = radioButton1;
            lblJoe.Text = myGuy[0].GuyName + myBet.NotBetYet;
            myGuy[1].MyRadioButton = radioButton2;
            lblSam.Text = myGuy[1].GuyName + myBet.NotBetYet;
            myGuy[2].MyRadioButton = radioButton3;
            lblJoshua.Text = myGuy[2].GuyName + myBet.NotBetYet;

            myGuy[0].MyRadioButton.Text = "Joe";
            myGuy[1].MyRadioButton.Text = "Sam";
            myGuy[2].MyRadioButton.Text = "Joshua";
        }

        private void allRB_CheckedChanged(object sender, EventArgs e)
        {

            // RadioButton FakeRB = new RadioButton();
            myBet.FakeRB = (RadioButton)sender;

            if (myBet.FakeRB.Checked)
            {
                panelBetting.Visible = true;
                panelBets.Visible = true;
                lblMaxBet.Visible = true;
                int i = Convert.ToInt16(myBet.FakeRB.Tag);
                lblBettor.Text = myGuy[i].GuyName;
                Cash(i);
                nudHorseNumber.Minimum = 1;
                nudHorseNumber.Maximum = 4;
                btnBet.Text = "Place Bet for " + myGuy[i].GuyName;
                btnBet.Enabled = true;
            }
        }

        private void MaxCashUsed()
        {
            for (int i = 0; i < 3; i++)
            {
                if (myGuy[i].MaxCash == 0)
                {
                    myGuy[i].MyRadioButton.Enabled = false;
                    btnBet.Enabled = false;
                }
            }
        }

        private void Cash(int i)
        {
            lblMaxBet.Text = myGuy[i].GuyName + "'s max bet is $" + myGuy[i].MaxCash;
            nudCash.Maximum = myGuy[i].MaxCash;
            nudCash.Text = myGuy[i].MaxCash.ToString();

            MaxCashUsed();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(myBet.FakeRB.Tag);
            myGuy[i].AmountBet = Convert.ToInt32(nudCash.Text);
            myGuy[i].MaxCash = myGuy[i].MaxCash - myGuy[i].AmountBet;

            AmountBetPerGuy(i);
            Cash(i);
        }

        private void AmountBetPerGuy(int i)
        {

            AmountBetText(i);
        }

        private void AmountBetText(int i)
        {
            int j = 0;
            j = myHorse[j].HorseID = Convert.ToInt32(nudHorseNumber.Text) - 1;
            //j = myHorse[j].HorseID;
            if (i == 0)
            {
                lblJoe.Text = myGuy[0].GuyName + " has bet $" + myGuy[0].AmountBet + " on Horse " + myHorse[j].HorseName + ".";
            }
            else if (i == 1)
            {
                lblSam.Text = myGuy[1].GuyName + " has bet $" + myGuy[1].AmountBet + " on Horse " + myHorse[j].HorseName + ".";
            }
            else
            {
                lblJoshua.Text = myGuy[2].GuyName + " has bet $" + myGuy[2].AmountBet + " on Horse " + myHorse[j].HorseName + ".";
            }
            btnRace.Visible = true;
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            int formWidth = Form1.ActiveForm.Width - pbHorse1.Width - 15;
            while (pbHorse1.Location.X < formWidth && pbHorse2.Location.X < formWidth && pbHorse3.Location.X < formWidth && pbHorse4.Location.X < formWidth)
            {
                pbHorse1.Location = new Point(pbHorse1.Location.X + Factory.Number(), pbHorse1.Location.Y);
                pbHorse2.Location = new Point(pbHorse2.Location.X + Factory.Number(), pbHorse2.Location.Y);
                pbHorse3.Location = new Point(pbHorse3.Location.X + Factory.Number(), pbHorse3.Location.Y);
                pbHorse4.Location = new Point(pbHorse4.Location.X + Factory.Number(), pbHorse4.Location.Y);
                Application.DoEvents();
            }

            for (int i = 0; i < 98; i++)
            {



                //Thread.Sleep(100);
            }

            btnRace.Visible = false;
            btnBet.Visible = false;
            btnNewRace.Visible = true;

            //pbHorse1.Location = new Point(pbHorse1.Location.X + Factory.Number(), pbHorse1.Location.Y);
            //pbHorse2.Location = new Point(pbHorse2.Location.X + Factory.Number(), pbHorse2.Location.Y);
        }

        private void btnNewRace_Click(object sender, EventArgs e)
        {
            LoadData();
            var pbHorse1Location = pbHorse1.Location;
            pbHorse1.Location = new Point(pbHorse1Location.X = 3, pbHorse1.Location.Y);

            var pbHorse2Location = pbHorse2.Location;
            pbHorse2.Location = new Point(pbHorse2Location.X = 3, pbHorse2.Location.Y);

            var pbHorse3Location = pbHorse3.Location;
            pbHorse3.Location = new Point(pbHorse3Location.X = 3, pbHorse3.Location.Y);

            var pbHorse4Location = pbHorse4.Location;
            pbHorse4.Location = new Point(pbHorse4Location.X = 3, pbHorse4.Location.Y);

            //btnRace.Visible = true;
            btnBet.Visible = true;
            btnNewRace.Visible = false;
        }
    }
}

