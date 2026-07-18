using System.Collections.Generic;

namespace PickleballTracker
{
    public class SinglesMatch : Match
    {
        private Player _player1;
        private Player _player2;

        public SinglesMatch(string date, Score score, Player p1, Player p2)
            : base(date, score)
        {
            _player1 = p1;
            _player2 = p2;
        }

        public override List<Player> GetWinners()
        {
            List<Player> winners = new List<Player>();
            int side = GetScore().GetWinningSide();
            if (side == 1) winners.Add(_player1);
            else if (side == 2) winners.Add(_player2);
            return winners;
        }

        public override List<Player> GetParticipants()
        {
            return new List<Player> { _player1, _player2 };
        }

        public override bool AreOpponents(Player a, Player b)
        {
            return (a == _player1 && b == _player2) ||
                   (a == _player2 && b == _player1);
        }

        public override string GetSummary()
        {
            string result = "[Singles " + GetDate() + "] "
                + _player1.GetName() + " vs " + _player2.GetName()
                + "  (" + GetScore() + ")";
            int side = GetScore().GetWinningSide();
            if (side == 1) result += "  Winner: " + _player1.GetName();
            else if (side == 2) result += "  Winner: " + _player2.GetName();
            else result += "  Tie";
            return result;
        }
    }
}