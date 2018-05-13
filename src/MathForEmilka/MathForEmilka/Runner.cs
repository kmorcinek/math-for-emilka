using System;
using KMorcinek.MathForEmilka.Generators;

namespace KMorcinek.MathForEmilka
{
    public class Runner
    {
        public void Run()
        {
            IEquationGenerator generator = ChooseGenerator();

            while (true)
            {
                Equation equation = generator.Generate();
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

        IEquationGenerator ChooseGenerator()
        {
            Console.Write("Wybierz dzialanie (+ - *): ");

            while (true)
            {
                string line = Console.ReadLine();

                switch (line)
                {
                    case "+":
                        return new AdditionGenerator();
                    case "-":
                        return new SubtractionGenerator();
                    case "*":
                        return new MultiplicationGenerator();
                    default:
                        Console.WriteLine("Nierozpoznany znak, wybierz jeszcze raz (+ - *):");
                        break;
                }
            }
        }
    }
}