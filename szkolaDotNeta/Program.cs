using System;

namespace szkolaDotNeta
{
    class Program
    {
        public static void Main(string[] args)
        {
            QuestTwo();
            QuestThree();
        }

        public static void QuestOne()
        {
            //Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy.
            //Dane które chcesz przetrzymywać to:
            //a.Imię,
            //b.Nazwisko
            //c.Wiek
            //d.Płeć(‘m’ albo ‘k’)
            //e.PESEL
            //f.Numer pracownika(np. 2509324094)
            //Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje

            // Wykorzystuje typ referencyjny string do przechowywania łańcuchów znaków
            string firstName = "Michał", lastName = "Kupiński";
            // Wykorzystuje typ zmiennej całkowitoliczbowej int (Przechowuje od -2,147,483,648 do 2,147,483,647)
            int age = 30;
            // Wykorzystuje typ znakowy char do przechowywania jednego znaku
            char sex = 'm';
            // Pesel jak i numer pracownika maja wiecej liczb niż może pomieścić zwykły string więc wykorzystuje ulong
            // bez liczb mniejszych od 0 w zakresie od 0 do 18,446,744,073,709,551,615
            ulong pesel = 12345678912;
            ulong workerID = 2509324094;
        }

        public static void QuestTwo()
        {
            //Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
            //odwrotnej kolejności niż zostały zadeklarowane.

            // Deklaracja 3 zmiennych typu znakowego
            char varOne = 'a', varTwo = 'b', varThree = 'c';

            // Drukowanie na ekranie
            Console.WriteLine($"{varThree} {varTwo} {varOne}");
        }

        public static void QuestThree()
        {
            //Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
            //przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())

            Console.Write("Prosze podać szerokość prostokąta");

            //Wykorzystuje uint ponieważ nie można obliczyć stworzyć prostokątu który ma ujemne wartości
            uint widthRectangle = uint.Parse(Console.ReadLine());

            Console.Write("Prosze podać długość prostokąta");
            uint lengthRectangle = uint.Parse(Console.ReadLine());

            // Wyrukowanie wyniku 
            Console.WriteLine(Math.Sqrt(Math.Pow(widthRectangle, 2) + Math.Pow(lengthRectangle, 2)));
        }

        public static void QuestFour()
        {
            //Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową,
            //a następnie przypiszesz im następujące wartości:
            //
            //a. 10
            //b.Szkoła Dotneta
            //c. 12,5
            //
            //Pamiętaj o użyciu poprawnych typów danych.

            int numberOne;
            double numberTwo;
            string text;

            numberOne = 10;
            text = "Szkoła Dotneta";
            numberTwo = 12.5;
        }

        public static void QuestFive()
        {
            //Napisz program w którym poprosisz użytkownika o jego dane personalne tj.Imię, nazwisko,
            //numer telefonu, adres email, wzrost, waga(np. 85, 7), itp(postaraj się wymyślić jak najwięcej)
            //i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
            //typDanych.Parse(odpowiedźOdUżytkownika).

            Console.Write("Prosze podać imię ");
            string firstName = Console.ReadLine();

            Console.Write("Prosze podać nazwisko ");
            string lastName = Console.ReadLine();

            Console.Write("Prosze podać numer telefonu ");
            ulong phoneNumber = ulong.Parse(Console.ReadLine());

            Console.Write("Prosze podać adres email ");
            string emailAdd = Console.ReadLine();

            // Zakładam że nie może być ktoś wyższy niż 2,5 m
            Console.Write("Prosze podać wzrost w cm");
            byte tall = byte.Parse(Console.ReadLine());

            // Aktualnie najcieższy człowiek świata ma ponad 328 kg wiec decyduje sie na ushort
            Console.Write("Prosze podać wage w kg ");
            ushort weight = ushort.Parse(Console.ReadLine());
        }
    }
}
