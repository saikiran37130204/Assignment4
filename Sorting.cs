using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class Sorting
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int num =1;
            Console.WriteLine("please enter the numbers");
            while (num != 0)
            {
                num = Int32.Parse(Console.ReadLine());
                if (num != 0)
                {
                    list.Add(num);
                }
            }
            Console.WriteLine("the numbers after sorting");
            list.Sort();
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
