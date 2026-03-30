using Person.Models;
using Microsoft.EntityFrameworkCore;
namespace Person.Data;
public class PersonContext : DbContext
{
    public PersonContext(DbContextOptions options) : base(options){}
    public DbSet<ConcretePerson> ConcretePerson {get; set;}
    public DbSet<Hamster> Hamsters {get; set;}
    public DbSet<Group> Group {get; set;}
    public DbSet<SpottedAt> SpottedAts {get; set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ConcretePerson>().HasMany(e => e.spottedAt).WithMany(e => e.People);
    }
}