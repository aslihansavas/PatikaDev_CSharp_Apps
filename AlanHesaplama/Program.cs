namespace AlanHesaplama;

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometrik şekli seçin (Daire, Üçgen, Kare, Dikdörtgen):");
            string shape = Console.ReadLine().ToLower();

            double result = 0;

            switch (shape)
            {
                case "daire":
                    result = CalculateCircle();
                    break;
                case "üçgen":
                    result = CalculateTriangle();
                    break;
                case "kare":
                    result = CalculateSquare();
                    break;
                case "dikdörtgen":
                    result = CalculateRectangle();
                    break;
                default:
                    Console.WriteLine("Geçersiz şekil.");
                    return;
            }

            Console.WriteLine($"Hesaplanmak istenen boyutu seçin (Çevre, Alan):");
            string operation = Console.ReadLine().ToLower();

            switch (operation)
            {
                case "çevre":
                    Console.WriteLine($"Seçilen şeklin çevresi: {result}");
                    break;
                case "alan":
                    Console.WriteLine($"Seçilen şeklin alanı: {result}");
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem.");
                    break;
            }
        }

        static double CalculateCircle()
        {
            Console.WriteLine("Dairenin yarıçapını girin:");
            double radius = Convert.ToDouble(Console.ReadLine());
            return Math.PI * radius * radius; // Alanı hesapla
        }

        static double CalculateTriangle()
        {
            Console.WriteLine("Üçgenin taban uzunluğunu girin:");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Üçgenin yüksekliğini girin:");
            double height = Convert.ToDouble(Console.ReadLine());
            return 0.5 * baseLength * height; // Alanı hesapla
        }

        static double CalculateSquare()
        {
            Console.WriteLine("Karenin bir kenar uzunluğunu girin:");
            double side = Convert.ToDouble(Console.ReadLine());
            return side * side; // Alanı hesapla
        }

        static double CalculateRectangle()
        {
            Console.WriteLine("Dikdörtgenin uzun kenar uzunluğunu girin:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin kısa kenar uzunluğunu girin:");
            double width = Convert.ToDouble(Console.ReadLine());
            return length * width; // Alanı hesapla
        }
    }
