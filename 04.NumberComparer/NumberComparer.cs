namespace NumberComparer
{
    using System;

    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number one:");
            float numberOne = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number two:");
            float numberTwo = float.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(numberOne, numberTwo));
        }
    }
}