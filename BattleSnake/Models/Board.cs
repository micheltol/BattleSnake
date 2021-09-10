namespace BattleSnake.Models
{
    public class Board
    {
        public int height { get; set; }
        public int width { get; set; }
        public Food[] food { get; set; }
        public Hazard[] hazards { get; set; }
        public Battlesnake[] snakes { get; set; }
    }
}