using System;

namespace UC_CASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please choose program number to execute");
            Console.WriteLine("1:UC1\n 2:UC2\n 3:UC3\n 4:UC4\n 5:UC5\n 6:UC6\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //code block
                    //constants
                    int IS_FULLTIME = 1;
                    Console.WriteLine("Employee is present");
                    Console.WriteLine("Employee is absent");
                    break;

                case 2:
                    //code block
                    //Constants
                    int Is_FullTime = 1;
                    int EmpRatePerHour = 20;
                    //Variables
                    int empHrs = 0;
                    int empWage = 0;
                    empWage = empHrs * EmpRatePerHour;
                    Console.WriteLine("Emp wage : " + empWage);
                    break;

                default:
                    //code block
                    Console.WriteLine("please choose number within given");
                    break;
            }
            Console.ReadLine();
        }
            }
        }
 

