using HandMadeBySne.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HandMadeBySne
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Gift> Gifts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)=> 
                        optionBuilder.UseMySql(connectionString:
                         "Server=sql11.freemysqlhosting.net; Database=sql11200858; User Id=sql11200858; Password=hEQZGHDxtR;");
    }
}
