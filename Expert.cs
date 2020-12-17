using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Expert:Employee
    {
        protected const int k = 0;

        public override void Execute()
        {
            if (k == 0)
            {
                Console.WriteLine("Executed by an Expert");
            }
        }
        public override int SuccessRate()
        {
            Console.WriteLine("Success rate=100%");
            return 1;

        }

    }
}
