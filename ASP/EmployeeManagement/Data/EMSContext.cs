using Microsoft.EntityFrameworkCore;

public class EmsDbContext : DbContext
{
    public EmsDbContext(DbContextOptions<EmsDbContext> options) : base(options)
    {

    }

    
    public DbSet<Person> Employees { get; set; }

}