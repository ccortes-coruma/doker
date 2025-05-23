using ChampionsApi.Entities;

namespace ChampionsApi.Graphql
{
    public class PlayerStatType : ObjectType<PlayerStat>
    {
        protected override void Configure(IObjectTypeDescriptor<PlayerStat> descriptor)
        {
            descriptor.Field(ps => ps.Player).UseProjection();
            descriptor.Field(ps => ps.Match).UseProjection();
        }
    }
}
