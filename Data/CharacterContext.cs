using Microsoft.EntityFrameworkCore;
using DaxAmmonsFinalProject.Models;

namespace DaxAmmonsFinalProject.Data
{
    public class CharacterContext : DbContext
{
    public CharacterContext(DbContextOptions<CharacterContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
    public DbSet<Character> Characters{get;set;}
    
}


}


