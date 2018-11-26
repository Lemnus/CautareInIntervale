using System;
using System.Collections.Generic;

namespace CautareInIntervale
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Read();
            int T = Read();
            //int[] numbers = new[] { 1,5,17,18,70,99 };
            Read(out int[] numbers);            
                Array.Sort(numbers);
            for(int i=0;i<T;i++)
            {
                Console.WriteLine(CountNbs(numbers, n));
            }
        }
        static int CountNbs(in int[] numbers,in int n)
        {
            int x = Read();
            int y = Read();
            int nbsInRange = 0;
            int index = Array.BinarySearch(numbers, x);
            if (index >= n)
                return 0;
                else
                if (index < 0)
                index=~index;
            while (numbers[index] <= y)
            {
                nbsInRange++;
                index++;
            }
            return nbsInRange;
        }

        static int Read()
        {
            throw new Exception();
          //  return;
        }
        static void Read(out int[] numbers)
        {
           
            throw new Exception();
        }
    }
}
