using Microsoft.EntityFrameworkCore;
using TimeTable207.Context.Contracts.Models;

namespace TimeTable207.Context.Contracts
{
    public interface ITimeTableContext
    {
        DbSet<Discipline> Disciplines { get; }

        DbSet<Document> Documents { get; }

        DbSet<Employee> Employees { get; }

        DbSet<Group> Groups { get; }

        DbSet<Person> Persons { get; }

        DbSet<TimeTableItem> TimeTableItems { get; }
    }
}
