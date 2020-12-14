using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManager
{
    public class Employee
    {
        public Employee(int id, int type, string name, string dateOfBirth, string address, int coefficientsSalary, string dateStartWork)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.coefficientsSalary = coefficientsSalary;
            this.dateStartWork = dateStartWork;
        }

        public int type { get; set; }

        public int id { get; set; }

        public string name { get; set; }

        public string dateOfBirth { get; set; }

        public string address { get; set; }

        public int coefficientsSalary { get; set; }

        public string dateStartWork { get; set; }
    }
}
