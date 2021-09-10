namespace BattleSnake.Models
{
    public class Squad
    {
        public bool allowBodyCollisions { get; set; }
        public bool sharedElimination { get; set; }
        public bool sharedHealth { get; set; }
        public bool sharedLength { get; set; }
    }
}