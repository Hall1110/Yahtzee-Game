namespace YahtzeeGame
{
    internal class Program
    {



        static void Main()
        {

            RunProgram();

        }

        private static Player playerOne = new Player();

        static void RunProgram()
        {
            int[] playerOneHand = new int[5];
            int roundCounter = 0;
            const int TotalRounds = 13;
            (string, int) result = ("", 0);

            for (int i = 0; i <= TotalRounds; i++)
            {
                Console.WriteLine($"Playing round {roundCounter} out of 13");

                PlayerTurn(playerOneHand);

                Console.Clear();
                Console.WriteLine("Player, which score would you like to input?");
                Console.Write("Your hand ");
                DisplayHand(playerOneHand);
                Console.WriteLine("\n");
                playerOne.DisplayScoreboard();


                result = CheckValidInput(playerOneHand);


                playerOne.UpdateScore(result);
                Console.Clear();
                playerOne.DisplayScoreboard();
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadLine();
                Console.Clear();
                roundCounter++;
            }

        }



        public static void PlayerTurn(int[] playerHand)
        {
            GetNewHand(playerHand);
            int turnCounter = 0;
            const int TotalTurns = 3;
            bool endTurnEarly = false;
            string currentInput = "";

            while (!endTurnEarly && turnCounter < TotalTurns)
            {
                Console.WriteLine($"Playing turn {turnCounter + 1} out of 3\n");
                Console.WriteLine("Your current hand is ");
                DisplayHand(playerHand);
                Console.WriteLine("");
                playerOne.DisplayScoreboard();
                Console.WriteLine("\nWhat action would you like to take?\n");
                Console.WriteLine("Type end turn to end turn early.");
                Console.WriteLine("Type reroll to reroll your dice.\n");
                currentInput = Console.ReadLine().ToLower();

                switch (currentInput)
                {
                    case "reroll":
                        RerollDice(playerHand);
                        turnCounter++;
                        Console.Clear();
                        continue;

                    case "end turn":
                        endTurnEarly = true;
                        break;

                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;
                }
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
            string commaSeparated = "";
            foreach (int value in playerHand)
            {
                commaSeparated += value + ", ";
            }
            commaSeparated = commaSeparated.TrimEnd(',', ' ');
            Console.WriteLine(commaSeparated);
        }



        public static int[] RerollDice(int[] playerHand)
        {
            Dice dice = new Dice();
            int playerHandLength = playerHand.Length;
            string currentInput = "";

            for (int i = 0; i < playerHandLength; i++)
            {
                Console.Clear();
                DisplayHand(playerHand);
                Console.WriteLine($"You have {playerHand[i]}");
                Console.WriteLine("\nReroll dice y/n");
                currentInput = Console.ReadLine().ToLower();

                switch (currentInput)
                {
                    case "y":
                        playerHand[i] = dice.Roll();
                        Console.WriteLine($"You got {playerHand[i]}\n");
                        continue;

                    case "n":
                        Console.WriteLine($"Keeping {playerHand[i]}\n");
                        continue;

                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        continue;
                }
            }
            Array.Sort(playerHand);
            return playerHand;
        }



        public static (string, int) CheckValidInput(int[] playerHand)
        {
            string currentInput = "";
            (string, int) result = ("", 0);
            bool reEvaluteValidInput = true;

            do
            {
                currentInput = Console.ReadLine();
                switch (currentInput)
                {
                    case "aces":
                        result = CheckMatchingAces(playerHand);
                        if (result == ("Invalid", 0) || result == ("", 0))
                        {
                            reEvaluteValidInput = false;
                        }
                        else
                        {
                            reEvaluteValidInput = true;
                        }
                        break;

                    case "twos":
                        result = CheckMatchingTwos(playerHand);
                        if (result == ("Invalid", 0) || result == ("", 0))
                        {
                            reEvaluteValidInput = false;
                        }
                        else
                        {
                            reEvaluteValidInput = true;
                        }
                        break;

                    case "threes":
                        result = CheckMatchingThrees(playerHand);
                        if (result == ("Invalid", 0) || result == ("", 0))
                        {
                            reEvaluteValidInput = false;
                        }
                        else
                        {
                            reEvaluteValidInput = true;
                        }
                        break;

                    case "fours":
                        result = CheckMatchingFours(playerHand);
                        if (result == ("Invalid", 0) || result == ("", 0))
                        {
                            reEvaluteValidInput = false;
                        }
                        else
                        {
                            reEvaluteValidInput = true;
                        }
                        break;

                    case "fives":
                        result = CheckMatchingFives(playerHand);
                        if (result == ("Invalid", 0) || result == ("", 0))
                        {
                            reEvaluteValidInput = false;
                        }
                        else
                        {
                            reEvaluteValidInput = true;
                        }
                        break;

                    case "sixes":
                        result = CheckMatchingSixes(playerHand);
                        if (result == ("Invalid", 0) || result == ("", 0))
                        {
                            reEvaluteValidInput = false;
                        }
                        else
                        {
                            reEvaluteValidInput = true;
                        }
                        break;

                    case "chance":
                        result = UseChance(playerHand);
                        if (result == ("Invalid", 0) || result == ("", 0))
                        {
                            reEvaluteValidInput = false;
                        }
                        else
                        {
                            reEvaluteValidInput = true;
                        }
                        break;

                    case "full house":
                        result = FullHouse(playerHand);
                        if (result == ("Invalid", 0) || result == ("", 0))
                        {
                            reEvaluteValidInput = false;
                        }
                        else
                        {
                            reEvaluteValidInput = true;
                        }
                        break;

                    case "three of a kind":
                        result = ThreeOfAKind(playerHand);
                        if (result == ("Invalid", 0) || result == ("", 0))
                        {
                            reEvaluteValidInput = false;
                        }
                        else
                        {
                            reEvaluteValidInput = true;
                        }
                        break;

                    case "four of a kind":
                        result = FourOfAKind(playerHand);
                        if (result == ("Invalid", 0) || result == ("", 0))
                        {
                            reEvaluteValidInput = false;
                        }
                        else
                        {
                            reEvaluteValidInput = true;
                        }
                        break;

                    case "small straight":
                        result = SmallStraight(playerHand);
                        if (result == ("Invalid", 0) || result == ("", 0))
                        {
                            reEvaluteValidInput = false;
                        }
                        else
                        {
                            reEvaluteValidInput = true;
                        }
                        break;

                    case "large straight":
                        result = LargeStraight(playerHand);
                        if (result == ("Invalid", 0) || result == ("", 0))
                        {
                            reEvaluteValidInput = false;
                        }
                        else
                        {
                            reEvaluteValidInput = true;
                        }
                        break;

                    case "yahtzee":
                        result = Yahtzee(playerHand);
                        if (result == ("Invalid", 0) || result == ("", 0))
                        {
                            reEvaluteValidInput = false;
                        }
                        else
                        {
                            reEvaluteValidInput = true;
                        }
                        break;

                    case "skip":
                        result = ("NoDice", 0);
                        break;

                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        if (result == ("Invalid", 0) || result == ("", 0))
                        {
                            reEvaluteValidInput = false;
                        }
                        else
                        {
                            reEvaluteValidInput = true;
                        }
                        break;
                }
                if (!reEvaluteValidInput)
                {
                    Console.WriteLine("No match in your selected category, try another one, or type skip.");
                }
            } while (!reEvaluteValidInput);
            return result;
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
            if (acesAmount > 0)
            {
                return ("Aces", acesSum);
            }
            return ("Invalid", 0);
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

            if (TwosAmount > 0)
            {
                return ("Twos", TwosSum);
            }
            return ("Invalid", 0);
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

            if (threesAmount > 0)
            {
                return ("Threes", threesSum);
            }
            return ("Invalid", 0);
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

            if (foursAmount > 0)
            {
                return ("Fours", foursSum);
            }
            return ("Invalid", 0);
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

            if (fivesAmount > 0)
            {
                return ("Fives", fivesSum);
            }
            return ("Invalid", 0);
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
            if (sixesAmount > 0)
            {
                return ("Sixes", sixesSum);
            }
            return ("Invalid", 0);
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
            return ("Invalid", 0);
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
            return ("Invalid", 0);
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
            return ("Invalid", 0);
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
            return ("Invalid", 0);
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
            return ("Invalid", 0);
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
            return ("Invalid", 0);
        }



        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        } // aldrig brugt
    }
}