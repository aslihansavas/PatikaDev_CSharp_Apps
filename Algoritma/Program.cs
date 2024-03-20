namespace Algoritma;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("String ve index değerini virgülle ayırarak girin: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(',');
        if (parts.Length != 2)
        {
            Console.WriteLine("Hatalı giriş!");
            return;
        }

        string str = parts[0].Trim();
        if (string.IsNullOrEmpty(str))
        {
            Console.WriteLine("String boş olamaz!");
            return;
        }

        int index;
        if (!int.TryParse(parts[1].Trim(), out index) || index < 0 || index >= str.Length)
        {
            Console.WriteLine("Geçersiz index!");
            return;
        }

        string result = RemoveCharAtIndex(str, index);
        Console.WriteLine("Output: " + result);
    }

    static string RemoveCharAtIndex(string str, int index)
    {
        return str.Remove(index, 1);
    }
}

