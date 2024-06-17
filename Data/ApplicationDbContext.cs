using Microsoft.EntityFrameworkCore;

namespace PredictAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
               
        }
    }
}
