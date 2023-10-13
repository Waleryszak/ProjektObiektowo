using projekt1_zad.classes;

namespace projekt1_zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //nowy obiekt instacji person
            person person = new person();
            person.firstname = "Janusz";
            person.lastname = "Nowak";
            person.height = 192;
            // 5F dodajemy kiedy Float występuje gdzie kolwiek (opcjonalnie)
            person.weight = 90.5F;

            Console.WriteLine("Dane użytkowanika: " + person.getData());

            //Nowy obiekt "Kowal", Kiedy tworzymy person Kowal = new person() tworzy sie nowy pusty obiekt odwołujący sie do czegos innego
            person Kowal = new person();
            Kowal.firstname = "Anna";
            Kowal.lastname = "Kowal";
            Kowal.height = 170;
            Kowal.weight = 77F;

            Console.WriteLine("Dane użytkowanika: " + Kowal.getData());
            */
            double a;
            Console.WriteLine("Podaj bok pierwszy bok");
            while (!double.TryParse(Console.ReadLine(), out a)|| a <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;   
                Console.Write("Podaj wartość wieksza od zera:");
                Console.ResetColor();
            }

            double b;
            Console.WriteLine("Podaj bok drugi bok");
            while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Podaj wartość wieksza od zera:");
                Console.ResetColor();   
            }

            Rectangle rectangle = new Rectangle(a,b);
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Pole wynosi:");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(rectangle.CalculateRactangle() + "cm\u00B2");
            Console.ResetColor ();



        }
    }
}