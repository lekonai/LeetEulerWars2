using System.Diagnostics.Tracing;
using System.Text;

namespace Weird_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToWeirdCase("This is a weird sentence"));

        }
        public static string ToWeirdCase(string s)
        {
            string end = "";
            string[] words = s.Split(' ');
            bool addGap = false;
            if (words.Length > 1)
            {
                addGap = true;
            }
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    
                    if (j % 2 == 0)
                    {
                        end += words[i][j].ToString().ToUpper();
                    }
                    else
                    {
                        end += words[i][j].ToString().ToLower();
                    }
                }
                if (addGap && i != words.Length - 1)
                {
                    end += " ";
                }
            }
            return end;
        }
    }
}
