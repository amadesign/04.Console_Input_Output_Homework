using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine()); //2
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine()); //5
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());//-3
        //5*5      4 * 2 * -3
        double discriminant = (b * b) - (4 * a * c);
        if (discriminant > 0)
        {
            double x2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            double x1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
        }
        else if (discriminant == 0)
        {
            double x1Andx2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("x1 = x2 = {0}", x1Andx2);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("No real roots");
        }
    }
}
//Първо декларираш трите променливи a, b и c . С тях ще четеш три числа от конзолата.
//След това декларираш друга променлива discriminant. Това е дискриминантата в е едно квадратно уравнение.
//Тя се намира по следната формула D = b*b - 4.a.c 
//следкато намериш дискриминатата D с нея трябва да намериш и корените :

//Ако дискриминантата D е по-голяма от 0 имаш два корена
//Ако дискриминантата D е по-малка от 0 нямаш реални корени
//И ако е равна на 0 имаш един и същ отговор за двата корена. 

//Тези три варианта ги разработваш с if else


//След това формулите за намиране на двата корена са следните :
//x1 =((-b) - Math.Sqrt(discriminant)) / (2 * a);

//x2 =((-b) + Math.Sqrt(discriminant)) / (2 * a);

//С Math.Sqrt слагаш под корен дискриминантата. 