namespace NotVerySecure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Alphanumeric(""));
        }

        static bool Alphanumeric(string str) // this doesn't work on codewars for some reason, but it works here. strange isn't it
        {
            if (str.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                int charCode = Convert.ToInt32(str[i]);
                if (!( (charCode >= 48 && charCode <= 57) || (charCode >= 92 && charCode <= 122) || (charCode >= 65 && charCode <= 90) )){
                    return false;
                }
            }
            return true;
        }
    }
}
