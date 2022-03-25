using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_CASE
{
    internal class UC3
    {
        static void main(string[] args)
        {
            //Constants
            int Is_PartTime = 1;
            int Is_FullTime = 2;
            int EmpRatePerHour = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 3);
            if (empCheck == Is_PartTime)
            {
                empHrs = 4;
            }
            else if (empCheck == Is_FullTime)
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

