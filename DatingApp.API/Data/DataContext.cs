using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
        }

        // The name we specify here as function name is used to represent the table name

        public DbSet<Value> Values { get; set; }

        
    }
}