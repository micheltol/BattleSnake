namespace BattleSnake.Models
{
    public class Request
    {
        public Game game { get; set; }
        public int turn { get; set; }
        public Board board { get; set; }
        public Battlesnake you { get; set; }

    }
}
