namespace ProjectEuler
{
    internal class Problem009
    {

        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;
            bool found = false;

            for (a = 1; a < 1000; a++)
            {
                for (b = a + 1; b < 499; b++)
                {
                    c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                    if (a + b + c == 1000.0)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }

            Console.WriteLine(a * b * c);
        }
    }
}