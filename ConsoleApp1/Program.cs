using System.Runtime.ExceptionServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VowelSwitch("pinkfairyarmadillo"));
        }

        static string VowelSwitch(string n)
        {
            char[] str = n.ToArray();
            HashSet<int> touchedIndexes = new HashSet<int>();
            HashSet<char> vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i])){
                    char tempC = str[i];
                    for (int j = str.Length - 1; j >= 0; j--)
                    {
                        if (vowels.Contains(str[j]) && !touchedIndexes.Contains(j) && !touchedIndexes.Contains(i))
                        {
                            str[i] = str[j];
                            str[j] = tempC;
                            touchedIndexes.Add(i);
                            touchedIndexes.Add(j);
                        }
                    }
                }
            }
            n = "";
            foreach (char c in str)
            {
                n += c;
            }
            return n;
        }
    }
}
