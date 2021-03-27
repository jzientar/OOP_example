namespace OOP_example
{
    public class Shooter : Game, IClassGame
    {
        private string gameStatus;
        public string name;
        public string _type;
        public string client;
        public int players;
        public int year;
        public string gameType;


        public Shooter(int _players)
        {
            name = "Doom Eternal";
            _type = "FPS";
            client = "Bethesda Network";
            players = _players;
            year = 2020;
            gameType = "";
        }

        public void soloPlay()
        {
            gameStatus = "The game is running.";
            players = 1;
            gameType = "Campaign";
        }

        public void stopGame()
        {
            gameStatus = "The game is stopped.";
            players = 0;
            gameType = "none";
        }

        public void connect()
        {
            gameStatus = "The game is connected to the Bethesda Network.";
        }   

        public void disconnect() 
        {
            gameStatus = "The game is disconnected from the Bethesda Network.";
        }
        public string getClient()
        {
            return this.client;
        }
        public string getType()
        {
            return this._type;
        }
        public int releaseYear()
        {
            return this.year; 
        }
        public int playerNumber()
        {
            return this.players;
        }    
    }
    
}