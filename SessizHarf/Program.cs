namespace SessizHarf;

class Program
{
    static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir string ifade girin:");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            Console.WriteLine("Sonuç:");

            foreach (var word in words)
            {
                Console.Write(HasConsecutiveConsonants(word) + " ");
            }
        }

        static bool HasConsecutiveConsonants(string word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                char currentChar = word[i];
                char nextChar = word[i + 1];

                if (IsConsonant(currentChar) && IsConsonant(nextChar))
                {
                    return true;
                }
            }

            return false;
        }

        static bool IsConsonant(char c)
        {
            // Sessiz harfleri kontrol et
            return !("aeiouAEIOU".Contains(c));
        }
    }
}
