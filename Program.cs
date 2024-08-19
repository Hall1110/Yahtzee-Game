namespace YahtzeeGame
{
    internal class Program
    {
        static void Main()
        {
            
        }

/*
REGLER
13 runder
hver spiller ruller terninger 3 gange, med mulighed for at slutte sin runde før 3. gang
spiller skal kunne gemme terninger (muligvis re-roll terninger, senere implementering)

SCORECARD
Upper Scorecard!
1'ere, 2'ere etc. mindst 2 ens, scoren er summen af tallene
bonus for upper scorecard er en sum på mindst 63 eller mere
tag sum af uppercard

Lower Scorecard!
Chance: summen af en combination af dice
3 ens, 4 ens. mindst tre/fire ens, scoren er summen af de matchende dice
full house. 3 ens af et tal, 2 ens af et andet tal scoren er 25
small straight. 1-4, 2-5, 3-6. score er 30
large straight. 1-5, 2-6. Score er 40
yahtzee. alle dice er ens. Score er 50
tag summen af lower card
*/

        static void RunProgram()
        {
            int roundCounter = 0;
            const int TotalRounds = 13;
            int turnCounter = 0;
            const int TotalTurns = 3;

            Player playerOne = new Player();
            int[] playerOneHand = new int[5];

            Player playerTwo = new Player();
            int[] playerTwoHand = new int[5];


            while (roundCounter >= TotalRounds)
            {
                


                roundCounter++;
            }
        }


        
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }



        public static void PlayerTurn(int[] playerHand)
        {
            Dice dice = new Dice();
            int playerHandLength = playerHand.Length;

            for (int i = 0; i < playerHandLength; i++)
            {
                playerHand[i] = dice.Roll();
            }
        }



        public static void CheckHand(int[] playerHand)
        {
            Array.Sort(playerHand);
            int playerHandLength = playerHand.Length;

            /*
            Check matching 
            */
        }



        public static void CheckMatching(int[] playerHand)
        {
            int playerHandLength = playerHand.Length;
            int matchingNumbersCounter = 0;
            

            for (int i = 1; i < playerHandLength; i++)
            {
                if (playerHand[i] == playerHand[i - 1])
                {
                    matchingNumbersCounter++;
                }
                else
                {
                    continue;
                }
            }
            
            for (int i = 0; i < matchingNumbersCounter; i++)
            {

            }
        }
    }
}


