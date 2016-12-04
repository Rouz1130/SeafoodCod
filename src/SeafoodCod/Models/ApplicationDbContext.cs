using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace SeafoodCod.Models
{           // class IdentityDbContext, which extends on Entity Framework's DbContext class to work with user authentication. //
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }   // onModelCreating is necessary when we want to create new tables in the database. in this case its after identity migration./
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        // we our setting our new Database "newsletters".//
        public DbSet<Newsletter> Newsletters { get; set; }
    }
}