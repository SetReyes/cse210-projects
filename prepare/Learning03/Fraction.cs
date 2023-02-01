public class Fraction
{
    // variables
    private int _top;
    private int _bottom;

    // A constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int wholeNum1, int wholeNum2)
    {
        _top = wholeNum1;
        _bottom = wholeNum2;
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int topNum)
    {
        _top = topNum;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottomNum)
    {
        _bottom = bottomNum;
    }

    public string GetFractionString()
    {
        // Not store, re-calculated every single time
        string fractStr = ($"{_top}/{_bottom}");
        return fractStr;
    }
    public double GetDecimalValue()
    {
        // Not store, re-calculated every single time
        return (double)_top / (double)_bottom;
    }


    // Console.WriteLine($"{GetTop()}/{GetBottom()}");

}