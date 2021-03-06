﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManager
{
    public class EmployeeList
    {
        private List<Employee> employees = new List<Employee>();
        List<TypeEmployee> typeEmployees = new List<TypeEmployee>();

        public EmployeeList(List<TypeEmployee> typeEmployees)
        {
            this.typeEmployees = typeEmployees;
        }

        public void newEmployee()
        {
            Console.WriteLine("Enter The Information: ");
            try
            {
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Type Option");
                foreach(TypeEmployee item in typeEmployees)
                {
                    Console.WriteLine(item.id + ": " + item.type);
                }
                Console.Write("Type: ");
                int type = int.Parse(Console.ReadLine());
                if (type < 1 && type > 4)
                {
                    Console.WriteLine("An Error Occurred, Please Re-Enter");
                    newEmployee();
                }
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Date Of Birth: ");
                string dateOfBirth = Console.ReadLine();
                Console.Write("Address: ");
                string address = Console.ReadLine();
                Console.Write("Coefficients Salary: ");
                int coefficientsSalary = int.Parse(Console.ReadLine());
                Console.Write("Date Start Work: ");
                string dateStartWork = Console.ReadLine();
                employees.Add(new Employee(id, type, name, dateOfBirth, address, coefficientsSalary, dateStartWork));
                Console.WriteLine("Success");
            }
            catch (Exception e)
            {
                Console.WriteLine("An Error Occurred, Please Re-Enter");
                newEmployee();
            }
        }

        public void getEmployeeList()
        {
            int cout = 1;
            foreach (Employee item in employees)
            {
                Console.WriteLine("Employee: " + cout++);
                Console.WriteLine("ID: " + item.id);
                switch (item.type)
                {
                    case 1:
                        Console.WriteLine("Type: Manager");
                        break;
                    case 2:
                        Console.WriteLine("Type: Programer");
                        break;
                    case 3:
                        Console.WriteLine("Type: Designer");
                        break;
                    case 4:
                        Console.WriteLine("Type: Tester");
                        break;
                }
                Console.WriteLine("Name :" + item.name);
                Console.WriteLine("Date Of Birth :" + item.dateOfBirth);
                Console.WriteLine("Address :" + item.address);
                Console.WriteLine("Coefficients Salary :" + item.coefficientsSalary);
                Console.WriteLine("Date Start Work :" + item.dateStartWork);
                Console.WriteLine("\n");
            }
        }

        public void newEmployeeList()
        {
            Console.WriteLine("Enter The New Employee List");
            Boolean running = true;
            employees.Clear();
            while (running)
            {
                newEmployee();
                Console.WriteLine("1: Continue");
                Console.WriteLine("2: Exit");
                Console.Write("Option: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        break;
                    case 2:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("An Error Occurred, Please Re-Enter");
                        newEmployeeList();
                        break;
                }
            }
        }

        public void totalSalary()
        {
            Console.Write("Enter The Basic Salary: ");
            Double basicSalary = Double.Parse(Console.ReadLine());
            Double totalSalary = 0;
            foreach (Employee item in employees)
            {
                Double salary = 0;
                switch (item.type)
                {
                    case 1:
                        salary = basicSalary * item.coefficientsSalary;
                        break;
                    case 2:
                        Console.Write("Enter The Overtime Pay For Programer: ");
                        Double overtimePay = Double.Parse(Console.ReadLine());
                        salary = basicSalary * item.coefficientsSalary + overtimePay;
                        break;
                    case 3:
                        Console.Write("Enter The Bonus For Designer: ");
                        Double bonus = Double.Parse(Console.ReadLine());
                        salary = basicSalary * item.coefficientsSalary + bonus;
                        break;
                    case 4:
                        Console.Write("Enter The Error For Tester: ");
                        Double error = Double.Parse(Console.ReadLine());
                        salary = basicSalary * item.coefficientsSalary + error * 200000;
                        break;
                }
                totalSalary += salary;
            }
            Console.WriteLine("Total Salary: " + totalSalary);
        }
    }
}
