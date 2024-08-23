using System;
using System.Collections.Generic;

class DataTypesApp
{
    static void Main()
    {
        //Dictionary for apple tyeps and their prices
        Dictionary<string, double> Items = new Dictionary<string, double>()
        {
            {"Gravenstein", 0.55},
            {"Antonovka", 0.43},
            {"Court Pendu Plat", 0.47}, 
            {"McIntosh", 0.39},
            {"Egremont Russet", 0.57},
            {"Red Falstaff", 0.38}
        };

        double Total_Cost = 0.0;  //Variable used for tracking of the total cost of apples
        bool shop = true; //Boolean to control the loop
        
        Console.WriteLine("Welcome to Apple Orchard! We're thrilled to offer you our finest apples, picked at the" +
                      " peak of perfection just for you.");
        Console.WriteLine("Check out our prices!\n");

        //Main loop
        while (shop)
        {
          // Display of available apples
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Key}: £{item.Value}");
            }
            Console.Write("Enter the type of apple you want: ");
            string apple = Console.ReadLine();
            
            if (Items.ContainsKey(apple)) //Check if the apple input exists
            {
                Total_Cost += Items[apple];  //Add the price to the total cost
                Console.WriteLine($"{apple} has been added to the total.");
            }
            else
            {
                Console.WriteLine("Apple doesn't exist!");  //Tell the user if the apple type doesn't exist
            }
            Console.Write("\nDo you want another apple? (y/n): ");
            string answer = Console.ReadLine();

            if (answer.Equals("yes", StringComparison.OrdinalIgnoreCase)) //Check the user's response and decide whether to continue or not
            {
                shop = true;
            }
            else if (answer.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                shop = false;
            }
        }
        Console.WriteLine($"Your total cost is £{Total_Cost:F2}");  //Display of final total cost
        int Converted_Total_Cost = (int)Total_Cost;  //Convert the total cost to int
        int Converted_Total_Cost_Rounded = (int)Math.Round(Total_Cost);
        Console.WriteLine($"The converted total cost is: £{Converted_Total_Cost_Rounded}");
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}