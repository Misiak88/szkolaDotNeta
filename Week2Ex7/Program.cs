using System;

namespace Week2Ex7
{
    class Program
    {
        public static void Main(string[] args)
        {
            //QuestOne();
            //QuestTwo();
            //QuestThree();
            //QuestFour();
            //QuestFive();
            //QuestSix();
            //QuestSeven();
            //QuestEight();
            //QuestNine();
            //QuestTen();
            //QuestEleven();
            //QuestTwelve();
            //QuestThirteen();

        }

        public static void QuestOne()
        {
            //1.Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są
            //    one równe czy nie.

            // Z wykorzeystaniem operatora trójargumentowego

            int a = 5, b = 5;
            Console.WriteLine(a == b ? $"{a} i {b} są sobie równe" : $"{a} i {b} są sobie nie równe");
        }

        public static void QuestTwo()
        {
            //2.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
            //jest parzysta czy nieparzysta.
            //Dane testowe : 15
            //Rezultat w terminalu:
            //15 jest liczbą nieparzystą

            Console.Write("Prosze o podanie liczby calkowitej ");
            int testNumber = int.Parse(Console.ReadLine());

            // Z wykorzeystaniem operatora trójargumentowego
            Console.WriteLine(testNumber % 2 == 0 ? $"{testNumber} jest liczba parzystą" : $"{testNumber} jest liczba nieparzystą");
        }

        public static void QuestThree()
        {
            //3.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
            // jest dodatnia czy ujemna.
            // Dane testowe : 14
            //Rezultat w terminalu:
            //14 jest liczbą dodatnią

            Console.Write("Prosze o podanie liczby calkowitej ");
            int testNumber = int.Parse(Console.ReadLine());

            // Z wykorzeystaniem operatora trójargumentowego
            Console.WriteLine(testNumber >= 0 ? $"{testNumber} jest liczbą dodatnia" : $"{testNumber} jest liczbą ujemna");
        }

        public static void QuestFour()
        {
            //4.Napisz program w C#, który sprawdzi czy podany przez użytkownika rok
            //jest rokiem przestępnym.
            //Dane testowe : 2016
            //Rezultat w terminalu:
            //2016 jest rokiem przestępnym

            Console.Write("Prosze o podanie roku ");
            int testNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(testNumber % 4 == 0 && testNumber % 100 != 0 || testNumber % 400 == 0
                ? $"{testNumber} jest rokiem przestępnym" : $"{testNumber} nie jest rokiem przestępnym");
        }

        public static void QuestFive()
        {
            //5.Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek
            //uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,
            //prezydenta.
            //Dane testowe : 21
            //Rezultat w terminalu:
            //Możesz zostać posłem

            // stałe przechowujące minimalny wiek posła, premiera, senatora.
            const byte ageDeputy = 21, agePrimeMinister = 21, ageSenator = 30;

            Console.Write("Prosze podaj swój wiek ");
            byte ageUser = byte.Parse(Console.ReadLine());

            // Petla warunkowa if else

            if (ageUser >= ageDeputy && ageUser < ageSenator )
            {
                Console.WriteLine("Możesz zostać posłem i premierem");
            }
            else if (ageUser >= ageSenator)
            {
                Console.WriteLine("Możesz zostać posłem, premierem lub senatorem");
            }
            else
            {
                Console.WriteLine("Jesteś za młody");
            }
        }

        public static void QuestSix()
        {
            //6.Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu
            //wymyśloną kategorię wzrostu.
            //Dane testowe : 140
            //Rezultat w terminalu:
            //Jesteś krasnoludem

            const ushort hobbit = 90, dwarf = 140, orc = 160, human = 180, elf = 200;

            Console.WriteLine("Prosze podac wzrost");
            ushort tallUser = ushort.Parse(Console.ReadLine());

            if (tallUser <= hobbit)
            {
                Console.WriteLine("Jesteś hobbitem");
            }
            else if (tallUser > hobbit && tallUser <= dwarf)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if (tallUser > dwarf && tallUser <= orc)
            {
                Console.WriteLine("Jesteś Orkiem");
            }
            else if (tallUser > orc && tallUser <= human)
            {
                Console.WriteLine("Jesteś Czlowiekiem");
            }
            else if (tallUser > human && tallUser <= elf)
            {
                Console.WriteLine("Jesteś Elfem");
            }
            else if (tallUser > elf)
            {
                Console.WriteLine("Jesteś Trolem");
            }
        }

        public static void QuestSeven()
        {
            //7.Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi,
            //która jest największa
            //Dane testowe:
            //25
            //63
            //79
            //Rezultat w terminalu:
            //79 jest największa z podanych

            Console.WriteLine("Podaj 3 liczby, po wprowadzeniu liczby wprowadz enter");
            int varOne = int.Parse(Console.ReadLine());
            int varTwo = int.Parse(Console.ReadLine());
            int varThree = int.Parse(Console.ReadLine());

            int vartemp = 0;

            // zeby nie pisać 6 warunkow sprawdzajacych ktora z liczb jest najwieksza, najpierw posortuje liczby od najmniejszej do najwiekszej
            // ostatnia wartość bedzie najwieksza nawet jak sie liczby powtorza.
            if (varOne > varTwo)
            {
                vartemp = varOne;
                varOne = varTwo;
                varTwo = vartemp;
            }
            if (varTwo > varThree)
            {
                vartemp = varTwo;
                varTwo = varThree;
                varThree = vartemp;
            }
            if (varOne > varTwo)
            {
                vartemp = varOne;
                varOne = varTwo;
                varTwo = vartemp;
            }

            Console.WriteLine($"{varThree} jest największa liczba z podanych");
        }

        public static void QuestEight()
        {
            //8.Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce
            //na studiach wg.Następujących kryteriów:
            //Wynik z Matury z matematyki powyżej 70
            //Wynik z fizyki powyżej 55
            //Wynik z chemii powyżej 45
            //Łączny wynik z 3 przedmiotów powyżej 180
            //Albo Wynik z matematyki i jednego przedmiotu powyżej 150

            const ushort minScore = 180, mathAndMaxScore = 150;
            

            Console.WriteLine("Podaj wynik z matematyki");
            ushort resMath = ushort.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wynik z fizyki");
            ushort resPhys = ushort.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wynik z chemii");
            ushort resChem = ushort.Parse(Console.ReadLine());

            ushort sumResault = (ushort)(resMath + resPhys + resChem);

            // zakładam że najwikeszy wynik jest z fizyki a potem porównuje czy aby na pewno.
            ushort maxScoreSub = resPhys;
            if (resChem > resPhys)
            {
                maxScoreSub = resChem;
            }
            
            if (sumResault > minScore)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if (resMath + maxScoreSub > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
            }


        }

        public static void QuestNine()
        {
            //9.Napisz program, który odczyta temperaturę I zwróci nazwę jak w
            //poniższych kryteriach
            //Temp < 0 – cholernie piździ
            //Temp 0 – 10 – zimno
            //Temp 10 – 20 – chłodno
            //Temp 20 – 30 – w sam raz
            //Temp 30 – 40 – zaczyna być słabo, bo gorąco
            //Temp >= 40 – a weź wyprowadzam się na Alaskę.
            //Dane testowe : 41
            //Rezultat w terminalu:
            //a weź wyprowadzam się na Alaskę.

            Console.WriteLine("Prosze podać temperature");
            int tempUser = int.Parse(Console.ReadLine());

            if (tempUser < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (tempUser >= 0 && tempUser < 10)
            {
                Console.WriteLine("zimno");
            }
            else if (tempUser >= 10 && tempUser < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (tempUser >= 20 && tempUser < 30)
            {
                Console.WriteLine("w sam razw sam raz");
            }
            else if (tempUser >= 30 && tempUser < 40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else if (tempUser >= 40)
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę.");
            }


        }

        public static void QuestTen()
        {
            //Deklaracja trzech zmiennych z drukowaniem tekstu na ekranie
            Console.WriteLine("Podaj pierwsza liczbe całkowitą");
            int numberOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe całkowitą");
            int numberTwo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe całkowitą");
            int numberThree = Int32.Parse(Console.ReadLine());

            int counterTriangle = 0;

            if (numberOne + numberTwo > numberThree)
            {
                counterTriangle++;
            }
            if (numberOne + numberThree > numberTwo)
            {
                counterTriangle++;
            }
            if (numberTwo + numberThree > numberOne)
            {
                counterTriangle++;
            }

            if (counterTriangle == 3)
            {
                Console.WriteLine("Tak!! Z podanych wartości możesz utworzyć trójkąt");
            }
            else
            {
                Console.WriteLine("Z podanych wartości nie można utworzyć trójkąta");
            }
        }

        public static void QuestEleven()
        {
            Console.WriteLine("Podaj ocene ucznia");
            int pupilScore = int.Parse(Console.ReadLine());

            switch (pupilScore)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Podałeś niewłaściwy argument");
                    break;
            }
        }

        public static void QuestTwelve()
        {
            //12.Napisz program, który pobierze numer dnia tygodnia i wyświetli jego
            //nazwę
            //Dane testowe: 4
            //Rezultat w terminalu:
            //Czwartek

            Console.WriteLine("Prosze podać liczbę wszysukiwanego dnia");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takeigo dnia tygodnia");
                    break;
            }
        }

        public static void QuestThirteen()
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            int userVarOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Drugą liczbę:");
            int userVarTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj numer operacji do wykonania:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine($"Twój wynik to {userVarOne + userVarTwo}");
                    break;
                case 2:
                    Console.WriteLine($"Twój wynik to {userVarOne - userVarTwo}");
                    break;
                case 3:
                    Console.WriteLine($"Twoj wynik to {userVarOne * userVarTwo}");
                    break;
                case 4:
                    if (userVarTwo == 0)
                    {
                        Console.WriteLine("Nie można dzielić przez 0");
                    }
                    else
                    {
                        Console.WriteLine($"Twoj wynik to {userVarOne / userVarTwo}");
                    }
                    break;
                default:
                    Console.WriteLine("Podałeś niewłaściwy argument wyboru.");
                    break;
            }
        }

    }
}
