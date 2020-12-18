using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public abstract class Employee
    {
        
        protected int employeeID;
        protected string names;
        protected string type;
        protected int successRate = 0;
        protected double k;
        protected Manager manager;
        public Manager Manager { get; set; }

        public double K { get; set; }

        public string Names { get; set; }

        public abstract void Execute();
        public abstract int SuccessRate(); 
        
    }
}
