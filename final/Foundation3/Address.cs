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
        Console.Write("Street Address: ");
        _street = Console.ReadLine();
        Console.Write("City: ");
        _city = Console.ReadLine();
        Console.Write("State/Province: ");
        _state = Console.ReadLine();
        Console.Write("What is the country? ");
        _country = Console.ReadLine();
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}
