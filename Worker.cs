using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Worker:Employee
    {
        protected int successRate;
        
        public  int successrate
        {
            get { return successRate; }
            set { successRate = value; }
        }
        protected int numJobsDone=0;
        public Worker(int successRate)
        {
            this.successRate = successRate;
        }
        public Worker(string names, string type, int successRate, int numJobsDone):base()
        {
            this.names = names;
            this.type = type;
            this.successRate = successRate;
            this.numJobsDone = numJobsDone;
        }
        public override void Execute()
        {
            
            if (successRate==1)
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
