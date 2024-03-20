namespace substitutionAlgoritma;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("String ifadeyi girin: ");
        string input = Console.ReadLine();

        string result = SwapAdjacentChars(input);
        Console.WriteLine("Output: " + result);
    }

    static string SwapAdjacentChars(string str)
    {
        char[] charArray = str.ToCharArray();

        for (int i = 0; i < charArray.Length - 1; i += 2)
        {
            char temp = charArray[i];
            charArray[i] = charArray[i + 1];
            charArray[i + 1] = temp;
        }

        return new string(charArray);
    }
}

