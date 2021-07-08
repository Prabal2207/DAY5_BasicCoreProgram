using System;

namespace AlphabetVowelorConsonent
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Alphabet");
            char a = Convert.ToChar(Console.ReadLine());
            vowelOrConsonant(a);
        }
        static void vowelOrConsonant(char x)
        {
            if (x == 'a' || x == 'e' || x == 'i' ||
                              x == 'o' || x == 'u')
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
        }
    }
}
