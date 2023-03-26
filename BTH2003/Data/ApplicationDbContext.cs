using BTH2003.Models;
using Microsoft.EntityFrameworkCore;

namespace BTH2003.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}
Footer
© 2023 GitHub, Inc.