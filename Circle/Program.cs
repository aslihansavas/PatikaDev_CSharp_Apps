namespace Circle;

using System;

class CircleDrawer
{
    public static void DrawCircle(int radius)
    {
        double angleStep = 0.1; // Açı adımı (radyan cinsinden)
        double radiusSquared = radius * radius;

        for (double angle = 0; angle < 2 * Math.PI; angle += angleStep)
        {
            int x = (int)Math.Round(radius * Math.Cos(angle));
            int y = (int)Math.Round(radius * Math.Sin(angle));

            Console.SetCursorPosition(radius + x, radius + y);
            Console.Write("*");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Dairenin yarıçapını girin: ");
        int radius;

        while (!int.TryParse(Console.ReadLine(), out radius) || radius <= 0)
        {
            Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir tam sayı girin.");
            Console.Write("Dairenin yarıçapını girin: ");
        }

        Console.Clear(); // Önceki çizimlerin temizlenmesi için konsolu temizle

        CircleDrawer.DrawCircle(radius);

        Console.ReadLine(); // Konsolun kapatılmaması için bekleme
    }
}
