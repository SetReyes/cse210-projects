public class Word
{
    // Member variables 
    private int _counter = 0;
    private int _index;
    private string[] _updatedList;
    private Random _random = new Random();

    // A constructor
    public Word()
    {
    }

    // Member Functions
    public string[] Hide(string[] list, int _remover = 0)
    {
        while (_counter < list.Length && _remover < 3)
        {
            _index = _random.Next(list.Length);
            _updatedList = list;
            if (_updatedList[_index] != "______")
            {
                _updatedList[_index] = "______";
                _remover++;
            };
            _counter = _updatedList.Count(s => s == "______");

        }
        return _updatedList;
    }
}