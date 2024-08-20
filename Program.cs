namespace YahtzeeGame
{
    internal class Program
    {
        static void Main()
        {
            PlayerTurn();
        }



        static void RunProgram()
        {
            int roundCounter = 0;
            const int TotalRounds = 13;
            Player playerOne = new Player();


            while (roundCounter >= TotalRounds)
            {
                for(int i = 0; i <= TotalRounds; i++)
                {



                }
                roundCounter++;
            }
        }

        public static void PlayerTurn()
        {
            int[] playerHand = new int[5];
            GetNewHand(playerHand);
            DisplayHand(playerHand);
            int turnCounter = 0;
            const int TotalTurns = 3;

            

            for (int i = 0; i <= TotalTurns; i++)
            {


                turnCounter++;
            }
        }



        public static int[] GetNewHand(int[] playerHand)
        {
            Dice dice = new Dice();

            int playerHandLength = playerHand.Length;

            for (int i = 0; i < playerHandLength; i++)
            {
                playerHand[i] = dice.Roll();
            }
            Array.Sort(playerHand);
            return playerHand;
        }



        public static void DisplayHand(int[] playerHand)
        {
            string commaSeparated =  "";
            foreach (int value in playerHand)
            {
                commaSeparated += value + ", ";
            }
            commaSeparated = commaSeparated.TrimEnd(',', ' ');
            Console.WriteLine(commaSeparated);
        }



        public static void RerollDice()
        {



        }



        public static (string, int) CheckMatchingAces(int[] playerHand)
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
            if (acesSum != 0)
            {
                return ("Aces", acesSum);
            } 
            return ("NoDice", acesSum);
        }


        public static (string, int) CheckMatchingTwos(int[] playerHand)
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

            if (TwosSum != 0)
            {
                return ("Twos", TwosSum);
            }
            return ("NoDice", TwosSum);
        }



        public static (string, int) CheckMatchingThrees(int[] playerHand)
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

            if (threesSum != 0)
            {
                return ("Threes", threesSum);
            }
            return ("NoDice", threesSum);
        }



        public static (string, int) CheckMatchingFours(int[] playerHand)
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

            if (foursSum != 0)
            {
                return ("Fours", foursSum);
            }
            return ("NoDice", foursSum);
        }



        public static (string, int) CheckMatchingFives(int[] playerHand)
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

            if (fivesSum != 0)
            {
                return ("Fives", fivesSum);
            }
            return ("NoDice", fivesSum);
        }




        public static (string, int) CheckMatchingSixes(int[] playerHand)
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

            if (sixesSum != 0)
            {
                return ("Sixes", sixesSum);
            }
            return ("NoDice", sixesSum);
        }



        public static (string, int) UseChance(int[] playerHand)
        {
            int playerHandLength = playerHand.Length;
            int chanceSum = 0;

            for (int i = 0; i < playerHandLength; i++)
            {
                chanceSum += playerHand[i];
            }
            return ("Chance", chanceSum);
        }



        public static (string, int) ThreeOfAKind(int[] playerHand)
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
            if (threeOfAKindSum != 0)
            {
                return ("ThreeOfAKind", threeOfAKindSum);
            }
            return ("NoDice", threeOfAKindSum);
        }



        public static (string, int) FourOfAKind(int[] playerHand)
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
            if (fourOfAKindSum != 0)
            {
                return ("FourOfAKind", fourOfAKindSum);
            }
            return ("NoDice", fourOfAKindSum);
        }



        public static (string, int) FullHouse(int[] playerHand)
        {
            int firstValue = playerHand[0];
            int secondValue = playerHand[1];
            int thirdValue = playerHand[2];
            int fourthValue = playerHand[3];
            int fifthValue = playerHand[4];
            bool threeMatching = false;
            bool twoMatching = false;

            if ((firstValue == secondValue && secondValue == thirdValue && firstValue != fourthValue) 
                || 
                thirdValue == fourthValue && fourthValue == fifthValue && thirdValue != secondValue)
            {
                threeMatching = true;
            }
            if ((firstValue == secondValue && firstValue != thirdValue) || fourthValue == fifthValue && fourthValue != thirdValue)
            {
                twoMatching = true;
            }
            if (twoMatching && threeMatching)
            {
                return ("FullHouse", 25);
            }
            return ("NoDice", 0);
        }



        public static (string, int) SmallStraight(int[] playerHand)
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
                    return ("SmallStraight", 30);
                }
            }
            return ("NoDice", 0);
        }



        public static (string, int) LargeStraight(int[] playerHand)
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
                    return ("LargeStraight", 40);
                }
            }
            return ("NoDice", 0);
        }



        public static (string, int) Yahtzee(int[] playerHand)
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
                return ("Yahtzee", 50);
            }
            return ("NoDice", 0);
        }



        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }
}


