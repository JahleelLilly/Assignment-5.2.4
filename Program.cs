namespace Assignment_5._2._4
{
    class Program
    {
        static bool IsPalindrome(string s)
        {

            if (s.Length <= 1)
                return true;

            if (char.ToLower(s[0]) != char.ToLower(s[s.Length - 1]))
                return false;

            return IsPalindrome(s.Substring(1, s.Length - 2));
        }

        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string input = Console.ReadLine();

            bool isPalindrome = IsPalindrome(input);
            if (isPalindrome)
                Console.WriteLine("The string is Palindrome.");
            else
                Console.WriteLine("The string is not Palindrome.");
        }

    }
}

