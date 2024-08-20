﻿namespace YahtzeeGame
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
                acesSum += 1;
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
                TwosSum += 2;
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
                threesSum += 3;
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
                foursSum += 4;
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
                fivesSum += 5;
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
                sixesSum += 6;
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
                    break;
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
                    break;

                }
            }
            return fourOfAKindSum;
        }



        public static int FullHouse(int[] playerHand)
        {
            int firstValue = playerHand[0];
            int secondValue = playerHand[1];
            int thirdValue = playerHand[2];
            int fourthValue = playerHand[3];
            int fifthValue = playerHand[4];
            bool threeMatching = false;
            bool twoMatching = false;

            if ((firstValue == secondValue && secondValue == thirdValue) || thirdValue == fourthValue && fourthValue == fifthValue)
            {
                threeMatching = true;
            }
            if ((firstValue == secondValue) || fourthValue == fifthValue)
            {
                twoMatching = true;
            }
            if (twoMatching && threeMatching)
            {
                return 25;
            }
            return 0;
        }



        public static int SmallStraight(int[] playerHand)
        {
            int playerHandLength = playerHand.Length;

            for (int i = 3; i < playerHandLength; i++)
            {
                int firstValue = playerHand[i - 3];
                int secondValue = playerHand[i - 2];
                int thirdValue = playerHand[i - 1];
                int fourthValue = playerHand[i];

                if (firstValue == secondValue - 1 && firstValue == thirdValue - 2 && firstValue == fourthValue - 3)
                {
                    return 30;
                }
            }
            return 0;
        }



        public static int LargeStraight(int[] playerHand)
        {
            int playerHandLength = playerHand.Length;

            for (int i = 4; i < playerHandLength; i++)
            {
                int firstValue = playerHand[i - 4];
                int secondValue = playerHand[i - 3];
                int thirdValue = playerHand[i - 2];
                int fourthValue = playerHand[i - 1];
                int fifthValue = playerHand[i];


                if (firstValue == secondValue - 1 && firstValue == thirdValue - 2 && firstValue == fourthValue - 3 && firstValue == fifthValue - 4)
                {
                    return 40;
                }
            }
            return 0;
        }



        public static int Yahtzee(int[] playerHand)
        {
            int playerHandLength = playerHand.Length;
            int firstIndex = playerHand[0];
            int counter = 0;

            for (int i = 0; i < playerHandLength; i++)
            {
                if (firstIndex == playerHand[i])
                {
                    counter++;
                }
            }
            if (counter == 5)
            {
                return 50;
            }
            return 0;
        }
    }
}


