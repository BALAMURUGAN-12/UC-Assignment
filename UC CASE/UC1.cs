using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_CASE
{
    internal class UC1
    {
     static void main(string[] args)
        {
            //constants
            int IS_FULLTIME = 1;
            Random random = new Random();
            //computation
            int empCheck = random.Next(0,2);
            if (empCheck == IS_FULLTIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }


    }
}
