namespace CirclePerimeterArea
{    
    using System;

    class CirclePerimeterArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter circle radius:");
            float radius = float.Parse(Console.ReadLine());

            Console.Write("Perimeter:");
            Console.WriteLine(" {0:F2}", 2 * Math.PI * radius);
            Console.Write("Area:");
            Console.WriteLine(" {0:F2}", Math.PI * radius * radius);

        }
    }
}
//"{0:F2}" is for fomratting 2 digits after the decimal point