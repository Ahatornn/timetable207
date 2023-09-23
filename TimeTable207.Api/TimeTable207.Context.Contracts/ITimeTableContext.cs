using TimeTable207.Context.Contracts.Models;

namespace TimeTable207.Context.Contracts
{
    public interface ITimeTableContext
    {
        ICollection<Discipline> Disciplines { get; }

        ICollection<Document> Documents { get; }

        ICollection<Employee> Employees { get; }

        ICollection<Group> Groups { get; }

        ICollection<Person> Persons { get; }

        ICollection<TimeTableItem> TimeTableItems { get; }
    }
}
