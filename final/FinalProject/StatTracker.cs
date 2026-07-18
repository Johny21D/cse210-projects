using System;

namespace PickleballTracker
{
    public class StatTracker
    {
        private League _league;

        public StatTracker(League theLeague)
        {
            _league = theLeague;
        }

        public int GetWins(Player p)
        {
            int wins = 0;
            foreach (Match m in _league.GetMatches())
            {
                if (m.GetWinners().Contains(p)) wins++;
            }
            return wins;
        }

        public int GetLosses(Player p)
        {
            int losses = 0;
            foreach (Match m in _league.GetMatches())
            {
                if (m.GetParticipants().Contains(p) &&!m.GetWinners().Contains(p))
                {
                    losses++;
                }
            }
            return losses;
        }

        public double GetWinPct(Player p)
        {
            int wins = GetWins(p);
            int total = wins + GetLosses(p);
            if (total == 0) return 0.0;
            return 100.0 * wins / total;
        }

        public string GetHeadToHead(Player a, Player b)
        {
            int aWins = 0, bWins = 0;
            foreach (Match m in _league.GetMatches())
            {
                if (m.AreOpponents(a, b))
                {
                    if (m.GetWinners().Contains(a)) aWins++;
                    else if (m.GetWinners().Contains(b)) bWins++;
                }
            }
            return a.GetName() + " " + aWins + " - " + bWins + " " + b.GetName();
        }

        public void PrintPlayerReport(Player p)
        {
            Console.WriteLine(p.GetName() + ": "
                + GetWins(p) + "W - " + GetLosses(p) + "L  ("
                + GetWinPct(p).ToString("F1") + "%)");
        }
    }
}