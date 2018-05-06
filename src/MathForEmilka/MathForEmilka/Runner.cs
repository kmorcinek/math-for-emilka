using System;
using System.Threading;

namespace KMorcinek.MathForEmilka
{
    public class Runner
    {
        public void Run()
        {
            while (true)
            {
                Equation equation = new AdditionGenerator().Generate();
                Console.WriteLine();

                while (true)
                {
                    Console.Write($"{equation.First} {equation.Symbol} {equation.Second} = ");

                    string line = Console.ReadLine();

                    if (int.TryParse(line, out int result) && result == equation.Result)
                    {
                        Console.WriteLine("Dobrze!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sprobuj jeszcze raz");
                    }
                }
            }
        }
    }
}