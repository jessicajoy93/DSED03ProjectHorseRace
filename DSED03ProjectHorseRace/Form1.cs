using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSED03ProjectHorseRace;

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
            myHorse[i].HorseID = Convert.ToInt32(nudHorseNumber.Text);
            AmountBetText(i);
        }

        private void AmountBetText(int i)
        {
            if (i == 0)
            {
                lblJoe.Text = myGuy[0].GuyName + " has bet $" + myGuy[0].AmountBet + " on Horse " + myHorse[i].HorseName + ".";
            }
            else if (i == 1)
            {
                lblSam.Text = myGuy[1].GuyName + " has bet $" + myGuy[1].AmountBet + " on Horse " + myHorse[i].HorseName + ".";
            }
            else
            {
                lblJoshua.Text = myGuy[2].GuyName + " has bet $" + myGuy[2].AmountBet + " on Horse " + myHorse[i].HorseName + ".";
            }
        }
    }
}
