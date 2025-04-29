using System.Runtime.CompilerServices;

namespace FindMissingLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(missingLetter(['a','b', 'c', 'e', 'f']));
        }

        static char missingLetter(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {

                }
                else if (array[i + 1] - array[i] == 2)
                {
                    return Convert.ToChar(Convert.ToInt32(array[i] + 1));
                }
            }
            return ' ';
            //return Convert.ToChar(Convert.ToInt32(array[^1] + 1));
        }
    }
}
