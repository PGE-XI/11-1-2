using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Expert:Employee
    {
        
        private const int expertSuccessRate = 1;
        public Expert(string names, string type) : base()
        {
            this.names = names;
            this.type = type;
            
        }
        public override void Execute()
        {
            if (expertSuccessRate == 1)
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
