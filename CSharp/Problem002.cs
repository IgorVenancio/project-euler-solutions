namespace ProjectEuler
{
    internal class Problem002
    {

        static void Main(string[] args)
        {
            int sum = 0;

            int previousNumber = 0;
            int currentNumber = 1;

            while (currentNumber <= 4000000)
            {
                if (currentNumber % 2 == 0)
                {
                    sum += currentNumber;
                }

                int temp = previousNumber;
                previousNumber = currentNumber;
                currentNumber += temp;
            }

            Console.WriteLine(sum);
        }
    }
}