using System.Transactions;

namespace zaj2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool czyprawidlowo = false;
            do
            {
                Console.WriteLine("Podaj długość pierwszego boku");
                double a;
                while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.WriteLine("Nieprawdłowe dane.Podaj liczbę wiekszą od zera:");
                }

                double b;
                Console.WriteLine("Podaj długość drugiego boku");
                while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.WriteLine("Nieprawdłowe dane.Podaj liczbę wiekszą od zera:");
                }

                double c;
                Console.WriteLine("Podaj długość drugiego boku");
                while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    Console.WriteLine("Nieprawdłowe dane.Podaj liczbę wiekszą od zera:");
                    
                }

                if (czytrojkat(a, b, c))
                {
                    double pole = PoleTrojkata(a, b, c);
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    Console.WriteLine($"\nPole trojkata {a}, {b}, {c} wynosi:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{pole:F5}cm\u00B2");
                    Console.ResetColor();
                    czyprawidlowo = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;   
                    Console.WriteLine("\nPodane długosci nie utworza trojkata");
                    Console.ResetColor();   
                    Thread.Sleep(1500);
                    Console.Clear();

                }


                static bool czytrojkat(double a, double b, double c)
                {
                    return a + b > c && a + c > b && b + c > a;
                }

                static double PoleTrojkata(double a, double b, double c)
                {
                    double p = (a + b + c) / 2;
                    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                }
            }
            while (!czyprawidlowo);
            
        }
    }
}