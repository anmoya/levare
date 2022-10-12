using Levare.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Levare.Data;

public class LevareDbContext : DbContext
{


    public LevareDbContext(DbContextOptions<LevareDbContext> options) : base(options) { }

    public DbSet<Report> Reports { get; set; }
}