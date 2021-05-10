using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class RepeatingNumbers
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int num = 0;
            Console.WriteLine("please enter the numbers");
            while(num>=0)
            {
                num = Int32.Parse(Console.ReadLine());

                list.Add(num);
            }
            Console.WriteLine("repeating numbers are");
            for(int i=0;i<list.Count;i++)
            {
                for(int j=i+1;j<list.Count;j++)
                {
                    if(list[i]==list[j])
                    {
                        Console.WriteLine(list[i]);
                    }
                }
            }
        }
    }
}
