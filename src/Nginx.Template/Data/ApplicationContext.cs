using Microsoft.EntityFrameworkCore;

namespace Nginx.Template.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}
