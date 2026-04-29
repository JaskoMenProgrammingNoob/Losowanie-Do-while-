using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Random los = new Random();
        int min = 0;
        int max = 0;
        int i = 0;
        double suma = 0;
        double srednia;

         do
        {
            int losowa = los.Next(0,100);
            Console.WriteLine($"Liczba losowa: {losowa}");
            i++;
            suma += losowa;
            if (i == 1)
            {
                min = losowa;
                max = losowa;
            }
            else if (min < losowa)
            {
                min = losowa;
            }
            else if (max > losowa)
            {
                max = losowa;
            }
        } while (i < 5); 
        
srednia = suma / 5;
        Console.WriteLine($"Średnia wynosi: {srednia:#.##} ");
        Console.WriteLine($"Liczba maksymalna to: {max}");
        Console.WriteLine($"Liczba minimalna to: {min}");


































    }
}