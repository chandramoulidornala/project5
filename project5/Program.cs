using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace project5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,g=0,prime=0;
            Console.WriteLine("enter any number");
            n = Convert.ToInt16(Console.ReadLine());
            g = n / 2;
            for (i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("the entered number is not prime");
                    prime = 1;
                    break;
                }
            }
                if(prime==0)
                    Console.WriteLine("The entered numebr is prime number");
            }
            

        }
    }

