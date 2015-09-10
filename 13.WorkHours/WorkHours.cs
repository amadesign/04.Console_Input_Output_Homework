﻿using System;

class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        double efficientWorkHours = ((d - (d * (10 / 100.0))) * 12) * (p / 100.0);
        if (h > efficientWorkHours)
        {
            Console.WriteLine("No");
            Console.WriteLine("{0}", (int)efficientWorkHours - h);
        }
        else if (h <= efficientWorkHours)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0}", Math.Abs((int)efficientWorkHours - h));
        }
    }
}
