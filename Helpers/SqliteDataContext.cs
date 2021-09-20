using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

//using MySql.Data.EntityFrameworkCore.Extensions;

namespace WebApi.Helpers
{
    public class SqliteDataContext : DataContext
    {
        public SqliteDataContext(IConfiguration configuration) : base(configuration) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to MySQl database
            options.UseMySQL(Configuration.GetConnectionString("MySqlDatabase"));
        }
    }
}