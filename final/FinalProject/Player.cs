namespace PickleballTracker
{
    public class Player
    {
        private string _name;
        private int _playerId;

        public Player(string playerName, int id)
        {
            _name = playerName;
            _playerId = id;
        }

        public string GetName() 
        { 
            return _name; 
        }
        public int GetId() 
        { 
            return _playerId; 
        }
    }
}