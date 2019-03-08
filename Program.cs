using System; //using dyrektywa, system - przestrzen nazw

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Witaj swiecie!");// formatowanie textu zaznaczamy i ctr K i ctr F
            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            { Console.WriteLine(" Dziś jest czwartek"); }
            else
            { Console.WriteLine("Dziś jest inny dzień niż czwartek"); }
int wiek;
            string imie;
            Console.WriteLine("Jak masz na imię ?");
                        imie = Console.ReadLine();
            System.Console.WriteLine("Podaj wiek");
                      wiek = int.Parse(Console.ReadLine());
            Console.WriteLine("Witaj " + imie + " "+ wiek);
//testowy 2
        }
    }
}
