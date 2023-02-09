/*
* Author: Ruben Villagrana
* Course: COMP-003A
* Purpose: Assignment 3 Code
*/
using System;
using System.Security.Cryptography.X509Certificates;

namespace ClearConsole

{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("********************************************************************");
            Console.WriteLine("If-else Section Numeric to Letter Grade");
            Console.WriteLine("Enter number for grade");
            var gradeLetter = "";
            string numericGradeStr;
            decimal numericGrade;
            Console.Write("Enter the number of the grade: ");
            numericGradeStr = Console.ReadLine();
            decimal.TryParse(numericGradeStr, out numericGrade);
            if (numericGrade >= 0 && numericGrade <= 100)
            {
                if (numericGrade >= 90)
                    gradeLetter = "A";
                else if (numericGrade >= 80)
                    gradeLetter = "B";
                else if (numericGrade >= 70)
                    gradeLetter = "C";
                else if (numericGrade >= 60)
                    gradeLetter = "D";
                else if (numericGrade < 60)
                    gradeLetter = "F";
            }
            else
                gradeLetter = "Please enter a valid Number";


            Console.WriteLine("Grade:" + gradeLetter);
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Integer to string day using a switch statement");
            Console.WriteLine("Enter an integer of the week 1-7");
            var numericDay = Convert.ToInt32(Console.ReadLine());

            switch (numericDay)
            {
                case 0:
                    Console.WriteLine("It's SUNDAY");
                    break;
                case 1:
                    Console.WriteLine("It's MONDAY");
                    break;
                case 2:
                    Console.WriteLine("It's TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("It's WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("It's THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("It's FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("It's SATURDAY");
                    break;

                default:
                    Console.WriteLine("It's wrong input...");
                    break;


                    Console.WriteLine("Press Enter; to Exit...");
                    Console.Read();
            }
        }

    }
}
  