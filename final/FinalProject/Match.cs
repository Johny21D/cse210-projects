using System.Collections.Generic;

namespace PickleballTracker
{
    public abstract class Match
    {
        private string date;
        private Score score;

        protected Match(string matchDate, Score matchScore)
        {
            date = matchDate;
            score = matchScore;
        }

        public string GetDate() 
        { 
            return date;
        }
        public Score GetScore() 
        { 
            return score; 
        }

        public abstract List<Player> GetWinners();
        public abstract List<Player> GetParticipants();
        public abstract bool AreOpponents(Player a, Player b);
        public abstract string GetSummary();
    }
}