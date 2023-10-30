using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girilen sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Girilen sayı tektir.");
        }

        Console.ReadKey();
    }
}
