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

        }
    }
}
