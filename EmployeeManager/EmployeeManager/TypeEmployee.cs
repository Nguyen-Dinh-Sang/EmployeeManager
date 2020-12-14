using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManager
{
    public class TypeEmployee
    {
        public TypeEmployee(int id, string type)
        {
            this.id = id;
            this.type = type;
        }

        public int id { get; set; }

        public string type { get; set; }
    }
}
