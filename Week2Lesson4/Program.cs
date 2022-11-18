using System.Security.Cryptography.X509Certificates;

namespace Week2Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            /* Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy.Dane
               które chcesz przetrzymywać to:
                a.Imię,
                b.Nazwisko
                c.Wiek
                d.Płeć(‘m’ albo ‘k’)
                e.PESEL
                f.Numer pracownika(np. 2509324094)
               Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje
            */

            string name;
            string surname;
            byte age;
            char gender;
            string numerPESEL;
            string employeeNumber;

            //Zadanie 2
            /* Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w 
               odwrotnej kolejności niż zostały zadeklarowane.
            */

            Console.WriteLine("Zadanie 2")
            char v1 = 'A';
            char v2 = 'B';
            char v3 = 'C';
            Console.WriteLine($"\r\n{v3}{v2}{v1}");

            //Zadanie 3
            /* Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość 
               przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())
            */

            Console.WriteLine($"\r\nZadanie 3");
            Console.WriteLine("Podaj szerokość prostokąta:");
            string width = Console.ReadLine();
            int givenWidth;
            Int32.TryParse(width, out givenWidth);

            Console.WriteLine("Podaj długość prostokąta:");
            string length = Console.ReadLine();
            int givenLength;
            Int32.TryParse(length, out givenLength);

            double sLength = Math.Pow(givenLength, 2);
            double sWidth = Math.Pow(givenWidth, 2);
            double diagonal = Math.Pow(sWidth + sLength, 0.5);

            Console.WriteLine($"\r\nDługość przekątnej danego prostokąta wynosi {diagonal}");

            //Zadanie 4
            /* Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie 
               przypiszesz im następujące wartości:
                a. 10
                b. Szkoła Dotneta
                c. 12,5
               Pamiętaj o użyciu poprawnych typów danych.
            */

            int a;
            string b;
            double c;

            a = 10;
            b = "Szkoła Dotneta";
            c = 12.5;

            //Zadanie 5
            /* Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko, 
               numer telefonu, adres email, wzrost, waga (np. 85,7), itp (postaraj się wymyślić jak najwięcej) 
               i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody: 
               typDanych.Parse(odpowiedźOdUżytkownika).
            */

            Console.WriteLine($"\r\nZadanie 5");
            Console.WriteLine("Podaj imię:");
            string givenName = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko:");
            string givenSurname = Console.ReadLine();

            Console.WriteLine("Podaj numer telefonu:");
            string givenPhoneNumber = Console.ReadLine();

            Console.WriteLine("Podaj adres email:");
            string eMail = Console.ReadLine();

            Console.WriteLine("Podaj wzrost:");
            string height = Console.ReadLine();
            double givenHeight = Double.Parse(height);

            Console.WriteLine("Podaj wagę:");
            string weight = Console.ReadLine();
            double givenWeight = Double.Parse(weight);

            Console.WriteLine("Podaj wiek:");
            string yourAge = Console.ReadLine();
            int givenAge = Int32.Parse(yourAge);

            Console.WriteLine("Podaj płeć (M/K):");
            string yourGender = Console.ReadLine();
            char givenGender = Char.Parse(yourGender);

            Console.WriteLine("\r\nPodsumowanie:");
            Console.WriteLine($"{givenName} {givenSurname}");
            Console.WriteLine($"Telefon: {givenPhoneNumber}");
            Console.WriteLine($"eMail: {eMail}");
            Console.WriteLine($"Wzrost: {givenHeight}");
            Console.WriteLine($"Waga: {givenWeight}");
            Console.WriteLine($"Wiek: {givenAge}");
            Console.WriteLine($"Płeć: {givenGender}");

            Console.ReadLine();


        }
    }
}