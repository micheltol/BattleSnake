namespace BattleSnake.Models
{
    public class Game
    {
        public string id { get; set; }
        public Ruleset ruleset { get; set; }
        public int timeout { get; set; }
    }
}
