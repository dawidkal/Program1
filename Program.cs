using System; //using dyrektywa, system - przestrzen nazw

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Witaj swiecie!");// formatowanie textu zaznaczamy i ctr K i ctr F
            JakiMamyDzien();
            for (int i = 0; i < 2; i++)
                WprowadzanieDanych();
        }

        private static void JakiMamyDzien() 
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            { Console.WriteLine(" Dziś jest czwartek"); }
            else
            { Console.WriteLine("Dziś jest inny dzień niż czwartek"); }
        }

        private static void WprowadzanieDanych()
        {
            Console.Clear();
            int wiek;
            string imie;
            Console.WriteLine("Jak masz na imię ?");
            imie = Console.ReadLine();
            System.Console.WriteLine("Podaj wiek");
            wiek = int.Parse(Console.ReadLine()); // konwersja inta
            Console.ForegroundColor = ConsoleColor.Green; //zmiana koloru
            Console.WriteLine("Witaj " + imie + " " + wiek);
            Console.ReadKey(); //oczekiwanie na klawisz
//test
        }
    }
}
