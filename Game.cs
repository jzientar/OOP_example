namespace OOP_example
{
    public abstract class Game
    {
        protected string genre;
        string publisher;
        public Game()
        {
            genre = "FPS";
            publisher = "iD Games";
        }

        protected void play(){ }
        public string state()
        {
            return "The game hasn't started yet.";
        }
        public string getPublisher()
        {
            return publisher;
        }
    }
}