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
        protected string employeeFirstName;
        protected string employeeLastName;
        protected string type;
        protected int successRate = 0;
        
        public abstract void Execute();
        public abstract int SuccessRate(); 
        
    }
}
