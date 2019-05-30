using System;
using System.Collections.Generic;

namespace DemoModels.Models
{
    public partial class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string DepName { get; set; }
        public string DepAddress { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
