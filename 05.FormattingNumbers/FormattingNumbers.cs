namespace FormattingNumbers
{
    using System;

    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type number a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Type number b:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Type number c:");
            float c = float.Parse(Console.ReadLine());

            Console.Write("|{0:X}", a);
            Console.Write("         |{0}|", Convert.ToString(a, 2).PadLeft(10, '0')); //padded with zeroes!
            Console.Write("         {0:F2}|", b);
            Console.WriteLine("{0:F3}      |", c);

        }
    }
}