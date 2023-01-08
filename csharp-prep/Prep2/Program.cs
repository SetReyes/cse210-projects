using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, input your percentage grade (0-100):");
        string percentageGrade = Console.ReadLine();
        int value = int.Parse(percentageGrade);
        string letterGrade;
        string sign;
        int signCalculation = value % 10;


        if (signCalculation >= 7)
        {
            sign = "+";
        }
        else if (signCalculation < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        if (value >= 90)
        {
            letterGrade = "A";
        }
        else if (value >= 80)
        {
            letterGrade = "B";
        }
        else if (value >= 70)
        {
            letterGrade = "C";
        }
        else if (value >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }


        if (letterGrade == "A" && signCalculation >= 3)
        {
            Console.Write($"Congratulations! You approved your course with a letter grade of {letterGrade}");
        }
        else if (letterGrade == "A" && signCalculation < 3)
        {
            Console.Write($"Congratulations! You approved your course with a letter grade of {letterGrade}{sign}");
        }
        else if (letterGrade == "B" || letterGrade == "C")
        {
            Console.Write($"Congratulations! You approved your course with a letter grade of {letterGrade}{sign}");
        }
        else if (letterGrade == "D")
        {
            Console.Write($"Sorry, you have been repproved with a letter grade of {letterGrade}{sign}. Try again, you can do this!");
        }
        else
        {
            Console.Write($"Sorry, you have been repproved with a letter grade of {letterGrade}. Try again, you can do this!");
        }


    }
}