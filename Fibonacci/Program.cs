namespace Fibonacci;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Fibonacci serisinin derinliğini girin: ");
        int depth = int.Parse(Console.ReadLine());

        try
        {
            double average = FibonacciCalculator.CalculateAverage(depth);
            Console.WriteLine($"Fibonacci serisinin ilk {depth} rakamının ortalaması: {average}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Hata: {e.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Hata: Geçersiz giriş. Lütfen pozitif bir tam sayı girin.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Hata: Girdiğiniz değer çok büyük.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Beklenmeyen bir hata oluştu: {e.Message}");
        }
    }
}

class FibonacciCalculator{

    public static double CalculateAverage(int depth){
        if (depth <= 0)
        {
            throw new ArgumentException("Derinlik değeri pozitif bir sayı olmalıdır !");
        }
        int[] fibonacciSeries=GenerateFibonacciSeries(depth);
        double sum =0;
        foreach (int num in fibonacciSeries)
        {
            sum += num;
        }

        return sum / depth;
    }

    private static int[] GenerateFibonacciSeries(int depth)
    {
        int[] series = new int[depth];

        series[0] = 0;
        if (depth > 1)
            series[1] = 1;

        for (int i = 2; i < depth; i++)
        {
            series[i] = series[i - 1] + series[i - 2];
        }

        return series;
    }
}
