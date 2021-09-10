namespace BattleSnake.Models
{
    public class Settings
    {
        public int foodSpawnChance { get; set; }
        public int minimumFood { get; set; }
        public int hazardDamagePerTurn { get; set; }
        public Royale royale { get; set; }
        public Squad squad { get; set; }
    }
}