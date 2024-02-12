namespace ProjectEuler
{
    internal class Problem006
    {

        static void Main(string[] args)
        {
            int sumSquare = 0;
            int sumNumbers = 0;
            int squareSum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumSquare += i * i;
                sumNumbers += i;
            }

            squareSum = sumNumbers * sumNumbers;

            Console.WriteLine(squareSum - sumSquare);
        }
    }
}