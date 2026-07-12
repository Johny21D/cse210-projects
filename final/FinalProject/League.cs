using System.Collections.Generic;

namespace PickleballTracker
{
    public class League
    {
        private List<Player> players = new List<Player>();
        private List<Match> matches = new List<Match>();
        private int nextId = 1;

        public Player AddPlayer(string name)
        {
            if (FindPlayer(name) != null) 
                return null;
            Player p = new Player(name, nextId++);
            players.Add(p);
            return p;
        }

        public Player FindPlayer(string name)
        {
            foreach (Player p in players)
            {
                if (p.GetName() == name) 
                    return p;
            }
            return null;
        }

        public void RecordMatch(Match m) { matches.Add(m); }

        public List<Player> GetPlayers() 
        { 
            return players; 
            }
        public List<Match> GetMatches() 
        { 
            return matches;
        }
    }
}