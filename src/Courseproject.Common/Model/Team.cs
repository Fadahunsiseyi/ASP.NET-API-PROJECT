namespace Courseproject.Common.Model
{
    public class Team : BaseEntity
    {
        public string Name { get; set; } = default!;
        public List<Employee> Employees { get; set; } = default!;
    }
}