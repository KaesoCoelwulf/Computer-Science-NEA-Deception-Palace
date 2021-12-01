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
        private string[,] arrSprites = new string[2, 12];//for future iterations holds corresponding player's sprite preference
        private int BLOCKERNO;//constant that holds the number indicating a user has been blocked in targets[]
        private int WININDEX;//constant for the index of winning players in arrStats
        private int LOSTINDEX;//constant for the index of losing players in arrStats
        private int ALIVEINDEX;//constant for the index of alive players in arrStats
        private int DEADINDEX;//constant for the index of dead players in arrStats
        private int kingIndex;//the index corresponds to the king in arrPlayers, arrRoles, arrSprites, targets
        //private int blockerIndex;//the index corresponds to the blocker in arrPlayers, arrRoles, arrSprites, targets
        private int assassinIndex;//the index corresponds to the assassin in arrPlayers, arrRoles, arrSprites, targets
        //private int chemistIndex;//the index corresponds to the chemist in arrPlayers, arrRoles, arrSprites, targets
        //private int sentinelIndex;//the index corresponds to the sentinel in arrPlayers, arrRoles, arrSprites, targets
        //private int multitalentIndex;//the index corresponds to the multitalent in arrPlayers, arrRoles, arrSprites, targets
        private int bg1Index;//the index corresponds to the first bodyguard in arrPlayers, arrRoles, arrSprites, targets
        private int bg2Index;//the index corresponds to the second bodyguard in arrPlayers, arrRoles, arrSprites, targets
        //private int jesterIndex;//the index corresponds to the jester in arrPlayers, arrRoles, arrSprites, targets
        private int v1Index;//the index corresponds to the first villager in arrPlayers, arrRoles, arrSprites, targets
        private int v2Index;//the index corresponds to the second villager in arrPlayers, arrRoles, arrSprites, targets
        private int v3Index;//the index corresponds to the third villager in arrPlayers, arrRoles, arrSprites, targets
        private int v4Index;//the index corresponds to the fourthager in arrPlayers, arrRoles, arrSprites, targets
        private int v5Index;//the index corresponds to the fifthlager in arrPlayers, arrRoles, arrSprites, targets
        private int v6Index;//the index corresponds to the sixth villager in arrPlayers, arrRoles, arrSprites, targets
        private int v7Index;//the index corresponds to the seventh villager in arrPlayers, arrRoles, arrSprites, targets
        private int v8Index;//the index corresponds to the eighth villager in arrPlayers, arrRoles, arrSprites, targets
        private int v9Index;//the index corresponds to the ninth villager in arrPlayers, arrRoles, arrSprites, targets
        private string DB;//for future iterations, the filepath of the database
        private bool winMet;//holds whether or not any faction has achieved their win condition
        private int targetIndex;//the index of the target of the current player being asked to enter a target
        private int executedPlayer;//the index of the player the King executes in executing()
        private bool palaceWon;//holds whether or not the palace won the game
        private bool assassinWon;//holds whether or not the assassin faction won the game
        private bool jesterWon;//holds whether or not the jester won the game
        private List<int> deadList = new List<int>();//contains an up to date list of all dead players
        private List<int> aliveList = new List<int>();//contains an up to date list of all alive players
        private List<int> aliveWinList = new List<int>();//contains a list of all players who won the game who are alive at the end
        private List<int> aliveLostList = new List<int>();//contains a list of all players who lost the game who are alive at the end
        private List<int> deadWinList = new List<int>();//contains a list of all players who won the game who are dead at the end
        private List<int> deadLostList = new List<int>();//contains a list of all players who lost the game who are dead at the end
        private int[] targets = new int[12];//contains the indexes of each player's targets for each night stage
        private string facWon;//contains the name of the faction that won
        private string hostUser;//for future iterations, the name of the user who is hosting the game
        private Form gameForm;//the form which games occur in

        public Game(string callingUser, string callingCode) {
            hostUser = callingUser;//useful in iteration 4 onwards
            arrPlayers[0] = "firstPlayer";//filler assignments until profiles added in iteration 3
            arrPlayers[1] = "secondPlayer";
            arrPlayers[2] = "thirdPlayer";
            arrPlayers[3] = "fourthPlayer";
            arrPlayers[4] = "fifthPlayer";
            arrPlayers[5] = "sixthPlayer";
            arrPlayers[6] = "seventhPlayer";
            arrPlayers[7] = "eighthPlayer";
            arrPlayers[8] = "ninethPlayer";
            code = callingCode;//useful in iteration 4 onwards
            BLOCKERNO = -1;//indicator that a player is blocked
            WININDEX = 0;//this variable and the 4 below are category index constants for arrStats/Sprites
            LOSTINDEX = 1;
            ALIVEINDEX = 0;
            DEADINDEX = 1;
            winMet = false;//these four variables are preset to false because no one can have won 
            palaceWon = false;//before the game has actually begun
            jesterWon = false;
            assassinWon = false;

            generateRoles();
        }

        public void generateRoles() {

            generateGuaranteed();//assigns random indexes to the index variables of guaranteed roles
            generateOptional();//asigns random indexes to the index variables of optional roles
            initialiseRoles();//initialises the roles in arrRoles

        }
        public void generateGuaranteed()
        {
            Role fillerRole = new Role("notnull", "notnull");
            int rdmNum;
            string currentRole;
            Random rdm = new Random();//Random is a c# class that generates random outputs between certain arguments
            string[] guaranteedRoles = { "King", "Bodyguard", "Assassin" };
            for (int n = 0; n < guaranteedRoles.Length; n++)
            {
                rdmNum = rdm.Next(0, 9);//Outputs random number between 0 and 8
                while (arrRoles[rdmNum] != null)//Validates that the random number is not already taken by another role
                {
                    rdmNum = rdm.Next(0, 9);
                }
                arrRoles[rdmNum] = fillerRole;
                currentRole = guaranteedRoles[n];

                switch (currentRole)
                {
                    case "King":
                        kingIndex = rdmNum;
                        break;
                    case "Bodyguard":
                        bg1Index = rdmNum;
                        break;
                    case "Assassin":
                        assassinIndex = rdmNum;
                        break;
                }
            }
        }
        public void generateOptional()
        {
            Role fillerRole = new Role("notnull", "notnull");
            int rdmNum;
            string currentRole;
            Random rdm = new Random();//Random is a c# class that generates random outputs between certain arguments
            string[] optionalRoles = { "Bodyguard", "Villager 1", "Villager 2", "Villager 3", "Villager 4", "Villager 5", "Villager 6", "Villager 7", "Villager 8", "Villager 9" };
            for (int i = 0; i < optionalRoles.Length; i++)
            {
                rdmNum = rdm.Next(0, 12);//Outputs random number between 0 and 11
                while (arrRoles[rdmNum] != null)//Validates that the random number is not already taken by another role
                {
                    rdmNum = rdm.Next(0, 12);
                }
                arrRoles[rdmNum] = fillerRole;
                currentRole = optionalRoles[i];

                switch (currentRole)
                {
                    case "Bodyguard":
                        bg2Index = rdmNum;
                        break;
                    case "Villager 1":
                        v1Index = rdmNum;
                        break;
                    case "Villager 2":
                        v2Index = rdmNum;
                        break;
                    case "Villager 3":
                        v3Index = rdmNum;
                        break;
                    case "Villager 4":
                        v4Index = rdmNum;
                        break;
                    case "Villager 5":
                        v5Index = rdmNum;
                        break;
                    case "Villager 6":
                        v6Index = rdmNum;
                        break;
                    case "Villager 7":
                        v7Index = rdmNum;
                        break;
                    case "Villager 8":
                        v8Index = rdmNum;
                        break;
                    case "Villager 9":
                        v9Index = rdmNum;
                        break;
                }
            }
        }

        public void initialiseRoles()
        {
            //defining the actual roles that go into arrRoles
            Role King = new Role("King", "Palace");
            Role BG1 = new Role("Bodyguard", "Palace");
            Role BG2 = new Role("Bodyguard", "Palace");
            Role Villager1 = new Role("Villager", "Palace");
            Role Villager2 = new Role("Villager", "Palace");
            Role Villager3 = new Role("Villager", "Palace");
            Role Villager4 = new Role("Villager", "Palace");
            Role Villager5 = new Role("Villager", "Palace");
            Role Villager6 = new Role("Villager", "Palace");
            Role Villager7 = new Role("Villager", "Palace");
            Role Villager8 = new Role("Villager", "Palace");
            Role Villager9 = new Role("Villager", "Assassin");
            Role Assassin = new Role("Assassin", "Assassin");
            //attributing roles to arrRoles based on index variables
            arrRoles[kingIndex] = King;
            arrRoles[bg1Index] = BG1;
            arrRoles[bg2Index] = BG2;
            arrRoles[v1Index] = Villager1;
            arrRoles[v2Index] = Villager2;
            arrRoles[v3Index] = Villager3;
            arrRoles[v4Index] = Villager4;
            arrRoles[v5Index] = Villager5;
            arrRoles[v6Index] = Villager6;
            arrRoles[v7Index] = Villager7;
            arrRoles[v8Index] = Villager8;
            arrRoles[v9Index] = Villager9;
            arrRoles[assassinIndex] = Assassin;
        }
    }
    
    class Role
    {
        private string roleName;
        private bool aliveStatus;//Whether or not the player with this role is alive or not
        private string faction;//The 'team' that the role belongs to

        public string getRole() { return roleName; } //roleName's getter
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
