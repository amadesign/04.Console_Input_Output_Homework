﻿using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string asterisk = string.Empty;
        for (int j = 1; j <= n; j = j + 2)
        {
            string dash = new string('-', (n - j) / 2);
            asterisk = new string('*', j);
            Console.Write(dash);
            Console.Write(asterisk);
            Console.Write(dash);
            Console.WriteLine();
            if ((n - j) / 2 == 0)
            {
                break;
            }
        }
        for (int i = 0; i < n; i++)
        {
            string pipe = new string('|', 1);
            asterisk = new string('*', n - 2);
            Console.Write(pipe);
            Console.Write(asterisk);
            Console.Write(pipe);
            Console.WriteLine();
        }
    }
}
