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



        public static int CheckMatchingAces(int[] playerHand)
        {
            int playerHandLength = playerHand.Length;
            int acesAmount = 0;
            int acesSum = 0;

            for (int i = 0; i < playerHandLength; i++)
            {
                if (playerHand[i] == 1)
                {
                    acesAmount++;
                }
            }
            for (int i = 0; i < acesAmount; i++)
            {
                acesSum =+ 1;
            }

            return acesSum;
        }


        public static int CheckMatchingTwos(int[] playerHand)
        {
            int playerHandLength = playerHand.Length;
            int TwosAmount = 0;
            int TwosSum = 0;

            for (int i = 0; i < playerHandLength; i++)
            {
                if (playerHand[i] == 2)
                {
                    TwosAmount++;
                }
            }
            for (int i = 0; i < TwosAmount; i++)
            {
                TwosSum = +1;
            }

            return TwosSum;
        }



        public static int CheckMatchingThrees(int[] playerHand)
        {
            int playerHandLength = playerHand.Length;
            int threesAmount = 0;
            int threesSum = 0;

            for (int i = 0; i < playerHandLength; i++)
            {
                if (playerHand[i] == 3)
                {
                    threesAmount++;
                }
            }
            for (int i = 0; i < threesAmount; i++)
            {
                threesSum = +1;
            }

            return threesSum;
        }



        public static int CheckMatchingFours(int[] playerHand)
        {
            int playerHandLength = playerHand.Length;
            int foursAmount = 0;
            int foursSum = 0;

            for (int i = 0; i < playerHandLength; i++)
            {
                if (playerHand[i] == 4)
                {
                    foursAmount++;
                }
            }
            for (int i = 0; i < foursAmount; i++)
            {
                foursSum = +1;
            }

            return foursSum;
        }



        public static int CheckMatchingFives(int[] playerHand)
        {
            int playerHandLength = playerHand.Length;
            int fivesAmount = 0;
            int fivesSum = 0;

            for (int i = 0; i < playerHandLength; i++)
            {
                if (playerHand[i] == 5)
                {
                    fivesAmount++;
                }
            }
            for (int i = 0; i < fivesAmount; i++)
            {
                fivesSum = +1;
            }

            return fivesSum;
        }




        public static int CheckMatchingSixes(int[] playerHand)
        {
            int playerHandLength = playerHand.Length;
            int sixesAmount = 0;
            int sixesSum = 0;

            for (int i = 0; i < playerHandLength; i++)
            {
                if (playerHand[i] == 6)
                {
                    sixesAmount++;
                }
            }
            for (int i = 0; i < sixesAmount; i++)
            {
                sixesSum = +1;
            }

            return sixesSum;
        }



        public static int UseChance(int[] playerHand)
        {
            int playerHandLength = playerHand.Length;
            int chanceSum = 0;

            for (int i = 0; i < playerHandLength; i++)
            {
                chanceSum += playerHand[i];
            }
            return chanceSum;
        }
        


        public static int ThreeOfAKind(int[] playerHand)
        {
            int playerHandLength = playerHand.Length;
            int threeOfAKindSum = 0;

            for (int i = 1; i < playerHandLength - 1; i++)
            {
                int firstValue = playerHand[i - 1];
                int secondValue = playerHand[i];
                int thirdValue = playerHand[i + 1];

                if (firstValue == secondValue && secondValue == thirdValue)
                {
                    threeOfAKindSum += firstValue + secondValue + thirdValue;
                }
            }
            return threeOfAKindSum;
        }



        public static int FourOfAKind(int[] playerHand)
        {
            int playerHandLength = playerHand.Length;
            int fourOfAKindSum = 0;

            for (int i = 2; i < playerHandLength - 1; i++)
            {
                int firstValue = playerHand[i - 2];
                int secondValue = playerHand[i - 1];
                int thirdValue = playerHand[i];
                int fourthValue = playerHand[i + 1];

                if (firstValue == secondValue && secondValue == thirdValue && thirdValue == fourthValue)
                {
                    fourOfAKindSum += firstValue + secondValue + thirdValue + fourthValue;
                }
            }
            return fourOfAKindSum;
        }



        public static int FullHouse(int[] playerHand)
        {
            bool twoMatching = false;
            bool threeMatching = false;
            int playerHandLength = playerHand.Length;
            int firstIndexedValue = playerHand[0];
            int lastIndexedValue = playerHand[4];
            

            for (int i = 2; i < playerHandLength; i++)
            {
                if ((firstIndexedValue == playerHand[i - 1] && firstIndexedValue == playerHand[i]) 
                    || 
                   lastIndexedValue == playerHand[i - 1] && lastIndexedValue == playerHand[i - 2])
                {
                    threeMatching = true;
                }
                else if ((firstIndexedValue == playerHand[i - 1]) || lastIndexedValue == playerHand[i - 1]) // skuffed
                {
                    twoMatching = true;
                }
                else
                {
                    return 0;
                }
            }

            if (twoMatching && threeMatching)
            {
            return 25;
            }
            else
            {
                return 0;
            }
        }


    }
}


