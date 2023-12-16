using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TimeTable207.Context
{
    internal class DesignTimeFactory : IDesignTimeDbContextFactory<TimeTableContext>
    {
        public TimeTableContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<TimeTableContext>()
                .UseSqlServer(connectionString)
                .Options;

            return new TimeTableContext(options);
        }
    }
}
