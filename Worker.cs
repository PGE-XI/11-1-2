using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Worker:Employee
    {
        protected int k;
        public  int K { get; set; }
        protected int numJobsDone=0;
        public Worker(int k)
        {
            this.k = k;
        }
        public Worker(string employeeFirstName, string employeeLastName, string type, int k, int numJobsDone):base()
        {
            this.employeeFirstName = employeeFirstName;
            this.employeeLastName = employeeLastName;
            this.type = type;
            this.k = k;
            this.numJobsDone = numJobsDone;
        }
        public override void Execute()
        {
            
            if (k==0)
            {
                Console.WriteLine("Executed successfully");
                numJobsDone++;
            }
            else
                Console.WriteLine("Failed");

        }
        public override int SuccessRate()
        {
            if (numJobsDone==0)
            {
                Console.WriteLine("The Worker hasn't done any jobs");
                return 0;
            }
            if (numJobsDone > 0)
            {
                Console.Write("The worker has done this amount of jobs = ");
                return numJobsDone;
            }
            else return 0;
        }
    }
}
