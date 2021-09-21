using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebApi.Helpers
{
    public class MySqlDataContext : DataContext
    {
        public MySqlDataContext(IConfiguration configuration) : base(configuration) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to MySql database
            options.UseMySQL(Configuration.GetConnectionString("MySqlDatabase"));
        }
    }
}