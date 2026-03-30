using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        Random rand = new Random();

        static void Main(string[] args)
        {
            var rand = new Random();

            //Вищий рівень завдання 1

            /*

            Console.WriteLine("Впишіть день");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Впишіть місяць (числом без нулю на початку)");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    
                    if (day > 2)
                    {
                        Console.WriteLine($"перед цим було:{day - 1}/{month}");
                    }
                    else if (month == 8)
                    {
                        Console.WriteLine("перед цим було:31/7");
                    }
                    else if (month==1)
                    {
                        Console.WriteLine("перед цим було:31/12");
                    }
                    else if (month == 2)
                    {
                        Console.WriteLine("перед цим було:28/2");
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 2)
                    {
                        Console.WriteLine($"перед цим було:{day - 1}/{month}");
                    }
                    else
                    {
                        Console.WriteLine($"перед цим було:31/{month-1}");
                    }

                    break;

                case 2:
                    if (day > 2)
                    {
                        Console.WriteLine($"перед цим було:{day - 1}/{month}");
                    }
                    else
                    {
                        Console.WriteLine("перед цим було:31/1");
                    }
                    break;
                default:
                     Console.WriteLine("Помилка. Was wollen wir trinken?");
                    break;
            }
        
            */

            //Вищий рівень завдання 2 

            Console.WriteLine("Впишіть день");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Впишіть місяць (числом без нулю на початку)");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:

                    if (day < 31)
                    {
                        Console.WriteLine($"перед цим було:{day + 1}/{month}");
                    }
                    else
                    {
                        Console.WriteLine("перед цим було:31/7");
                    }
                    else if (month == 1)
                    {
                        Console.WriteLine("перед цим було:31/12");
                    }
                    else if (month == 2)
                    {
                        Console.WriteLine("перед цим було:28/2");
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 2)
                    {
                        Console.WriteLine($"перед цим було:{day - 1}/{month}");
                    }
                    else
                    {
                        Console.WriteLine($"перед цим було:31/{month - 1}");
                    }

                    break;

                case 2:
                    if (day > 2)
                    {
                        Console.WriteLine($"перед цим було:{day - 1}/{month}");
                    }
                    else
                    {
                        Console.WriteLine("перед цим було:31/1");
                    }
                    break;
                default:
                    Console.WriteLine("Помилка. Bad to bones");
                    break;
            }



















        }
    }
}