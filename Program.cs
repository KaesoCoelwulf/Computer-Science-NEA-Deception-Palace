using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeceptionPalace
{
    class Game
    {
        private string code;//for future iterations, holds the 4 letter code to reference a game
        private string[] arrPlayers = new string[12];//array of players' usernames in order to match their corresponding role in arrRoles
        private Role[] arrRoles = new Role[12];//array of the corresponding roles in index positions to arrPlayers
        private int[,] arrStats = new int[2, 2];//for future iterations holds the stat changes to be processed in gameEnd
        private System.Drawing.Bitmap[,] arrSprites = new System.Drawing.Bitmap[2, 12];//for future iterations holds corresponding player's sprite preference
        private int WININDEX;//constant for the index of winning players in arrStats
        private int LOSTINDEX;//constant for the index of losing players in arrStats
        private int ALIVEINDEX;//constant for the index of alive players in arrStats
	@@ -51,22 +66,40 @@ class Game
        private int[] targets = new int[12];//contains the indexes of each player's targets for each night stage
        private string facWon;//contains the name of the faction that won
        private string hostUser;//for future iterations, the name of the user who is hosting the game
        private Form gameForm;//the form which games occur in

        //method below returns the length of arrRoles
        public int getRolesAmount() { return arrRoles.Length; }

        //method below simply returns ALIVEINDEX for game initialising purposes
        public int getALIVEINDEX() { return ALIVEINDEX; }

        public string getRole(int playerIndex) { return arrRoles[playerIndex].getRole(); }
        //above method returns the string of the player's role

        //below method returns the alive status of the player
        public string getAliveStatus(int playerIndex) {
            if (arrRoles[playerIndex].getAlive() == true) {
                return "true";
            } else { 
                return "false";
            }
        }
	@@ -81,7 +114,9 @@ public string getFac(int playerIndex)
        //above method returns the sprite in arrSprites of the player and alive status referenced referenced 
        public string getPlayer(int playerIndex) { return arrPlayers[playerIndex]; }
        //above method returns the username of the player at index playerIndex
        public Game(string callingUser, string callingCode) {
            hostUser = callingUser;//useful in iteration 4 onwards
            arrPlayers[0] = "firstPlayer";//filler assignments until profiles added in iteration 3
            arrPlayers[1] = "secondPlayer";
	@@ -92,19 +127,21 @@ public string getFac(int playerIndex)
            arrPlayers[6] = "seventhPlayer";
            arrPlayers[7] = "eighthPlayer";
            arrPlayers[8] = "ninethPlayer";
            WININDEX = 0;//this variable and the 4 below are category index constants for arrStats/Sprites
            LOSTINDEX = 1;
            ALIVEINDEX = 0;
            DEADINDEX = 1;

            for (int k = 0; k < 9; k++)
            {       //for loop initialises contents of arrSprites until customisability enabled
                arrSprites[ALIVEINDEX, k] = Properties.Resources.pinkWomanAlive;
                arrSprites[DEADINDEX, k] = Properties.Resources.pinkWomanDead;
            }
            
            code = callingCode;//useful in iteration 4 onwards
            
            winMet = false;//these four variables are preset to false because no one can have won 
            palaceWon = false;//before the game has actually begun
            jesterWon = false;
	@@ -113,7 +150,8 @@ public string getFac(int playerIndex)
            generateRoles();
        }

        public void generateRoles() {

            generateGuaranteed();//assigns random indexes to the index variables of guaranteed roles
            generateOptional();//asigns random indexes to the index variables of optional roles
	@@ -197,7 +235,7 @@ public void generateOptional()
                    case "Villager 8":
                        v8Index = rdmNum;
                        break;
    
                }
            }
        }
	@@ -231,8 +269,259 @@ public void initialiseRoles()
            arrRoles[v8Index] = Villager8;
            arrRoles[assassinIndex] = Assassin;
        }
    }
    
    class Role
    {
        private string roleName;
	@@ -243,24 +532,12 @@ class Role
        public void setAlive(bool newStatus) { aliveStatus = newStatus; } //aliveStatus setter
        public bool getAlive() { return aliveStatus; } //aliveStatus getter
        public string getFaction() { return faction; } //faction getter
        public Role (string nameOfRole, string fac) //constructor
        {
            roleName = nameOfRole;
            faction = fac;
            aliveStatus = true;//all players begin the game alive, so this is pregenerated to alive
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainGameForm());
        }
    }
}
