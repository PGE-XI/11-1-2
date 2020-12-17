using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
   public class Manager:Employee
    {
        Manager employees = new Manager();
        protected int employeesCount;
        public Manager()
        {

        }
        public Manager(string employeeFirstName,string employeeLastName, string type )
        {
            this.employeeFirstName = employeeFirstName;
            this.employeeLastName = employeeLastName;
            this.type = type;
        }
        public void AddEmployee()
        {

        }
        public override void Execute()
        {
            Worker worker1 = new Worker(0);
            if (worker1.K==0)
            {
                Console.WriteLine("The worker of this manager succeded");
            }
            else
                Console.WriteLine("He failed");
            
        }
        public override int SuccessRate()
        {
            return 0;
        }
        public void printStatus()
        {
            Console.WriteLine(employees.type+": "+employees.employeeFirstName+" "+employees.employeeLastName+"успеваемост"+" "+employees.successRate);
        }
    }
}
