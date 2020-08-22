using System;
using System.Linq;

namespace Week2Ex8
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
            QuestTen();

        }

        public static void QuestOne()
        {
            //1.Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.

            int counter = 0;
            for (int i = 2; i <= 100; i++)
            {
                int divisorFlag = 0;

                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divisorFlag++;
                    }
                    if (divisorFlag > 1)
                    {
                        break;
                    }
                }
                if (divisorFlag == 1)
                {
                    counter++;
                }
            }
            Console.WriteLine("Liczb pierwszych w zakresie <0;100> = " + counter);
        }

        public static void QuestTwo()
        {
            //Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z
            //zakresu 0 – 1000.

            const int endRange = 1000;

            int counter = 0;
            do
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter + " ");
                }
                counter++;
            } while (counter != endRange + 1);

        }

        public static void QuestThree()
        {
            //3.Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.

            Console.WriteLine("Podaj długość ciągu Fibonacciego, który zostanie wyświetlony na ekranie");
            int fibonacciegoLenght = int.Parse(Console.ReadLine());

            int a = 0, b = 1;

            for (int i = 0; i < fibonacciegoLenght; i++)
            {
                Console.Write(a + " | ");
                b += a;
                a = b - a;
            }
        }

        public static void QuestFour()
        {
            //4.Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej
            // liczby w formie jak poniżej:
            //1
            //2 3
            //4 5 6
            //7 8 9 10

            Console.WriteLine("Podaj liczbe całkowita");
            int varUnser = int.Parse(Console.ReadLine());

            for (int i = 1, counter = 1, space = 1; i <= varUnser; i++)
            {
                if (counter < space)
                {
                    Console.Write(i + " ");
                    counter++;
                }
                else
                {
                    Console.Write(i + "\r\n");
                    counter = 1;
                    space++;
                }
            }
        }

        public static void QuestFive()
        {
            //5.Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }

        }

        public static void QuestSix()
        {
            //Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
            //1 + ½ +1 / 3 + ¼

            double sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum += 1 / (double)i;
            }

            Console.WriteLine(sum);
        }

        public static void QuestSeven()
        {
            //   Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
            //   przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
            //    *
            //   ***
            //  *****
            // *******
            //*********
            // *******
            //  *****
            //   ***
            //    *


            Console.WriteLine("podaj wielkość diamentu");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x - i; j++)
                {
                    Console.Write(" ");
                }

                for (int z = i; z <= 2 * i - 1; z++)
                {
                    Console.Write("*");
                }

                for (int z = 0; z < i - 1; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = x; i >= 0; i--)
            {
                for (int j = 0; j < x - i; j++)
                {
                    Console.Write(" ");
                }

                for (int z = i; z <= 2 * i - 1; z++)
                {
                    Console.Write("*");
                }

                for (int z = 0; z < i - 1; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void QuestEight()
        {
            Console.WriteLine("Prosze podać swój ciąg znaków");
            string textUnser = Console.ReadLine();

            for (int i = textUnser.Length - 1; i >= 0; i--)
            {
                Console.Write(textUnser[i]);
            }
        }

        public static void QuestNine()
        {
            Console.WriteLine("\tKonwerter liczb dziesiętnych na liczbę binarną \n**********************************" +
                              "\nPodaj liczbe dziesietną");
            int varUnser = int.Parse(Console.ReadLine());

            string varBin = "";


            for (int i = varUnser; i > 0; i /= 2)
            {
                varBin += Convert.ToString(i % 2);
            }

            string varBinReverse = new string(varBin.Reverse().ToArray());


            Console.WriteLine(varBinReverse);
        }

        public static void QuestTen()
        {
            //10.Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb

            Console.WriteLine("Podaj pierwsza liczbe");
            int varOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj druga liczbe");
            int varTwo = int.Parse(Console.ReadLine());

            int NWW = varOne * varTwo;

            while (varTwo != 0)
            {
                int temp = varTwo;
                varTwo = varOne % varTwo;
                varOne = temp;
            }

            NWW /= varOne;

            Console.WriteLine(NWW);
        }
    }
}
