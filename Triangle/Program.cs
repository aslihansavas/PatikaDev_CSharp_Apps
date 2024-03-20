namespace Triangle;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Üçgenin boyutunu girin: ");
        int size;

        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir tam sayı girin.");
            Console.Write("Üçgenin boyutunu girin: ");
        }

        TriangleDrawer.DrawTriangle(size);
    }
}
class TriangleDrawer
{
    public static void DrawTriangle(int size)
    {
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}