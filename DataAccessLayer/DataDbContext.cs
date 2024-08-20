using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer;

public class DataDbContext : DbContext
{
    public DataDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Activity> Activities { get; set; }
}
