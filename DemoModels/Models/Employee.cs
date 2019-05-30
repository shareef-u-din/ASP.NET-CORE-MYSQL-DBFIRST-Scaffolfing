using System;
using System.Collections.Generic;

namespace DemoModels.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int DepId { get; set; }

        public Department Dep { get; set; }
    }
}
