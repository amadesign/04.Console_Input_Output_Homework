namespace _09.SumOfNNumbers
{
    using System;

    class SumOfnumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of numbers: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("{0}", sum);
        }
    }
}
