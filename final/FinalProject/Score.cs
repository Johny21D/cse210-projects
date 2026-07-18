namespace PickleballTracker
{
    public class Score
    {
        private int _score1;
        private int _score2;

        public Score(int s1, int s2)
        {
            _score1 = s1;
            _score2 = s2;
        }

        public int GetScore1() { return _score1; }
        public int GetScore2() { return _score2; }

        public int GetWinningSide()
        {
            if (_score1 > _score2) return 1;
            if (_score2 > _score1) return 2;
            return 0;
        }

        public override string ToString()
        {
            return _score1 + " - " + _score2;
        }
    }
}