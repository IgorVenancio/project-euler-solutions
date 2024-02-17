namespace ProjectEuler
{
    internal class Problem010
    {

        static void Main(string[] args)
        {
            long sum = 0, limit = 2000000;

            for (int i = 2; i < limit; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }

            static bool IsPrime(int number)
            {
                if (number <= 1) return false;
                if (number == 2) return true;
                if (number % 2 == 0) return false;

                var boundary = (int)Math.Floor(Math.Sqrt(number));

                for (int i = 3; i <= boundary; i += 2)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            Console.WriteLine(sum);
        }
    }
}