using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class CardValidation
    {
        void cardValid()
        {
            Console.WriteLine("enter the card number");
            string number = Console.ReadLine();
            string reverseNumber = string.Empty;
            for(int i=number.Length-1;i>=0;i--)
            {
                reverseNumber += number[i];
            }
            Console.WriteLine(reverseNumber);
            int temp;
            int num;
            int count = 0;
            int[] arr = new int[reverseNumber.Length];
            for(int i=0;i<reverseNumber.Length;i++)
            {
                char value = reverseNumber[i];
                temp = (int)Char.GetNumericValue(value);
                if((i+1)%2==1)
                {
                    arr[i] = temp;
                }
                else
                {
                    arr[i] = temp * 2;
                }

            }
            //foreach(int item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            int sum;
            for(int i=0;i<arr.Length;i++)
            {
                sum = 0;
                if(arr[i]>9)
                {
                    while(arr[i]>0)
                    {
                        temp = arr[i] % 10;
                        sum = sum + temp;
                        arr[i] = arr[i] / 10;
                    }
                    arr[i] = sum;
                }
                else
                {
                    continue;
                }
            }
            sum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                sum = sum + arr[i];
            }
            if(sum%10==0)
            {
                Console.WriteLine("card is valid");
            }
            else
            {
                Console.WriteLine("card is invalid");
            }

        }
        static void Main(string[] args)
        {
            CardValidation cardValidation = new CardValidation();
            cardValidation.cardValid();
            Console.ReadKey();
        }
    }
}
