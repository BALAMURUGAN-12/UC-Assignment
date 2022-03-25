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
                    Random random = new Random();
                    Console.WriteLine("Employee is present");
                    Console.WriteLine("Employee is absent");
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
 

