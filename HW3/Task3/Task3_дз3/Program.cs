// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

class Converter
{
    private decimal usd;
    private decimal eur;
    
    public Converter(decimal usd, decimal eur)
    {
        this.usd = usd;
        this.eur = eur;
    }

    public decimal UsdToUah(decimal sum)
    {
        return sum * usd;
    }
    public decimal UahToUsd(decimal sum)
    {
        return sum / usd;
    }
    
    public decimal EurToUah(decimal sum)
    {
        return sum * eur;
    }
    
    
    public decimal UahToEur(decimal sum)
    {
        return sum / eur;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the currency of usd and eur");
        decimal usd = Convert.ToDecimal(Console.ReadLine());
        decimal eur = Convert.ToDecimal(Console.ReadLine());
        Converter converter = new Converter(usd, eur);
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Convert usd to uah");
        Console.WriteLine("2. Convert uah to usd");
        Console.WriteLine("3. Convert eur to uah");
        Console.WriteLine("4. Convert uah to eur");
        Console.WriteLine("0. Stop the program");
        int i = 0;
        do
        {
            Console.WriteLine("Command:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sum:");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine(converter.UsdToUah(sum) + "uah");
                    break;
                case 2:
                    Console.WriteLine(converter.UahToUsd(sum) + "usd");
                    break;
                case 3:
                    Console.WriteLine(converter.EurToUah(sum) + "uah");
                    break;
                case 4:
                    Console.WriteLine(converter.UahToEur(sum) + "eur");
                    break;
                case 0:
                    return;
            }

        } while (true);

    }
}