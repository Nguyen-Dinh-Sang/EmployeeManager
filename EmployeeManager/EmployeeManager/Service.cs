using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManager
{
    public class Service
    {
        private Boolean running;
        public Service()
        {
            running = true;
            while(running)
            {
                menu();
            }
        }

        private void menu()
        {
            Console.WriteLine("1 Enter The New Employee List");
            Console.WriteLine("2 Add 1 New Employee");
            Console.WriteLine("3 Export Employee List");
            Console.WriteLine("4 Calculate Total Salary");
            Console.WriteLine("5 Exit");
            Console.Write("Option: ");
            option();
        }

        private void option()
        {
            try
            {
                int option = int.Parse(Console.ReadLine());
                processRequest(option);
            }
            catch (Exception e)
            {
                Console.WriteLine("An Error Occurred, Please Re-Enter");
                menu();
            }
        }

        private void processRequest(int option)
        {
            switch (option)
            {
                case 1:
                    Manager.getInstance().newEmployeeList();
                    break;
                case 2:
                    Manager.getInstance().newEmployee();
                    break;
                case 3:
                    Manager.getInstance().employeeList();
                    break;
                case 4:
                    Manager.getInstance().totalSalary();
                    break;
                case 5:
                    Console.WriteLine("Exit Exit Exit");
                    running = false;
                    break;
                default:
                    Console.WriteLine("An Error Occurred, Please Re-Enter");
                    menu();
                    break;
            }
        }
    }
}
