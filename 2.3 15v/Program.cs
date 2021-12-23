using System;

namespace _2._3_15v
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите 1,2 или 3");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Введите x:");
                double x = double.Parse(Console.ReadLine());
                double a = 0, b = 0, c = 0, y = 0;
                switch (n)
                {
                    case 1: a = 3.5; b = -0.73; c = 2.5; break;
                    case 2: a = 15.4; b = -5.6; c = 3.5; break;
                    case 3: a = 5.1; b = 4; c = 2.7; break;
                }
                if (Math.Abs(1 - x * x) == a + c) y = Math.Sqrt(Math.Abs(a * x - Math.Cos(b * b * b * x) * Math.Cos(b * b * b * x) + 5.1 * c * c));
                else if (Math.Abs(1 - x * x) > a + c) y = Math.Exp(0.04 * x) + Math.Log(Math.Abs(b * b * b * b * b * Math.Cos(x)));
                else if (Math.Abs(1 - x * x) < a + c) y = Math.Cos(b * b * b * x * x) * Math.Cos(b * b * b * x * x) + Math.Log(Math.Abs(b * x - a * a));
                Console.WriteLine($"y={y:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
