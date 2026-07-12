namespace PickleballTracker
{
    public class Player
    {
        private string name;
        private int playerId;

        public Player(string playerName, int id)
        {
            name = playerName;
            playerId = id;
        }

        public string GetName() 
        { 
            return name; 
        }
        public int GetId() 
        { 
            return playerId; 
            }
    }
}