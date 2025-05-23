using ChampionsApi.Entities;

namespace ChampionsApi.Graphql
{
    public class Query
    {
        public IQueryable<Player> GetPlayers([Service] ChampionsContext context) => context.Players;

        public IQueryable<Match> GetMatches([Service] ChampionsContext context) => context.Matches;

        [UseProjection]
        public IQueryable<PlayerStat> GetPlayerStats([Service] ChampionsContext context) =>
            context.PlayerStats;
    }
}
