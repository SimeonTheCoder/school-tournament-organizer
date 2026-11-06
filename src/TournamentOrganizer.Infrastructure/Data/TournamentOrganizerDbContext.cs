using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TournamentOrganizer.Infrastructure.Data.Models;

namespace TournamentOrganizer.Infrastructure.Data;

public class TournamentOrganizerDbContext : IdentityDbContext<User>
{
    public TournamentOrganizerDbContext(DbContextOptions builder)
        : base(builder) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Followable> Followable {get; set;}
    public DbSet<UserFollowed> UserFollowed {get; set;}
    public DbSet<Sport> Sports {get; set;}
    public DbSet<Team> Teams {get; set;}
}
