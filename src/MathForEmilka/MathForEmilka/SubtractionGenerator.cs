namespace KMorcinek.MathForEmilka
{
    public class SubtractionGenerator
    {
        public Equation Generate()
        {
            int second = StaticRandom.Instance.Next(20);
            int first = StaticRandom.Instance.Next(20) + second;

            return new Equation()
            {
                First = first,
                Second = second,
                Symbol = "-",
                Result = first - second,
            };
        }
    }
}