using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courseproject.Common.Model
{
    public class Address : BaseEntity
    {
        public string Street { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Zip { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string? PhoneNumber { get; set; } = default!;
        public List<Employee> Employees { get; set; } = default!;
    }
}
