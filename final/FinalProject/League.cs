using System.Collections.Generic;

namespace PickleballTracker
{
    public class League
    {
        private List<Player> _players = new List<Player>();
        private List<Match> _matches = new List<Match>();
        private int _nextId = 1;

        public Player AddPlayer(string name)
        {
            if (FindPlayer(name) != null) return null;
            Player p = new Player(name, _nextId++);
            _players.Add(p);
            return p;
        }

        public Player FindPlayer(string name)
        {
            foreach (Player p in _players)
            {
                if (p.GetName() == name) 
                return p;
            }
            return null;
        }

        public void RecordMatch(Match m) 
        { _matches.Add(m); }

        public List<Player> GetPlayers() 
        { 
            return _players;
        }
        public List<Match> GetMatches() 
        { 
            return _matches; 
        }
    }
}