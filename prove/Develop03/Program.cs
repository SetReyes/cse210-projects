using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiations of classes 
        Reference initialText = new Reference();
        Scripture hideShowText = new Scripture();
        Word testingSee = new Word();

        // Member variables
        string _answer = "";
        string _message = initialText.GetScriptureText();
        string[] _listT;
        string _newText;
        int _counter = 0;
        int _limiter = 0;

        // Calling class methods 
        do

        {
            // Introduction
            Console.WriteLine(initialText.GetCitation() + _message);

            // Ask to select an option
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            _answer = Console.ReadLine();
            Console.Clear();
            
            // Modify scripture message
            _listT = hideShowText.ListMaker(_message);
            testingSee.Hide(_listT);

            _newText = hideShowText.DisplayRenderedText(_listT);
            
            //Console.WriteLine(_newText);
            _message = _newText;
            _counter++;

            // Ensure that the scripture text completely disappears
            if (_listT.Length % 3 == 0)
                _limiter = 1 + (_listT.Length / 3);
            else
                _limiter = 1 + (2 + _listT.Length) / 3;

        } while (_answer != "quit" && _counter != _limiter);
    }
}



