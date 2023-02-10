public class Scripture
{
    // Member variables 
    private string[] _scriptureList = Array.Empty<string>();
    private string _updatedText;

    // A constructor
    public Scripture()
    {
    }
    // Member Functions
    public string[] ListMaker(string text)
    {
        string[] _scriptureList = text.Split(' ');
        return _scriptureList;
    }

    public string DisplayRenderedText(string[] newList)
    {

        _updatedText = string.Join(" ", newList);
        return _updatedText;
    }

}




