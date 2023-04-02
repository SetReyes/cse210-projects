using System;

class Program
{
    static void Main(string[] args)
    {
        // Variable
        string _selection1;
        int _selection2;

        // Clear Screen
        Console.Clear();
        
        do
        {
            // Menu Options
            Console.WriteLine("EventS Menu: ");
            Console.WriteLine(" 1. Outdoor Event ");
            Console.WriteLine(" 2. Lecture Event ");
            Console.WriteLine(" 3. Reception Event ");
            Console.WriteLine(" 4. Quit ");
            Console.Write("Select a choice from the menu: ");
            _selection1 = Console.ReadLine();

            // Instantiate Super Class
            Event testCall = new Event();

            // Define Message to Display

            // Instatiate SubClasses
            Outdoor testCall1 = new Outdoor();
            Lecture testCall2 = new Lecture();
            Reception testCall3 = new Reception();

            switch (_selection1)
            {
                case "1": // Outdoor Event 
                    testCall1.SetEventData(_selection1);
                    _selection2 = testCall1.DisplayChoice();
                    Console.Clear();
                    if (_selection2 == 1)
                    {
                        Console.WriteLine(testCall1.StandardEvent());
                    }
                    else if (_selection2 == 2)
                    {
                        Console.WriteLine(testCall1.FullDetails(testCall1.RunOutdoor()));
                    }
                    else if (_selection2 == 3)
                    {
                        Console.WriteLine(testCall1.ShortDescription());
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid option.");
                    }
                    break;

                case "2": // Lecture Event
                    testCall2.SetEventData(_selection1);
                    _selection2 = testCall2.DisplayChoice();
                    Console.Clear();
                    if (_selection2 == 1)
                    {
                        Console.WriteLine(testCall2.StandardEvent());
                    }
                    else if (_selection2 == 2)
                    {
                        Console.WriteLine(testCall2.FullDetails(testCall2.RunLecture()));
                    }
                    else if (_selection2 == 3)
                    {
                        Console.WriteLine(testCall2.ShortDescription());
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid option.");
                    }
                    break;

                case "3": // Reception Event
                    testCall3.SetEventData(_selection1);
                    _selection2 = testCall3.DisplayChoice();
                    Console.Clear();
                    if (_selection2 == 1)
                    {
                        Console.WriteLine(testCall3.StandardEvent());
                    }
                    else if (_selection2 == 2)
                    {
                        Console.WriteLine(testCall3.FullDetails(testCall3.RunReception()));
                    }
                    else if (_selection2 == 3)
                    {
                        Console.WriteLine(testCall3.ShortDescription());
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid option.");
                    }
                    break;
            }
        } while (_selection1 != "4");
    }
}