using System;

class ComputeAverageProgram
{
    static void Main()
    {
        double Sum_Of_Grades = 0;
        
        //Info gathering
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter your program: ");
        string program = Console.ReadLine();

        Console.Write("Total number of subjects: ");
        int subjects = Convert.ToInt32(Console.ReadLine());
        
        double[] grades = new double[subjects];
        int Subject_Number = 0; //The starting point is at 0
        do
        {
            Console.Write($"Enter your grade in subject {Subject_Number + 1}: ");
            string grade = Console.ReadLine();

            if (Double.TryParse(grade, out grades[0]))
            {
                grades[Subject_Number] = Convert.ToDouble(grade);  //Store the grade in an array
                Sum_Of_Grades += grades[0];  //Add the grade to the sum
                Subject_Number++;  //Add a number every loop
            }
            else
            {
                Console.WriteLine("Invalid! Please enter a valid grade.");
            }
        } while (Subject_Number < subjects);
        
        Console.Write($"\nName: {name}\n");
        Console.WriteLine($"Program: {program}");
        Console.WriteLine($"Subjects: {subjects}\n");
        
        //Calculate the average grade
        double average = Sum_Of_Grades / subjects;
        double Rounded_Average = Math.Round(average);  //Round the average
        int Rounded_Average_Int = (int)Rounded_Average;
        Console.Write($"Your average grade is: {average}\n");
        Console.Write($"The rounded off average is {Rounded_Average_Int}\n");
        
        Console.Write("\nPress any key to exit...");
        Console.ReadKey();
    }
}