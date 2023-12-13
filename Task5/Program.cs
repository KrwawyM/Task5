using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imię:");
            string name = Console.ReadLine();

            Console.WriteLine("Podaj swoje nazwisko:");
            string surname = Console.ReadLine();

            Console.WriteLine("Podaj swoj nr telefonu:");
            int phone = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj swoj adres email:");
            string eamil = Console.ReadLine();

            Console.WriteLine("Podaj swoj wzrost w cm:");
            int high = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj swoją wagę:");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Ile metrów kw ma twoje mieszkanie?");
            float area = float.Parse(Console.ReadLine());

            
        }
    }
}