using System;
using System.IO;

class StudentRegistration
{
    static void Main()
    {
        string Director_Path = @"C:\Users\dizon\RiderProjects\StudentRegistration\";
        string[] Files_To_Check = // All the required documents to submit
        {
            "Birth Certificate.pdf",
            "SHS Diploma.pdf",
            "GoodMoral.pdf",
            "Form137.pdf",
            "Grades.xlsx"
        };
        for (;;) // Will loop if you want to have another enrollment procedure
        { // First procedure of enrollment
            Console.Write("Do you still want to enroll at STI College Dasmariñas (yes/no)?: ");
            string enroll = Console.ReadLine();

        if (enroll.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Write("\nStudent Name: "); // Information gathering
            string name = Console.ReadLine();
            Console.Write("Student No. (must be 10 digits): ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Student Contact No. (must be 10 digits): ");
            long contact = Convert.ToInt64(Console.ReadLine());
            Console.Write("Year Level: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Student Address: ");
            string address = Console.ReadLine();
            
            string[] kourse = {"BS in Hospitality Management\n", // List of available courses
                "BS in Information Technology\n",
                "BS in Tourism Management\n",
                "BS in Computer Science\n",
                "BS in Business Administration\n",
                "BS in Accountancy\n",
                "Bachelor of Multimedia Arts\n",
                "AB Communication\n"
            };
            Console.Write("\nAvailable Courses: \n");
            for (int i = 0; i < kourse.Length; i++)
            {
                Console.Write($"{i + 1}. {kourse[i]}");
            }
            Console.Write("\nEnter your course: ");
            int Course_Index = int.Parse(Console.ReadLine()) - 1;
            string course = kourse[Course_Index];
            
            Console.WriteLine("Student Information"); // Compilation of all data gathered
            Console.WriteLine($"\n {name} \n {num} \n {contact} \n {year} \n {address} \n {course}");

            string[] requirements = {"Birth Certificate\n",
                "SHS Diploma\n",
                "Good Moral\n",
                "Form 137\n",
                "Grades\n",
            };
            while (true) // Will loop if you don't havve the following requirements
            {
                Console.WriteLine("Do you have the following requirements? (yes/no)");
                for (int i = 0; i < requirements.Length; i++)
                {
                    Console.Write($"{requirements[i]}");
                }
                string answer = Console.ReadLine();
                if (answer.Equals("Yes", StringComparison.CurrentCultureIgnoreCase)) // Will print if such documents exist
                {
                    foreach (string File_Name in Files_To_Check)
                    {
                        string File_Path = Path.Combine(Director_Path, File_Name);
                        if (File.Exists(File_Path))
                        {
                            Console.WriteLine($"File {File_Name} exists.");
                        }
                        else
                        {
                            Console.WriteLine($"File {File_Name} does not exist.");
                        }
                    }
                    break;
                }
                else if (!answer.Equals("Yes", StringComparison.CurrentCultureIgnoreCase)) // Wil stop the program if such documents do not exist
                {
                    Console.WriteLine("Please fulfil the following requirements first");
                }
                return;
            }
            Console.Write("Payment Type: ");
            string Payment_Type = Console.ReadLine();

            if (Payment_Type.Equals("Cash", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.Write("FINANCIAL\nCharges for 2024-2025/1st Term\n");
                Dictionary<(string, string), double> amounts = new Dictionary<(string, string), double>() // Shows the breakdown of bills for enrollment
                {
                    {("Tuition", "            "), 85113.65},
                    {("Miscellaneous", "      "), 12725.65},
                    {("Other School Fees", "  "), 11250.73},
                };
                foreach (var Fees in amounts)
                {
                    Console.Write($"\n{Fees.Key.Item1}:{Fees.Key.Item2} P{Fees.Value}");
                }
                double Total_Amounts = amounts.Values.Sum(); // Will add all the amounts of the breakdown
                Console.WriteLine($"\nTotal Assessment:   P{Total_Amounts:F2}");
                
                Console.Write("Press C to pay in cash: ");
                string pay = Console.ReadLine();
                if (pay.Equals("C", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Write("\nEnrollment Confirmed!\nWelcome to STI College Dasmariñas!\n" +
                                  "Classes will officially start on August 12, 2024.\n"); // Enrollment confirmation
                }
                else
                {
                    Console.Write("Invalid Input! Try Again.");
                }
            }
            else if (Payment_Type.Equals("Installment", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.Write("FINANCIAL\nCharges for 2024-2025/1st Term\n");
                Dictionary<(string, string), double> amounts = new Dictionary<(string, string), double>() // Shows the breakdown of bills for enrollment
                {
                    {("Tuition", "            "), 85113.65},
                    {("Miscellaneous", "      "), 12725.65},
                    {("Other School Fees", "  "), 11250.73},
                };
                foreach (var Fees in amounts)
                {
                    Console.Write($"\n{Fees.Key.Item1}:{Fees.Key.Item2} P{Fees.Value}");
                }
                double Total_Amounts = amounts.Values.Sum(); // Will add all the amounts of the breakdown
                Console.WriteLine($"\nTotal Assessment:   P{Total_Amounts:F2}");

                Dictionary<(string, string), double> term = new Dictionary<(string, string), double>()
                {
                    {("UPON ENROLLMENT", "    "), 27272.5075},
                    {("SEPTEMBER 10, 2024", " "), 27272.5075},
                    {("OCTOBER 16, 2024", "   "), 27272.5075},
                    {("NOVEMBER 16, 2024", "  "), 27272.5075},
                    {("DECEMBER 12, 2024", "  "), 27272.5075},
                };
                foreach (var Four_Terms in term)
                {
                    Console.Write($"\n{Four_Terms.Key.Item1}:{Four_Terms.Key.Item2} P{Four_Terms.Value:F2}");
                }
                
                Console.Write("\nPress I to pay in installment: ");
                string pay = Console.ReadLine();
                if (pay.Equals("I", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Write("\nEnrollment Confirmed!\nWelcome to STI College Dasmariñas!\n" +
                                  "Classes will officially start on August 12, 2024.\n"); // Enrollment confirmation
                }
                else
                {
                    Console.Write("Invalid Input! Try Again.");
                }
            }
        }
        else if (enroll.Equals("no", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Write("edi wag");
        }
        Console.WriteLine("Do you want to start over? (yes/no)");
        string start = Console.ReadLine();
        if (!start.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
        {
            break;
        }
        }
    }
}