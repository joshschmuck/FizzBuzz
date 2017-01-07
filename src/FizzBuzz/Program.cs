using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {

            for (int i = 0; i < 101; i++)
            {
                if(i % 3 ==0 && i % 7 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine("Buzz");
                }else
                {
                    Console.WriteLine(i);
                }
                //if (i % 3 == 0)
                //{
                //    Console.WriteLine("Fizz");
                //}
                //if (i % 7 == 0)
                //{
                //    //string buzz = i.Replace(i, "buzz");
                //    Console.WriteLine("Buzz");
                //}

                //Figuring out how to possibly use .Replace instead of an if statement
            }
             Console.ReadLine();
        }
    }
}
