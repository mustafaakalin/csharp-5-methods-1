// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


public class Program
{
    public static double Toplama(double a, double b)
    {
        return a + b;
        // Console.WriteLine("Toplama işlemi sonucu : " + (a + b));
    }

    public static double Cikarma(double a, double b)
    {
        return a - b;
    }

    public static double Carpma(double a, double b)
    {
        return a * b;
    }


    public static double Bolme(double a, double b)
    {
        return a / b;
    }


    public static void Main(string[] args)
    {
        Console.WriteLine("işlem yapmak için birinci sayıyı giriniz : ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("işlem yapmak için ikinci sayıyı giriniz : ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("ISTENEN ISLEMIN PARAMETRE DEGERLERI : " + "sayi 1: " + sayi1 + ", " + "sayi 2 : " + sayi2);

        double sonucToplama = Toplama(sayi1, sayi2);
        Console.WriteLine("Toplama işlemi sonucu : " + sonucToplama);
        double sonucCikarma = Cikarma(sayi1, sayi2);
        Console.WriteLine("Çıkarma işlemi sonucu : " + sonucCikarma);
        double sonucCarpma = Carpma(sayi1, sayi2);
        Console.WriteLine("Çarpma işlemi sonucu : " + sonucCarpma);
        double sonucBolme = Bolme(sayi1, sayi2);
        Console.WriteLine("Bölme işlemi sonucu : " + sonucBolme);


    }
}
