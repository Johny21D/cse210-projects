using System.Collections.Generic;

namespace PickleballTracker
{
    public class DoublesMatch : Match
    {
        private Team team1;
        private Team team2;

        public DoublesMatch(string date, Score score, Team t1, Team t2)
            : base(date, score)
        {
        }

        public override List<Player> GetWinners()
        {
            return new List<Player>();
        }

        public override List<Player> GetParticipants()
        {
            return new List<Player>();
        }

        public override bool AreOpponents(Player a, Player b)
        {
            return false;
        }

        public override string GetSummary()
        {
            return "";
        }
    }
}