using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
namespace Activity_book
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> _activities = new List<Activity>();

            int sel;
            double runningDistance = 0;
            double CyclingSpeed = 0;
            double SwimmingLaps = 0;

            Console.Clear();

            do
            {
                // Instatiate SubClasses
                Running SubCall1 = new Running();
                Cycling SubCall2 = new Cycling();
                Swimming SubCall3 = new Swimming();

                

                // Show menu 
                Console.WriteLine("\nActivity Menu: ");
                Console.WriteLine("1. Running ");
                Console.WriteLine("2. Cycling ");
                Console.WriteLine("3. Swimming ");
                Console.WriteLine("4. Display ");
                Console.WriteLine("5. Quit");
                Console.Write("Selection: ");
                sel = Convert.ToInt16(Console.ReadLine());

                // Activities 

                // Running
                if (sel == 1)
                {
                    SubCall1.RecordActivity();
                    _activities.Add(SubCall1);
                    runningDistance += SubCall1.GetDistance();
                }
                // Cycling
                else if (sel == 2)
                {
                    SubCall2.RecordActivity();
                    _activities.Add(SubCall2);
                    CyclingSpeed = SubCall2.GetSpeed();
                }
                // Swimming
                else if (sel == 3)
                {
                    SubCall3.RecordActivity();
                    _activities.Add(SubCall3);
                    SwimmingLaps += SubCall3.GetLaps();
                }
                // Presenting results
                else if (sel == 4)
                {
                    Console.Clear();
                    Console.WriteLine($"\nYour total running distance is: {Math.Round(runningDistance, 1)} km");
                    Console.WriteLine($"Your last cycling speed is: {Math.Round(CyclingSpeed, 1)} kph");
                    Console.WriteLine($"Your total number of laps is: {Math.Round(SwimmingLaps, 1)} \n");

                    int counter = 1;
                    Console.WriteLine("The activities are: ");
                    // List Activitys
                    foreach (Activity item in _activities)
                    {
                        Console.WriteLine($"{counter}{item.GetSummary()}");
                        counter++;
                    }
                }
            } while (sel != 5);
        }
    }
}