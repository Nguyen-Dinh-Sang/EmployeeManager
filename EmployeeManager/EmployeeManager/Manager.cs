using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManager
{
    public class Manager
    {
        private static Manager instance;
        private List<TypeEmployee> typeEmployees;
        private EmployeeList employees;

        private Manager()
        {
            typeEmployees = TypeEmployeeList.getInstance().getTypeEmployee();
            this.employees = new EmployeeList(typeEmployees);
        }

        public static Manager getInstance()
        {
            if (instance == null)
            {
                instance = new Manager();
            }

            return instance;
        }

        public void newEmployeeList()
        {
            Console.WriteLine("\nNew Employee List");
        }

        public void newEmployee()
        {
            Console.WriteLine("\nNew Employee");
            employees.newEmployee();
        }

        public void employeeList()
        {
            Console.WriteLine("\nEmployee List");
            employees.getEmployeeList();
        }

        public void totalSalary()
        {
            //nhập lương cơ bản
            Console.WriteLine("\nTotal Salary");
        }
    }
}
