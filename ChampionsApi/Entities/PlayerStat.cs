namespace ChampionsApi.Entities
{
    public class PlayerStat
    {
        public int PlayerStatId { get; set; }
        public int PlayerId { get; set; }
        public int MatchId { get; set; }

        public int Goals { get; set; }
        public int Assists { get; set; }

        public Player? Player { get; set; }
        public Match? Match { get; set; }
    }
}
