using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeceptionPalace
{
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
    class Game
    {

        private static mainGameForm gameObj = Application.OpenForms.OfType<mainGameForm>().FirstOrDefault();//link to the form the class operates in
        private string code;//for future iterations, holds the 4 letter code to reference a game
        private string[] arrPlayers = new string[12];//array of players' usernames in order to match their corresponding role in arrRoles
        private Role[] arrRoles = new Role[12];//array of the corresponding roles in index positions to arrPlayers
        private int[,] arrStats = new int[2, 2];//for future iterations holds the stat changes to be processed in gameEnd
        private System.Drawing.Bitmap[,] arrSprites = new System.Drawing.Bitmap[2, 12];//for future iterations holds corresponding player's sprite preference
        private int[] arrVotes = new int[9];//array of preliminary votes that holds how many players each round think a corresponding player should be executed
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
        private Form mainGameForm;//the form which games occur in
        private bool kingSpecialDone;//boolean that tells whether kingSpecialAbility() has been run
        private bool dayStage;//boolean that holds true when its the day stage and false when its the night stage
        private int playerCounter;//integer used to cycle through player indexes 
        private bool prelimDone;//boolean that tells whether or not all the preliminary votes of a round have been done

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

        //below method returns the faction the player belongs to
        public string getFac(int playerIndex)
        {
            return arrRoles[playerIndex].getFaction();
        }

        public System.Drawing.Bitmap getSprite(int playerIndex, int aliveStatusIndex) { return arrSprites[aliveStatusIndex, playerIndex]; }
        //above method returns the sprite in arrSprites of the player and alive status referenced referenced 
        public string getPlayer(int playerIndex) { return arrPlayers[playerIndex]; }
        //above method returns the username of the player at index playerIndex

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
            kingSpecialDone = false;
            WININDEX = 0;//this variable and the 4 below are category index constants for arrStats/Sprites
            LOSTINDEX = 1;
            ALIVEINDEX = 0;
            DEADINDEX = 1;
            playerCounter = 0;

            for (int k = 0; k < 9; k++)
            {       //for loop initialises contents of arrSprites until customisability enabled
                arrSprites[ALIVEINDEX, k] = Properties.Resources.pinkWomanAlive;
                arrSprites[DEADINDEX, k] = Properties.Resources.pinkWomanDead;
            }
            
            code = callingCode;//useful in iteration 4 onwards
            
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
            Role fillerRole1 = new Role("notnull", "notnull");
            int rdmNum;
            string currentRole;
            Random rdm = new Random();//Random is a c# class that generates random outputs between certain arguments
            string[] optionalRoles = { "Bodyguard", "Villager 1", "Villager 2", "Villager 3", "Villager 4", "Villager 5", "Villager 6", "Villager 7", "Villager 8" };
            for (int i = 0; i < optionalRoles.Length; i++)
            {
                rdmNum = rdm.Next(0, 12);//Outputs random number between 0 and 11
                while (arrRoles[rdmNum] != null)//Validates that the random number is not already taken by another role
                {
                    rdmNum = rdm.Next(0, 12);
                }
                arrRoles[rdmNum] = fillerRole1;
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
            Role Villager8 = new Role("Villager", "Assassin");
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
            arrRoles[assassinIndex] = Assassin;
        }

        public void gameloop()
        {
            updateEventText("You are " + arrPlayers[kingIndex] +
                ", and you are the King. Choose a role not in play to check.");
            //If you can't solve this problem, just change eventTextbox's protection level to public
            //PERHAPS IMPLEMENT GAMELOOP AS AN EVENT FOR LOADING UP THE FORM
            //scrap that :(
        }

        public void kingSpecialAbility(int chosenRole)
        {
            string numberNotPlayed;//string to be used in a sentence in eventTextbox
            if (chosenRole == 9) { numberNotPlayed = "first"; }//this if statement simply helps construct the output sentence to eventTextbox
            else if (chosenRole == 10) { numberNotPlayed = "second"; }
            else { numberNotPlayed = "third"; }
            updateEventText("The " + numberNotPlayed + " role not in play is a " + arrRoles[chosenRole].getRole() + ".");
            kingSpecialDone = true;//now multitalentSwitch can be completed in button handlers
        }
        //processes the input of the multitalent by identifying the right parameters for processSwitch()
        public void multitalentSwitch(int indxInt){
            switch(arrRoles[indxInt].getRole()){//identify which role chosen
                case "Bodyguard"://chosen role identified as Bodyguard
                    processSwitch(bg2Index);//multitalent & bodyguard switch
                case "Villager 1"://chosen role identified as Villager 1
                    processSwitch(v1Index);//multitalent & villager 1 switch
                case "Villager 2"://chosen role identified as Villager 2
                    processSwitch(v2Index);//multitalent & villager 2 switch
                case "Villager 3"://chosen role identified as Villager 3
                    processSwitch(v3Index);//multitalent & villager 3 switch
                case "Villager 4"://chosen role identified as Villager 4
                    processSwitch(v4Index);//multitalent & villager 4 switch
                case "Villager 5"://chosen role identified as Villager 5
                    processSwitch(v5Index);//multitalent & villager 5 switch
                case "Villager 6"://chosen role identified as Villager 6
                    processSwitch(v6Index);//multitalent & villager 6 switch
                case "Villager 7"://chosen role identified as Villager 7
                    processSwitch(v7Index);//multitalent & villager 7 switch
                case "Villager 8"://chosen role identified as Villager 8
                    processSwitch(v8Index);//multitalent & villager 8 switch
            }
        }
        //below method processes role switches for multitalentSwitch()
        public void processSwitch(int switchWith){
            int temp = multitalentIndex;//temporary variable for lossless switch
            multitalentIndex = switchWith;//multitalentIndex now ‘moved’
        	switchWith = temp;//chosen role’s index now ‘moved’
        	Role tempRole = arrRoles[switchWith];//temp object for lossless switch
        	arrRoles[switchWith] = arrRoles[multitalentIndex];//chosen role switched
        	arrRoles[multitalentIndex] = tempRole;//mutltitalent switched
        }
        
        public void night()
        {
            dayStage = false;//no longer the day. Useful for the button handlers for target buttons
            if (playerCounter <= 8){//some players might still need to input their targets
                string playerRole;
                playerRole = this.arrRoles[playerCounter].getRole();
                //below if statement validates whether or not the player should be allowed to input a target or not
                if ((playerRole == "Assassin" || playerRole == "Sentinel" || playerRole == "Chemist" || playerRole == "Blocker") 
                                                                                                && arrRoles[playerCounter].getAlive()){
                    //button handlers handle inputs
                    updateEventText("You are " + arrPlayers[playerCounter] + ", the " + playerRole + ". Choose your target.");
                }else
                {//either the player has no ability or is dead - can't input a target
                    playerCounter++;//moves onto the next player
                    night();//recurses to see if this new player index is a valid player to input a target
                }
            }
            else
            {//all players have input their targets
                playerCounter = 0;//resets playerCounter for its next use in prelimVote()
                processAbilities();
                day();//moves to next stage of the game
            }
        }

        public void day()
        {
            dayStage = true;//is now day, allows button handlers to process day inputs correctly
            checkNewDeaths();//updates aliveList and deadList, and outputs the deaths that have occurred
            checkWinConditions();//updates winMet to true if any win condition has been met
            if (!winMet)
            {//validates that no win conditions have been met so the game should continue
                updateEventText("Please discuss your theories, and begin inputing people's preliminary votes for execution when you're ready.");
            }
            else
            {//if win condition of any faction is met, game should end
                gameEnd();//triggers post-game processes
            }
        }

        public void processTarget(int targIndex)
        {//targIndex parameter containing index of player targeted
            if (dayStage)
            {//day stage - processing either votes for execution or execution itself
                if (!prelimDone)
                {//have all the preliminary votes been input yet? - no
                    prelimVote(targIndex);//the first player is voted for
                }
                else
                {//have all the preliminary votes been input yet? - yes, proceed to executing
                    executing(targIndex);//the first player is killed
                }
            }
            else
            {//night stage - processing targetting players
                targets[playerCounter] = targIndex;//logging the player's target as the first player
                playerCounter++;//moving to next player in the night() subroutine
                night();//calling night() again
            }
        }

        public void prelimVote(int voteFor)
        {
            arrVotes[voteFor]++;//increments the votes for player specified by the button click
            playerCounter++;//playerCounter increments so rest of the subroutine prepares for the next button click
            if (playerCounter == 9)
            {//prelimVote should end
                prelimDone = true;//makes next button click trigger executing()
                playerCounter = 0;//resets playerCounter in time for the night stage
                updateEventText("You are " + arrPlayers[kingIndex] + ". Who do you want to execute?");
            }
            else
            {//continue prelimVote
                if (arrRoles[playerCounter].getAlive())
                {//alive players can vote
                    updateEventText("You are " + arrPlayers[playerCounter] + ", who do you want to vote for?");
                }
                else
                {//dead players can't vote - look for another alive player
                    do
                    {
                        playerCounter++;//looks at next player
                    } while (playerCounter > 9 && !arrRoles[playerCounter].getAlive());//stops if valid player found or no players left
                    if (playerCounter > 9)
                    {//if less than 9, it is a valid player
                        updateEventText("You are " + arrPlayers[playerCounter] + ", who do you want to vote for?");
                    }
                }
            }
        }

        public void executing(int exeTarg)
        {
            //checks if the Sentinel is alive and if the Assassin was executed
            //if (arrRoles[exeTarg].getRole() == "Assassin" && arrRoles[sentinelIndex].getAlive())
            //{
            //    //Switches the roles of the Assassin and Sentinel
            //    int temp = assassinIndex;
            //    assassinIndex = sentinelIndex;
            //    sentinelIndex = temp;
            //    Role tempRole = arrRoles[sentinelIndex];
            //    arrRoles[sentinelIndex] = arrRoles[assassinIndex];
            //    arrRoles[assassinIndex] = tempRole;
            //}
            //setting role aliveStatus attribute to false to indicate death
            arrRoles[exeTarg].setAlive(false);
            //death processing and win condition checking
            checkJesterWin(exeTarg);
            checkWinConditions();
            deadList.Append(exeTarg);
            aliveList.Remove(exeTarg);
            //output execution
            updateEventText(arrPlayers[exeTarg] + " was executed.");
            //check whether to continue game or not
            if (winMet)
            {
                gameEnd();
            }
            else
            {
                night();
            }
        }

        public static void updateEventText(string newText)//method that updates contents of eventTextbox
        { gameObj.eventTextbox.Text = newText; }
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
    
}
