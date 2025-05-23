using ChampionsApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChampionsApi
{
    public class ChampionsContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<PlayerStat> PlayerStats { get; set; }

        public ChampionsContext(DbContextOptions<ChampionsContext> options) : base(options) { }           

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerStat>()
                .HasOne(ps => ps.Player)
                .WithMany()
                .HasForeignKey(ps => ps.PlayerId);

            modelBuilder.Entity<PlayerStat>()
                .HasOne(ps => ps.Match)
                .WithMany()
                .HasForeignKey(ps => ps.MatchId);
        }

    }
}
