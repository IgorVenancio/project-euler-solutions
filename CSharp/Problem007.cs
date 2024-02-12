namespace ProjectEuler
{
    internal class Problem007
    {

        static void Main(string[] args)
        {
            int primeNumber = 2;
            int i = 1;

            while (i < 10001)
            {   
                if (primeNumber == 2)
                {
                    primeNumber++;
                    i++;
                }
                else
                {
                    bool isPrime = true;

                    primeNumber += 2;

                    double sqrt = Math.Sqrt(primeNumber);

                    for (int j = 3; j <= sqrt; j += 2)
                    {
                        if (primeNumber % j == 0)
                        {
                            isPrime = false;
                            break;
                        }                        
                    }

                    i += isPrime ? 1 : 0;
                }
            }

            Console.WriteLine(primeNumber);
    }
}