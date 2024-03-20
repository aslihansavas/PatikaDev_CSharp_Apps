namespace IntegerPairSum;

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer ikilileri girin (boşlukla ayırarak):");
            string input = Console.ReadLine();
            
            string[] pairs = input.Split(' ');

            Dictionary<int, int> pairSums = new Dictionary<int, int>();

            for (int i = 0; i < pairs.Length; i += 2)
            {
                int first = int.Parse(pairs[i]);
                int second = int.Parse(pairs[i + 1]);
                int sum = first + second;

                if (pairSums.ContainsKey(sum))
                {
                    int existingSum = pairSums[sum];
                    if (first == second)
                    {
                        int squaredSum = existingSum * existingSum;
                        Console.Write($"{squaredSum} ");
                    }
                    else
                    {
                        Console.Write($"{sum} ");
                    }
                }
                else
                {
                    pairSums.Add(sum, sum);
                    Console.Write($"{sum} ");
                }
            }
        }
    }
