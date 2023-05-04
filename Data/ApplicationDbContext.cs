using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ITS_System.Data.Models;
using ITS_System.Models;

namespace ITS_System.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ITS_System.Data.Models.Asset>? Asset { get; set; }
        public DbSet<ITS_System.Models.GeneralIssue>? GeneralIssue { get; set; }
        public DbSet<ITS_System.Models.TechnicalIssue>? TechnicalIssue { get; set; }
    }
}