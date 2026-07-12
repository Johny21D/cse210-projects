using System;

namespace PickleballTracker
{
    public class StatTracker
    {
        private League league;

        public StatTracker(League theLeague)
        {
            league = theLeague;
        }

        public int GetWins(Player p)
        {
            return 0;
        }

        public int GetLosses(Player p)
        {
            return 0;
        }

        public double GetWinPct(Player p)
        {
            return 0.0;
        }

        public string GetHeadToHead(Player a, Player b)
        {
            return "";
        }

        public void PrintPlayerReport(Player p)
        {
            Console.WriteLine(p.GetName() );
        }
    }
}