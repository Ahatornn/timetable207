using TimeTable207.Context.Contracts;
using TimeTable207.Context.Contracts.Models;

namespace TimeTable207.Context
{
    public class TimeTableContext: ITimeTableContext
    {
        private ICollection<Discipline> disciplines;
        private ICollection<Document> documents;
        private ICollection<Employee> employees;
        private ICollection<Group> groups;
        private ICollection<Person> persons;
        private ICollection<TimeTableItem> timeTableItems;

        public TimeTableContext()
        {
            disciplines = new HashSet<Discipline>();
            documents = new HashSet<Document>();
            employees = new HashSet<Employee>();
            groups = new HashSet<Group>();
            persons = new HashSet<Person>();
            timeTableItems = new HashSet<TimeTableItem>();
            Seed();
        }

        ICollection<Discipline> ITimeTableContext.Disciplines => disciplines;

        ICollection<Document> ITimeTableContext.Documents => documents;

        ICollection<Employee> ITimeTableContext.Employees => employees;

        ICollection<Group> ITimeTableContext.Groups => groups;

        ICollection<Person> ITimeTableContext.Persons => persons;

        ICollection<TimeTableItem> ITimeTableContext.TimeTableItems => timeTableItems;

        private void Seed()
        {
            disciplines.Add(new Discipline
            {
                Id = Guid.NewGuid(),
                Name = $"Name{Guid.NewGuid():N}",
                Description = $"Description{Guid.NewGuid():N}",
            });
            groups.Add(new Group
            {
                Id = Guid.NewGuid(),
                Name = $"Name{Guid.NewGuid():N}",
                Description = $"Description{Guid.NewGuid():N}",
            });
            groups.Add(new Group
            {
                Id = Guid.NewGuid(),
                Name = $"Name{Guid.NewGuid():N}",
                Description = $"Description{Guid.NewGuid():N}",
            });
        }
    }
}
