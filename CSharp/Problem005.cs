namespace ProjectEuler
{
    internal class Problem005
    {

        static void Main(string[] args)
        {
            int smallestNumber = 20;

            bool divisibleByAll = false;

            while (!divisibleByAll)
            {
                divisibleByAll = true;

                for (int i = 1; i <= 20; i++)
                {
                    if (smallestNumber % i != 0)
                    {
                        divisibleByAll = false;
                        break;
                    }
                }

                smallestNumber++;
            }

            Console.WriteLine(smallestNumber);
        }
    }
}