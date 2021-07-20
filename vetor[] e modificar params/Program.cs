using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            int soma = c.Somar(1, 5, 7);
            Console.WriteLine(soma);
        }
    }
}