namespace YahtzeeGame
{
    internal class Player
    {
        public int UpperSection { get; set; }
        public int Aces { get; set; }
        public int Twos { get; set; }
        public int Threes { get; set; }
        public int Fours { get; set; }
        public int Fives { get; set; }
        public int Sixes { get; set; }
        public int LowerSection { get; set; }
        public int Chance { get; set; }
        public int ThreeOfAKind { get; set; }
        public int FourOfAKind { get; set; }
        public int FullHouse { get; set; }
        public int SmallStraight { get; set; }
        public int LargeStraight { get; set; }
        public int Yahtzee { get; set; }
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


        public void UpdateScore(string scoreCategory, int score)
        {
            switch (scoreCategory)
            {
                case "Aces":
                    Aces = score;
                    break;

                case "Twos":
                    Twos = score;
                    break;

                case "Threes":
                    Threes = score;
                    break;

                case "Fours":
                    Fours = score;
                    break;

                case "Fives":
                    Fives = score;
                    break;

                case "Sixes":
                    Sixes = score;
                    break;

                case "Chance":
                    Chance = score;
                    break;

                case "ThreeOfAKind":
                    ThreeOfAKind = score;
                    break;

                case "FourOfAKind":
                    FourOfAKind = score;
                    break;

                case "FullHouse":
                    FullHouse = score;
                    break;

                case "SmallStraight":
                    SmallStraight = score;
                    break;

                case "LargeStraight":
                    LargeStraight = score;
                    break;

                case "Yahtzee":
                    Yahtzee = score;
                    break;

                case "NoDice":
                    break;

                default:
                    throw new ArgumentException("Invalid score category, ", nameof(scoreCategory));
                          
            }
            TotalSumScore();
        }



        public void TotalSumScore()
        {
            UpperSectionScore();
            LowerSectionScore();
            TotalScore += UpperSection + LowerSection;
        }


        public void UpperSectionScore()
        {
            const int Bonus = 35;

            UpperSection += Aces + Twos + Threes + Fours + Fives + Sixes;
            if (UpperSection >= 63)
            {
                UpperSection += Bonus;
            }
        }



        public void LowerSectionScore()
        {
            LowerSection += Chance + ThreeOfAKind + FourOfAKind + FullHouse + SmallStraight + LargeStraight + Yahtzee;
        }


    }
}
