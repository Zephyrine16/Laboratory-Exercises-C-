using System;
using System.Text;

class ArrayAndStrings
{
    static void Main(String[] args)
    {
        StringBuilder apples = new StringBuilder("Apples");
        apples.Append(" are nutritious,");
        apples.Append(" may support weight loss,");
        apples.Append(" could be good for your heart,");
        apples.Append(" are linked to a lower chances of diabetes,");
        apples.Append(" and may promote gut health.\nSo");

        string result = apples.ToString();
        Console.WriteLine(result);
        
        Console.WriteLine("Welcome to Apple Store!");
        Console.Write("Enter the number of apples you want to purchase: ");
        int apple = int.Parse(Console.ReadLine());

        double applePrice = 32.50 * apple;
        double roundedApplePrice = Math.Ceiling(applePrice);
        
        Console.WriteLine($"The total price of {apple} is {applePrice:F2}.");
        Console.Write($"The value of the converted price is {roundedApplePrice}.");
    }
}