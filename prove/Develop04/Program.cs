using System;

class Program
{
    static void Main(string[] args)
    {

        // Variable
        string selection;
        do
        {
            // Menu Options
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start breathing activity ");
            Console.WriteLine(" 2. Start reflecting activity ");
            Console.WriteLine(" 3. Start listing activity ");
            Console.WriteLine(" 4. Quit ");
            Console.Write("Select a choice from the menu: ");
            // Collect selection
            selection = Console.ReadLine();
            // Instantiate Super Class
            Activity testCall = new Activity();
            // Instatiate SubClasses
            Breathing testCall1 = new Breathing();
            Reflecting testCall2 = new Reflecting();
            Enumeration testCall3 = new Enumeration();



            // Breathing Activity 
            if (selection == "1")
            {
                Console.WriteLine($"{testCall1.SelectionCall(selection)}");
                Console.WriteLine(testCall1.MessageDisplay(selection));
                Console.WriteLine();
                testCall1.TimeRequest();
                testCall1.SpinnerDisplay();
                testCall1.RunBreathing(testCall1.GetTime());
                testCall1.BreathingProcess();
                testCall1.FinalMessage();
                testCall1.SpinnerDisplay();
                testCall1.BreathingStatistic();
            }
            // Reflecting Activity 
            else if (selection == "2")
            {
                Console.WriteLine($"{testCall2.SelectionCall(selection)}");
                Console.WriteLine(testCall2.MessageDisplay(selection));
                Console.WriteLine();
                testCall2.TimeRequest();
                testCall2.SpinnerDisplay();
                testCall2.GetPromptR();
                testCall2.RunReflecting();
                testCall2.ReflectingProcess();
                testCall2.FinalMessage();
                testCall2.SpinnerDisplay();
            }
            else if (selection == "3")
            {
                Console.WriteLine($"{testCall3.SelectionCall(selection)}");
                Console.WriteLine(testCall3.MessageDisplay(selection));
                Console.WriteLine();
                testCall3.TimeRequest();
                testCall3.SpinnerDisplay();
                testCall3.RunEnumeration();
                testCall3.EnumerationProcess();
                testCall3.FinalMessage();
                testCall3.SpinnerDisplay();
            }
            else if (selection == "4")
            {
            }
        } while (selection != "4");
    }
}
