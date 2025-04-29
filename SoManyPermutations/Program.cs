using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace SoManyPermutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> permas = SinglePermutations("Super");
            for (int i = 0; i < permas.Count; i++)
            {
                Console.WriteLine(permas[i]);
            }
        }
        public static List<string> SinglePermutations(string s)
        {

            //// i know nothing about enumerables and linq, i can do a longer easier solution too but this is just nicer looking init.
            //int factorial = Enumerable.Range(1, s.Length).Aggregate(1, (p, item) => p * item);
            //List<string> perms = new List<string>(); // list of permutations
            //List<char> letters = s.ToList(); // definitive list of letters
            //Random rando = new Random(); // randomiser
            //int currentNum = 0; // the current number
            //do
            //{
            //    string tempString = ""; // temp string to be added
            //    HashSet<int> used = new HashSet<int>(); // what indexes have been used?
            //    bool onward = false; // to move onto the next number?
            //    for (int j = 0; j < letters.Count; j++) // to finish once all have been used
            //    {
            //        do
            //        {
            //            currentNum = rando.Next(letters.Count);
            //            if (!used.Contains(currentNum))
            //            {
            //                used.Add(currentNum);
            //                onward = true;
            //            }
            //            else
            //            {
            //                onward = false;
            //            }
            //        } while (!onward);
            //        tempString += letters[currentNum];
            //        onward = false;
            //    }
            //    if (!perms.Contains(tempString))
            //    {
            //        perms.Add(tempString);
            //    }
            //} while (perms.Count < factorial);

            //return perms;

            // old solution, too inefficient.
            
            //List<string> end = new List<string>();
            //if (s.Length == 1)
            //{
            //    end.Add(s);
            //    return end;
            //}
            //else
            //{
            //    foreach (var c in s) // get head
            //    {
            //        var tail = s.Remove(s.IndexOf(c), 1); 
            //        foreach (var tailPerms in SinglePermutations(tail))
            //        {
            //            end.Add(c + tailPerms); // this is a crazy recursive solution and it outputs beauty 
            //        }
            //    }
            //}
            return end;
        }
    }
}
