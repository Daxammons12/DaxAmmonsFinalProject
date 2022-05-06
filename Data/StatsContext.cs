using Microsoft.EntityFrameworkCore;
using DaxAmmonsFinalProject.Models;

namespace DaxAmmonsFinalProject.Data
{
    public class StatsContext : DbContext
{
    public StatsContext(DbContextOptions<StatsContext> options)
        : base(options)
    {
    }
    public DbSet<Stats> Stats{get;set;}
}


}