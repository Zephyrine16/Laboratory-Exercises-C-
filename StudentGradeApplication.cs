using System;

class frmStudentGradeProgram
{
    static void Main(String [] args)
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Grades:\n");
        
        Console.Write("English: ");
        double english = Convert.ToDouble(Console.ReadLine());

        Console.Write("Math: ");
        double math = Convert.ToDouble(Console.ReadLine());

        Console.Write("Science: ");
        double science = Convert.ToDouble(Console.ReadLine());

        Console.Write("Filipino: ");
        double filipino = Convert.ToDouble(Console.ReadLine());

        Console.Write("History: ");
        double history = Convert.ToDouble(Console.ReadLine());


        double Sum = english + math + science + filipino + history; // Add the grades to get the total
        double Average = Sum / 5; // Then divide to get the average

        if(Average >= 75.00) // Condition if the student passed
        {
            Console.Write("\nThe student passed.");
            Console.Write($"\nThe general average of {name} is {Average:F2}.\n");
        }
        else if(Average < 75.00) // Condition if the student failed
        {
            Console.Write("\nThe student failed.");
            Console.Write($"The general average of {name} is {Average:F2}.\n");
        }
    }
}
