using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Perimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Perimeter(5));
        }
        static BigInteger Perimeter(int n)
        {
            BigInteger total = 0;
            List<BigInteger> fibonacci = new List<BigInteger>() { 1, 1 };
            for (int i = 2; i < n + 1; i++)
            {
                fibonacci.Add(fibonacci[i - 2] + fibonacci[i - 1]);
            }
            foreach(BigInteger i in fibonacci)
            {
                Console.WriteLine(i);
                total += i;
            }

            Console.WriteLine("Total: {0}", total);
            return total * 4;

        }
    }
}
