namespace ProjectEuler
{
    internal class Problem004
    {

        static void Main(string[] args)
        {
            int largestPalindrome = 0;

            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    int product = i * j;

                    string productString = product.ToString();
                    string reverseProduct = "";

                    for (int k = productString.Length - 1; k >= 0; k--)
                    {
                        reverseProduct += productString[k];
                    }

                    largestPalindrome = (productString == reverseProduct && product > largestPalindrome) ? product : largestPalindrome;
                }
            }

            Console.WriteLine(largestPalindrome);
        }
    }
}