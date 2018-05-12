namespace KMorcinek.MathForEmilka
{
    public class MultiplicationGenerator
    {
        public Equation Generate()
        {
            int first = StaticRandom.Instance.Next(3) + 2;
            int second = StaticRandom.Instance.Next(3) + 2;

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