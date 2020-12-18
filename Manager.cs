using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
   public class Manager:Employee
    {
        Manager managerEmployees = new Manager();
        protected int employeesCount;
        bool success;
        List<Employee> employees = new List<Employee>();
        public bool Success
        {
            get { return success; }
            set { success = value; }
        }
        public Manager()
        {

        }
        public Manager(string names, string type,int successRate )
        {
            this.names = names;
            this.type = type;
            this.successRate = successRate;
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            employee.Manager = manager;
            k = employees.Select(x => x.K).Average();
          
        }

        public void RemoveEmployee(string names)
        {
            int index = employees.FindIndex(x => x.Names == names);
            employees.RemoveAt(index);
            k = employees.Select(x => x.K).Average();
            
        }
        public override void Execute()
        {
            
            Worker worker1 = new Worker(0);
            if (worker1.successrate == 1)
            {
                Console.WriteLine("The worker of this manager succeded");
                success = true;
            }
            else
            {
                Console.WriteLine("He failed");
                success = false;
            }
            
        }
        public override int SuccessRate()
        {
            if (success==true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void printStatus()
        {
            Console.WriteLine(managerEmployees.type+": "+managerEmployees.Names+" "+"успеваемост"+" "+managerEmployees.successRate);
        }
    }
}
