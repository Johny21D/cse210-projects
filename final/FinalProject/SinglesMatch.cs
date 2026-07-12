using System.Collections.Generic;

namespace PickleballTracker
{
    public class SinglesMatch : Match
    {
        private Player player1;
        private Player player2;

        public SinglesMatch(string date, Score score, Player p1, Player p2)
            : base(date, score)
        {
            player1 = p1;
            player2 = p2;
        }

        public override List<Player> GetWinners()
        {
            List<Player> winners = new List<Player>();
            int side = GetScore().GetWinningSide();
            if (side == 1) 
                winners.Add(player1);
            else if (side == 2) 
                winners.Add(player2);
                return winners;
        }

        public override List<Player> GetParticipants()
        {
            return new List<Player> { player1, player2 };
        }

        public override bool AreOpponents(Player a, Player b)
        {
            return (a == player1 && b == player2) ||
                   (a == player2 && b == player1);
        }

        public override string GetSummary()
        {
            string result = "[Singles " + GetDate() + "] "+ player1.GetName() + " vs " + player2.GetName()+ "  (" + GetScore() + ")";
            int side = GetScore().GetWinningSide();
            if (side == 1) 
                result += "  Winner: " + player1.GetName();
            else if (side == 2) 
                result += "  Winner: " + player2.GetName();
            else 
                result += "  Tie";
                return result;
        }
    }
}