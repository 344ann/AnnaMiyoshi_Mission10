using Microsoft.EntityFrameworkCore;

namespace AnnaMiyoshi_Mission10.Data;

public class BowlerDbContext : DbContext
{
    // Constructor that takes database options and passes them to the base DbContext
    public BowlerDbContext(DbContextOptions<BowlerDbContext> options) : base(options)
    {
    }
    
    // Define a table for Bowlers
    public DbSet<Bowler> Bowlers { get; set; }
    
    // Define a table for Teams
    public DbSet<Team> Teams { get; set; }
}

//what table looks like