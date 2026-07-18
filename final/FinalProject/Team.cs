namespace PickleballTracker
{
    public class Team
    {
        private Player _partner1;
        private Player _partner2;

        public Team(Player p1, Player p2)
        {
            _partner1 = p1;
            _partner2 = p2;
        }

        public Player GetPartner1() 
        { 
            return _partner1; 
        }
        public Player GetPartner2() 
        { return _partner2; }

        public bool HasPlayer(Player p)
        {
            return _partner1 == p || _partner2 == p;
        }

        public string GetTeamName()
        {
            return _partner1.GetName() + " & " + _partner2.GetName();
        }
    }
}