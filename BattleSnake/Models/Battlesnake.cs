namespace BattleSnake.Models
{
    public class Battlesnake
    {
        public string id { get; set; }
        public string name { get; set; }
        public int health { get; set; }
        public Body[] body { get; set; }
        public string latency { get; set; }
        public Head head { get; set; }
        public int length { get; set; }
        public string shout { get; set; }
        public string squad { get; set; }
    }
}