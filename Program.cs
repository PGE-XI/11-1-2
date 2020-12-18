using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Angel", "Manager",0);
            Worker worker = new Worker("Boqn", "Worker", 0, 2);
            Expert expert = new Expert("Vasilka", "Expert");
            Manager manager1 = new Manager("Georgi", "Manager", 0);
            Worker worker1 = new Worker("Dimitur", "Worker", 0, 4);
            manager.AddEmployee(worker);
            manager.AddEmployee(expert);
            manager1.AddEmployee(worker1);
            manager.RemoveEmployee("Boqn");
            expert.Execute();
            manager.Execute();
            manager.SuccessRate();
            manager.printStatus();
            
        }
    }
}
