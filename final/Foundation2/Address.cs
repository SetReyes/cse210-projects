using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
public class Address
{
    // Member variables 
    private string _street;
    private string _city;
    private string _state;
    private string _country;


    // A constructor
    public Address()
    {
    }
    // Member Functions
    public string FullAddress()
    {
        Console.Write("What is your street address? ");
        _street = Console.ReadLine();
        Console.Write("What is the city? ");
        _city = Console.ReadLine();
        Console.Write("What is the state/province? ");
        _state = Console.ReadLine();
        Console.WriteLine("Please, be specific for the country. Input USA for the United States of America.");
        Console.Write("What is the country? ");
        _country = Console.ReadLine();
        return $"{_street},{_city},{_state},{_country}";
    }
    public bool ConfirmIfLocal()
    {
        if (_country.ToLower() == "usa")
        { return true; }
        else
        { return false; }
        // string[] _temporalArray2 = country.Split(',');
        //  = _temporalArray2[1];
    }
}
