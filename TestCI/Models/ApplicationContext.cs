using Microsoft.EntityFrameworkCore;

namespace TestCI.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}
