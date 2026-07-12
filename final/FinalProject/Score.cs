namespace PickleballTracker
{
    public class Score
    {
        private int score1;
        private int score2;

        public Score(int s1, int s2)
        {
            score1 = s1;
            score2 = s2;
        }

        public int GetScore1() { return score1; }
        public int GetScore2() { return score2; }

        public int GetWinningSide()
        {
            if (score1 > score2) return 1;
            if (score2 > score1) return 2;
            return 0;
        }

        public override string ToString()
        {
            return score1 + " - " + score2;
        }
    }
}