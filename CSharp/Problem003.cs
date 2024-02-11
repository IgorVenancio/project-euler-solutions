namespace ProjectEuler
{
    internal class Problem003
    {

        static void Main(string[] args)
        {
            long number = 600851475143;
            int largestPrimeFactor = 0;

            while (number != 1)
            {
                int primeNumber = 2;

                // Finds next prime number
                while (number % primeNumber != 0)
                {
                    primeNumber += primeNumber == 2 ? 1 : 2;

                    double sqrt = Math.Sqrt(primeNumber);

                    for (int j = 3; j <= sqrt; j += 2)
                    {
                        if (primeNumber % j != 0)
                        {
                            break;
                        }
                    }
                }

                number = number / primeNumber;

                if (primeNumber > largestPrimeFactor)
                {
                    largestPrimeFactor = primeNumber;
                }
            }

            Console.WriteLine(largestPrimeFactor);
        }
    }
}