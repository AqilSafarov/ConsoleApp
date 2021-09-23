using finalproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Restoran menu = new Restoran("Bari Naxcivan");

            Console.Write($"{menu.restoranNam} restorana xos gemisizniz!");
            Console.WriteLine();
            byte num;
            do
            {
                byte reqem;

                Console.WriteLine("Asagdaki reqemlerden isdifade ederek console proyekti isdifade ede bilersiniz"); 

                Console.WriteLine("1.Add food");
                Console.WriteLine("2.Order food");
                Console.WriteLine("3.Show menu");
                Console.WriteLine("0.Exit");  
        
                bool isTrueChoiise = byte.TryParse(Console.ReadLine(), out reqem); 
                num = reqem;
           
                if (isTrueChoiise)
                {
                    switch (reqem)
                    {
                        case 1:
                        {
                                menu.AddOrder();
                                break;
                        }
                        case 2:
                        {
                                menu.OrderFood();
                                break;
                        }
                        case 3:
                        {
                                menu.ShowMenu();
                                break;
                        }
                        default:
                            {
                                Console.WriteLine("Yalniz yuxarida verilen ededleri daxil ede bilersiz!!!");
                                break;
                            }
                    }
                  
                } 
                else
                {
                    num = 4;

                    Console.WriteLine("Siz yalniz eded daxil ede bilersiniz");

                }
            } 
            while (num!=0);  
        }
    }
}
