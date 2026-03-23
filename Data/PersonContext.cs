using Person.Models;
using Microsoft.EntityFrameworkCore;
namespace Person.Data;
public class PersonContext : DbContext
{
    public PersonContext(DbContextOptions options) : base(options){}
    public DbSet<ConcretePerson> ConcretePerson {get; set;}
    public DbSet<Group> Group {get; set;}
}