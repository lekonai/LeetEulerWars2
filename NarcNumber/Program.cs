
namespace NarcNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Narcissistic(371));
        }

        static bool Narcissistic(int value)
        {
            double sum = 0;
            for (int i = 0; i < value.ToString().Length; i++)
            {
                Console.WriteLine(Convert.ToInt32(value.ToString()[i]) - 48);
                sum += Math.Pow((Convert.ToInt32(value.ToString()[i]) - 48), value.ToString().Length);
            }
            if (value == sum)
            {
                return true;
            }
            return false;
        }
    }
}
