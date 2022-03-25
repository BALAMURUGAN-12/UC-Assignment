using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_CASE
{
    internal class UC2
    {
        static void main(string[] args)
        {
            //Constants
            int Is_FullTime = 1;
            int EmpRatePerHour = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_FullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EmpRatePerHour;
            Console.WriteLine("Emp wage : " + empWage);

        }
    }
}
