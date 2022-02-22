using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeceptionPalace
{
    public partial class mainGameForm : Form
    {
        public mainGameForm()
        {
            InitializeComponent();
        }

        private void mainGameForm_Load(object sender, EventArgs e)
        {
            //initialising the contents of groupBoxArray to be referenced using player indexes
            groupBoxArray[0] = boxPlayer1;
            groupBoxArray[1] = boxPlayer2;
            groupBoxArray[2] = boxPlayer3;
            groupBoxArray[3] = boxPlayer4;
            groupBoxArray[4] = boxPlayer5;
            groupBoxArray[5] = boxPlayer6;
            groupBoxArray[6] = boxPlayer7;
            groupBoxArray[7] = boxPlayer8;
            groupBoxArray[8] = boxPlayer9;
            //initialising the contents of picBoxArray to be referenced using player indexes
            picBoxArray[0] = playerSprite1;
            picBoxArray[1] = playerSprite2;
            picBoxArray[2] = playerSprite3;
            picBoxArray[3] = playerSprite4;
            picBoxArray[4] = playerSprite5;
            picBoxArray[5] = playerSprite6;
            picBoxArray[6] = playerSprite7;
            picBoxArray[7] = playerSprite8;
            picBoxArray[8] = playerSprite9;
            //initialising the contents of buttonArray to be referenced using player indexes
            buttonArray[0] = btnToTarget1;
            buttonArray[1] = btnToTarget2;
            buttonArray[2] = btnToTarget3;
            buttonArray[3] = btnToTarget4;
            buttonArray[4] = btnToTarget5;
            buttonArray[5] = btnToTarget6;
            buttonArray[6] = btnToTarget7;
            buttonArray[7] = btnToTarget8;
            buttonArray[8] = btnToTarget9;
            //hide the initially hidden buttons since they might disrupt kingSpecialAbility:
            hideButtons();
            btnViewedKingsChoice.Hide();
            btnViewedPrelimResults.Hide();
            btnBeginPrelim.Hide();
            btnViewedSwitchResults.Hide();
            btnViewedSentinelResults.Hide();

            for (int i = 0; i < 9; i++)
            {
                groupBoxArray[i].Text = gamePlayed.getPlayer(i);//initialising the display of each player's username
                picBoxArray[i].Image = gamePlayed.getSprite(i, gamePlayed.getALIVEINDEX());//initialising each player's sprite
            }

            //below is test code in order to output the states of 'invisible' variables (arrRoles)
            MessageBox.Show("1: " + gamePlayed.getPlayer(0) + ": " + gamePlayed.getRole(0) + " " + gamePlayed.getFac(0) + " " + gamePlayed.getAliveStatus(0));
            MessageBox.Show("2: " + gamePlayed.getPlayer(1) + ": " + gamePlayed.getRole(1) + " " + gamePlayed.getFac(1) + " " + gamePlayed.getAliveStatus(1));
            MessageBox.Show("3: " + gamePlayed.getPlayer(2) + ": " + gamePlayed.getRole(2) + " " + gamePlayed.getFac(2) + " " + gamePlayed.getAliveStatus(2));
            MessageBox.Show("4: " + gamePlayed.getPlayer(3) + ": " + gamePlayed.getRole(3) + " " + gamePlayed.getFac(3) + " " + gamePlayed.getAliveStatus(3));
            MessageBox.Show("5: " + gamePlayed.getPlayer(4) + ": " + gamePlayed.getRole(4) + " " + gamePlayed.getFac(4) + " " + gamePlayed.getAliveStatus(4));
            MessageBox.Show("6: " + gamePlayed.getPlayer(5) + ": " + gamePlayed.getRole(5) + " " + gamePlayed.getFac(5) + " " + gamePlayed.getAliveStatus(5));
            MessageBox.Show("7: " + gamePlayed.getPlayer(6) + ": " + gamePlayed.getRole(6) + " " + gamePlayed.getFac(6) + " " + gamePlayed.getAliveStatus(6));
            MessageBox.Show("8: " + gamePlayed.getPlayer(7) + ": " + gamePlayed.getRole(7) + " " + gamePlayed.getFac(7) + " " + gamePlayed.getAliveStatus(7));
            MessageBox.Show("9: " + gamePlayed.getPlayer(8) + ": " + gamePlayed.getRole(8) + " " + gamePlayed.getFac(8) + " " + gamePlayed.getAliveStatus(8));
            MessageBox.Show("10: " + gamePlayed.getPlayer(9) + ": " + gamePlayed.getRole(9) + " " + gamePlayed.getFac(9) + " " + gamePlayed.getAliveStatus(9));
            MessageBox.Show("11: " + gamePlayed.getPlayer(10) + ": " + gamePlayed.getRole(10) + " " + gamePlayed.getFac(10) + " " + gamePlayed.getAliveStatus(10));
            MessageBox.Show("12: " + gamePlayed.getPlayer(11) + ": " + gamePlayed.getRole(11) + " " + gamePlayed.getFac(11) + " " + gamePlayed.getAliveStatus(11));

            gamePlayed.setForm(this);//sets reference of gameObj in the Game class to this form as 'this' refers to the current object
            gamePlayed.gameloop();//initialises the processing of the game itself
        }

        //unhides all the target buttons of alive players
        public void showButtons()
        {
            for(int playerIndex = 0; playerIndex < 9; playerIndex++)//for each player
            {
                if(buttonArray[playerIndex] != null)//checks that the player's button
                {                                   //hasn't been removed from the array
                    buttonArray[playerIndex].Show();//unhides the button if it hasn't
                }
            }
        }
        //hides all the target buttons
        public void hideButtons()
        {
            btnToTarget1.Hide();
            btnToTarget2.Hide();
            btnToTarget3.Hide();
            btnToTarget4.Hide();
            btnToTarget5.Hide();
            btnToTarget6.Hide();
            btnToTarget7.Hide();
            btnToTarget8.Hide();
            btnToTarget9.Hide();
        }

        //sets all the three pregame buttons hidden
        public void setPreGameBtnsHidden()
        {
            btn1stRole.Hide();
            btn2ndRole.Hide();
            btn3rdRole.Hide();
        }

        //unhides btnViewedKingsChoice
        public void showBtnViewedKingsChoice()
        {
            btnViewedKingsChoice.Show();
        }

        //unhides btnViewedSwitchResults
        public void showBtnViewedSwitchResults()
        {
            btnViewedSwitchResults.Show();
        }

        private void btn1stRole_Click(object sender, EventArgs e)
        {
            gamePlayed.preGameTarget(9);//processes targeting the 10th role
                                        //for kingSpecialAbility or multitalentSwitch
        }
        private void btn2ndRole_Click(object sender, EventArgs e)
        {
            gamePlayed.preGameTarget(10);//processes targeting the 11th role
                                        //for kingSpecialAbility or multitalentSwitch
        }
        private void btn3rdRole_Click(object sender, EventArgs e)
        {
            gamePlayed.preGameTarget(11);//processes targeting the 12th role
                                         //for kingSpecialAbility or multitalentSwitch
        }

        private void btnToTarget1_Click(object sender, EventArgs e)
        {
            gamePlayed.processTarget(0);//processes all possible instances of a player targeting the first player
        }

        private void btnToTarget2_Click(object sender, EventArgs e)
        {
            gamePlayed.processTarget(1);//processes all possible instances of a player targeting the second player
        }

        private void btnToTarget3_Click(object sender, EventArgs e)
        {
            gamePlayed.processTarget(2);//processes all possible instances of a player targeting the third player
        }

        private void btnToTarget4_Click(object sender, EventArgs e)
        {
            gamePlayed.processTarget(3);//processes all possible instances of a player targeting the fourth player
        }

        private void btnToTarget5_Click(object sender, EventArgs e)
        {
            gamePlayed.processTarget(4);//processes all possible instances of a player targeting the fifth player
        }

        private void btnToTarget6_Click(object sender, EventArgs e)
        {
            gamePlayed.processTarget(5);//processes all possible instances of a player targeting the sixth player
        }

        private void btnToTarget7_Click(object sender, EventArgs e)
        {
            gamePlayed.processTarget(6);//processes all possible instances of a player targeting the seventh player
        }

        private void btnToTarget8_Click(object sender, EventArgs e)
        {
            gamePlayed.processTarget(7);//processes all possible instances of a player targeting the eighth player
        }

        private void btnToTarget9_Click(object sender, EventArgs e)
        {
            gamePlayed.processTarget(8);//processes all possible instances of a player targeting the ninth player
        }

        private void btnViewedKingsChoice_Click(object sender, EventArgs e)
        {
            if (gamePlayed.getMultitalentIndex() > 8) { //validates that multitalent is not in play
                                                        //before skipping multitalentSwitch
                eventTextbox.Text = "You are " + gamePlayed.getPlayer(0) + " and you are the " + 
                    gamePlayed.getRole(0) + ". Choose who you want to target.";
                    //instructions for first player in night(). This leads right before
                    //night() is called in the button handlers btn1st/2nd/3rdRole_Click
                btnViewedKingsChoice.Hide();//button no longer needed                                                       
                showButtons();//unhides all target buttons
                gamePlayed.night();//proceed to night stage
            }
            else
            {   //instructions for the multitalent to complete their switch
                eventTextbox.Text = "You are " + gamePlayed.getPlayer(gamePlayed.getMultitalentIndex()) +
                    " and you are the Multitalent. Choose who you want to target.";
                //toggles visibility of now necessary/unnecessary roles
                btn1stRole.Show(); btn2ndRole.Show(); btn3rdRole.Show(); btnViewedKingsChoice.Hide();
            }
        }

        private void btnViewedPrelimResults_Click(object sender, EventArgs e)
        {   //hide this button, not needed anymore
            btnViewedPrelimResults.Hide();
            //instructions for executing()
            eventTextbox.Text = "You are " + gamePlayed.getPlayer(gamePlayed.getKingIndex()) + 
                ". Who do you want to execute?";
            //unhide all the buttons now that they are valid inputs
            showButtons();
            for(int playerIndex = 0; playerIndex < 9; playerIndex++)
            {   //resets the text in the groupbox for each player (i.e. removes their vote)
                groupBoxArray[playerIndex].Text = gamePlayed.getPlayer(playerIndex);
            }
        }

        private void btnBeginPrelim_Click(object sender, EventArgs e)
        {
            btnBeginPrelim.Hide();//button not needed anymore
            showButtons();//unhides the target buttons now that they are valid inputs
            //outputs instructions to eventTextbox
            eventTextbox.Text = "You are " + gamePlayed.getPlayer(gamePlayed.getPlayerCounter()) +
                ", who do you want to vote for?";
        }

        private void btnViewedSwitchResults_Click(object sender, EventArgs e)
        {
            eventTextbox.Text = "You are " + gamePlayed.getPlayer(0) + " and you are the " +
                    gamePlayed.getRole(0) + ". Choose who you want to target.";
            //instructions for first player in night(). This leads right before
            //night() is called in the button handlers btn1st/2nd/3rdRole_Click
            btnViewedSwitchResults.Hide();//button no longer needed                                                       
            showButtons();//unhides all target buttons
            gamePlayed.night();//proceed to night stage
        }

        private void btnViewedSentinelResults_Click(object sender, EventArgs e)
        {
            btnViewedSentinelResults.Hide();//button no longer needed     
            showButtons();//unhides all target buttons
            gamePlayed.day();//proceed to day stage
        }
    }
}
