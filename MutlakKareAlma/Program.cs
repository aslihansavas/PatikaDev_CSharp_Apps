namespace MutlakKareAlma;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sayıları girin (boşlukla ayırarak):");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            int sumOfDifferences = 0;
            int sumOfSquaredDifferences = 0;

            foreach (var number in numbers)
            {
                int num = int.Parse(number);
                int difference = Math.Abs(num - 67);

                if (num < 67)
                {
                    sumOfDifferences += difference;
                }
                else if (num > 67)
                {
                    sumOfSquaredDifferences += difference * difference;
                }
            }

            Console.WriteLine($"Küçük olanların farklarının toplamı: {sumOfDifferences}");
            Console.WriteLine($"Büyük olanların farklarının mutlak karelerinin toplamı: {sumOfSquaredDifferences}");
    }
}
