using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManager
{
    public class TypeEmployeeList
    {
        private static TypeEmployeeList instance;

        private List<TypeEmployee> typeEmployees = new List<TypeEmployee>();

        private TypeEmployeeList()
        {
            typeEmployees.Add(new TypeEmployee(1, "Manager"));
            typeEmployees.Add(new TypeEmployee(2, "Programer"));
            typeEmployees.Add(new TypeEmployee(3, "Designer"));
            typeEmployees.Add(new TypeEmployee(4, "Tester"));
        }

        public static TypeEmployeeList getInstance()
        {
            if (instance == null)
            {
                instance = new TypeEmployeeList();
            }

            return instance;
        }

        public List<TypeEmployee> getTypeEmployee()
        {
            return typeEmployees;
        }
    }
}
