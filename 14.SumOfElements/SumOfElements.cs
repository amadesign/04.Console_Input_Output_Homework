﻿using System;

class SumOfElements
{
    static void Main()
    {
        string[] num = Console.ReadLine().Split();
        long sum = 0;
        long MaxElement = Convert.ToInt32(num[0]);
        for (int i = 1; i < num.Length; i++)
        {
            long element = Convert.ToInt32(num[i]);
            if (MaxElement >= element)
            {
                sum += element;
            }
            else if (MaxElement < element)
            {
                sum += MaxElement;
                MaxElement = element;
            }
        }
        if (MaxElement - sum == 0)
        {
            Console.WriteLine("Yes, sum={0}", sum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(MaxElement - sum));
        }
        Console.WriteLine();
    }
}