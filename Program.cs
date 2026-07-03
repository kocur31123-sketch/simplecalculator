using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplecalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            


       
            
            {
                Console.Write("Podaj pierwszą liczbę: ");
                double a = double.Parse(Console.ReadLine());


                Console.Write("Podaj drugą liczbę: ");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Wybierz działanie (+, -, *, /): ");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();

                double wynik;

                switch (op)
                {
                    case '+':
                        wynik = a + b;
                        break;
                    case '-':
                        wynik = a - b;
                        break;
                    case '*':
                        wynik = a * b;
                        break;
                    case '/':
                        if (b == 0)
                        {
                            Console.WriteLine("Nie można dzielić przez zero.");
                            return;
                        }
                        wynik = a / b;
                        break;
                    default:
                        Console.WriteLine("Nieznane działanie.");
                        return;
                }

                Console.WriteLine($"Wynik: {wynik}");
            }
        }

    }
}

