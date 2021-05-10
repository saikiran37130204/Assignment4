using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class PrimeNumbers_2
    {
static void Main(string[] args)
        {
            Console.WriteLine("please enter min value");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter max value");
            int max = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            if(min>max)
            {
                Console.WriteLine("invalid entry");
            }
            else
            {
                for(int i=min+1;i<max;i++)
                {
                    count = 0;
                    for(int j=1;j<=i;j++)
                    {
                        if(i%j==0)
                        {
                            count++;
                        }
                    }
                    if(count==2)
                    {
                        Console.WriteLine(i);
                    }
                }
                
            }
        }
    }
}
