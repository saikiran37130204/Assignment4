using System;
using System.Collections.Generic;

namespace Assignment_3
{
    class Divisibility
    {
        int[] arr1 = new int[10];
      public  void ReadFromUser()
        {
            Console.WriteLine("please enter 10 intergers");
            for (int i = 0; i <10; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
      public void NumbersDivisibleBy7()
        {
            Console.WriteLine("the numbers divisible by 7 are");
            foreach(int item in arr1)
            {
                if (item % 7 == 0)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    continue;
                }
            }
        }
        static void Main(string[] args)
        {

            // Console.WriteLine("Hello World!");
            Divisibility program = new Divisibility();
            program.ReadFromUser();
            program.NumbersDivisibleBy7();
            Console.ReadKey();
        }
    }
}
