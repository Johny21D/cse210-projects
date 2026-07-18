using System.Collections.Generic;

namespace PickleballTracker
{
    public class DoublesMatch : Match
    {
        private Team _team1;
        private Team _team2;

        public DoublesMatch(string date, Score score, Team t1, Team t2)
            : base(date, score)
        {
            _team1 = t1;
            _team2 = t2;
        }

        public override List<Player> GetWinners()
        {
            List<Player> winners = new List<Player>();
            int side = GetScore().GetWinningSide();
            if (side == 1)
            {
                winners.Add(_team1.GetPartner1());
                winners.Add(_team1.GetPartner2());
            }
            else if (side == 2)
            {
                winners.Add(_team2.GetPartner1());
                winners.Add(_team2.GetPartner2());
            }
            return winners;
        }

        public override List<Player> GetParticipants()
        {
            return new List<Player>
            {
                _team1.GetPartner1(), _team1.GetPartner2(),
                _team2.GetPartner1(), _team2.GetPartner2()
            };
        }

        public override bool AreOpponents(Player a, Player b)
        {
            return (_team1.HasPlayer(a) && _team2.HasPlayer(b)) ||
                   (_team2.HasPlayer(a) && _team1.HasPlayer(b));
        }

        public override string GetSummary()
        {
            string result = "[Doubles " + GetDate() + "] "
                + _team1.GetTeamName() + " vs " + _team2.GetTeamName()
                + "  (" + GetScore() + ")";
            int side = GetScore().GetWinningSide();
            if (side == 1) result += "  Winner: " + _team1.GetTeamName();
            else if (side == 2) result += "  Winner: " + _team2.GetTeamName();
            else result += "  Tie";
            return result;
        }
    }
}