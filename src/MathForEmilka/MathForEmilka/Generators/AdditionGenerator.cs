namespace KMorcinek.MathForEmilka.Generators
{
    public class AdditionGenerator : IEquationGenerator
    {
        public Equation Generate()
        {
            int first = StaticRandom.Instance.Next(20);
            int second = StaticRandom.Instance.Next(20);

            return new Equation()
            {
                First = first,
                Second = second,
                Symbol = "+",
                Result = first + second,
            };
        }
    }
}