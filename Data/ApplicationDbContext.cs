using Microsoft.EntityFrameworkCore;

namespace mvc_project.Data
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=db38554.public.databaseasp.net; Database=db38554; User Id=db38554; Password=mB?7%4Aa6p@H; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;  ");
            // optionsBuilder.UseSqlServer("Server=.;database=mvc_project;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
