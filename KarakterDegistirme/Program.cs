namespace KarakterDegistirme;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir string ifade girin:");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Girdi geçersiz.");
                return;
            }

            string swappedString = SwapFirstAndLast(input);
            Console.WriteLine($"Değiştirilmiş string ifade: {swappedString}");
        }

        static string SwapFirstAndLast(string input)
        {
            // String ifadenin uzunluğunu kontrol et
            if (input.Length <= 1)
                return input;

            // İlk ve son karakterleri yer değiştir
            char[] characters = input.ToCharArray();
            char first = characters[0];
            char last = characters[input.Length - 1];

            characters[0] = last;
            characters[input.Length - 1] = first;

            return new string(characters);
        }
    }
}
