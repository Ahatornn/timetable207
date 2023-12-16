using Microsoft.EntityFrameworkCore;
using TimeTable207.Context.Contracts;
using TimeTable207.Context.Contracts.Models;

namespace TimeTable207.Context
{
    /// <summary>
    /// Контекст работы с БД
    /// </summary>
    /// <remarks>
    /// 1) dotnet tool install --global dotnet-ef
    /// 2) dotnet tool update --global dotnet-ef
    /// 3) dotnet ef migrations add [name] --project TimeTable207.Context\TimeTable207.Context.csproj
    /// 4) dotnet ef database update --project TimeTable207.Context\TimeTable207.Context.csproj
    /// </remarks>
    public class TimeTableContext : DbContext, ITimeTableContext
    {
        /// <summary>
        /// ctor
        /// </summary>
        public TimeTableContext(DbContextOptions<TimeTableContext> options)
            : base(options)
        {
        }

        public DbSet<Discipline> Disciplines { get; set; }

        public DbSet<Document> Documents { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<TimeTableItem> TimeTableItems { get; set; }
    }
}
