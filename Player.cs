using System.Reflection;

namespace YahtzeeGame
{
    internal class Player
    {
        public int Aces { get; set; }
        public int Twos { get; set; }
        public int Threes { get; set; }
        public int Fours { get; set; }
        public int Fives { get; set; }
        public int Sixes { get; set; }
        public int UpperSection { get; set; }
        public int Chance { get; set; }
        public int ThreeOfAKind { get; set; }
        public int FourOfAKind { get; set; }
        public int FullHouse { get; set; }
        public int SmallStraight { get; set; }
        public int LargeStraight { get; set; }
        public int Yahtzee { get; set; }
        public int LowerSection { get; set; }
        public int TotalScore { get; set; }



        public Player()
        {
            //UpperSection = 0;
            //Aces = 0;
            //Twos = 0;
            //Threes = 0;
            //Fours = 0;
            //Fives = 0;
            //Sixes = 0;
            //LowerSection = 0;
            //Chance = 0;
            //ThreeOfAKind = 0;
            //FourOfAKind = 0;
            //FullHouse = 0;
            //SmallStraight = 0;
            //LargeStraight = 0;
            //Yahtzee = 0;
            //TotalScore = 0;
        }



        public void UpdateScore((string scoreCategory, int score) scoreTuple)
        {


            switch (scoreTuple.scoreCategory)
            {
                case "Aces":
                    Aces = scoreTuple.score;
                    break;

                case "Twos":
                    Twos = scoreTuple.score;
                    break;

                case "Threes":
                    Threes = scoreTuple.score;
                    break;

                case "Fours":
                    Fours = scoreTuple.score;
                    break;

                case "Fives":
                    Fives = scoreTuple.score;
                    break;

                case "Sixes":
                    Sixes = scoreTuple.score;
                    break;

                case "Chance":
                    Chance = scoreTuple.score;
                    break;

                case "ThreeOfAKind":
                    ThreeOfAKind = scoreTuple.score;
                    break;

                case "FourOfAKind":
                    FourOfAKind = scoreTuple.score;
                    break;

                case "FullHouse":
                    FullHouse = scoreTuple.score;
                    break;

                case "SmallStraight":
                    SmallStraight = scoreTuple.score;
                    break;

                case "LargeStraight":
                    LargeStraight = scoreTuple.score;
                    break;

                case "Yahtzee":
                    Yahtzee = scoreTuple.score;
                    break;

                case "NoDice":
                    break;

                default:
                    throw new ArgumentException("Invalid score category, ", nameof(scoreTuple.scoreCategory));

            }
            TotalSumScore();
        }



        public void DisplayScoreboard()
        {
            Type type = typeof(Player);
            PropertyInfo[] scoreBoard = type.GetProperties();
            foreach (PropertyInfo property in scoreBoard)
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(this)}");
            }
        }



        public void TotalSumScore()
        {
            UpperSectionScore();
            LowerSectionScore();
            TotalScore = UpperSection + LowerSection;
        }

        public void UpperSectionScore()
        {
            const int Bonus = 35;

            UpperSection = Aces + Twos + Threes + Fours + Fives + Sixes;
            if (UpperSection >= 63)
            {
                UpperSection += Bonus;
            }
        }



        public void LowerSectionScore()
        {
            LowerSection = Chance + ThreeOfAKind + FourOfAKind + FullHouse + SmallStraight + LargeStraight + Yahtzee;
        }
    }
}
