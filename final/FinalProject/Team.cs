
namespace PickleballTracker
{
    public class Team
    {
        private Player partner1;
        private Player partner2;

        public Team(Player p1, Player p2)
        {
            partner1 = p1;
            partner2 = p2;
        }

        public Player GetPartner1()
        { 
            return partner1;
        }
        public Player GetPartner2() 
        { 
            return partner2; 
        }

        public bool HasPlayer(Player p)
        {
            return partner1 == p || partner2 == p;
        }

        public string GetTeamName()
        {
            return partner1.GetName() + " & " + partner2.GetName();
        }
    }
}
