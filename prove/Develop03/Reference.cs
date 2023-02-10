
public class Reference
{
    // Member variables 
    private string _citation;
    private string _scriptureText;

    // A constructor
    public Reference()
    {
        _citation = "\n3 Nephi 22:17 ";
        _scriptureText = "No weapon that is formed against thee shall prosper; and every tongue that shall revile against thee in judgment thou shalt condemn. This is the heritage of the servants of the Lord, and their righteousness is of me, saith the Lord.";
    }
    // Member Functions 
    public string GetCitation()
    {
        return _citation;
    }
    public string GetScriptureText()
    {
        return _scriptureText;
    }

}