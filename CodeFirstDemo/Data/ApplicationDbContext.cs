using Microsoft.EntityFrameworkCore;
using CodeFirstDemo.Models;
namespace CodeFirstDemo.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op):base(op) 
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
