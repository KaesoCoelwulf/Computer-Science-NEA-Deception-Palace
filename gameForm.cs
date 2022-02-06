﻿using System;
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

        }

        private void btnToTarget1_Click(object sender, EventArgs e)
        {

        }
    }
}
