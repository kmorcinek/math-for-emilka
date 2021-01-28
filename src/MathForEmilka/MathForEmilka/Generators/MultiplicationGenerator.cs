namespace KMorcinek.MathForEmilka.Generators
{
    public class MultiplicationGenerator : IEquationGenerator
    {
        public Equation Generate()
        {
            int first = StaticRandom.Instance.Next(7) + 2;
            int second = StaticRandom.Instance.Next(7) + 2;

            return new Equation()
            {
                First = first,
                Second = second,
                Symbol = "*",
                Result = first * second,
            };
        }
    }
}