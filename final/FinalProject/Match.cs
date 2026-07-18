using System.Collections.Generic;

namespace PickleballTracker
{
    public abstract class Match
    {
        private string _date;
        private Score _score;

        protected Match(string matchDate, Score matchScore)
        {
            _date = matchDate;
            _score = matchScore;
        }

        public string GetDate() { return _date; }
        public Score GetScore() { return _score; }

        public abstract List<Player> GetWinners();
        public abstract List<Player> GetParticipants();
        public abstract bool AreOpponents(Player a, Player b);
        public abstract string GetSummary();
    }
}