using TimeTable207.Context.Contracts;
using TimeTable207.Context.Contracts.Models;

namespace TimeTable207.Context
{
    internal class TimeTableContext : ITimeTableContext
    {
        private static ICollection<Discipline> disciplines;
        private static ICollection<Document> documents;
        private static ICollection<Employee> employees;
        private static ICollection<Group> groups;
        private static ICollection<Person> persons;
        private static ICollection<TimeTableItem> timeTableItems;

        static TimeTableContext()
        {
            disciplines = new HashSet<Discipline>();
            documents = new HashSet<Document>();
            employees = new HashSet<Employee>();
            groups = new HashSet<Group>();
            persons = new HashSet<Person>();
            timeTableItems = new HashSet<TimeTableItem>();
        }

        ICollection<Discipline> ITimeTableContext.Disciplines => disciplines;

        ICollection<Document> ITimeTableContext.Documents => documents;

        ICollection<Employee> ITimeTableContext.Employees => employees;

        ICollection<Group> ITimeTableContext.Groups => groups;

        ICollection<Person> ITimeTableContext.Persons => persons;

        ICollection<TimeTableItem> ITimeTableContext.TimeTableItems => timeTableItems;
    }
}
