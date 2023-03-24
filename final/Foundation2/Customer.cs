using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
public class Customer
{
    // Member variables 
    private string _name;
    private string _customer;
    private string _address;
    private double _shippingCost;

    // Instantiations of Address Class
    Address addressA = new Address();

    // A constructor
    public Customer()
    {
    }
    // Member Functions
    public bool ConfirmLocalAddress()
    {
        return false;
    }
    public void SetCustomerName()
    {
        Console.WriteLine("\nPlease, provide your personal information for delivery. ");
        Console.Write("What is your full name? ");
        _name = Console.ReadLine();
        _address = addressA.FullAddress();
        _customer = _name + "," + _address;
    }
    public string GetCustomerData()
    {
        return _customer;
    }
    public double GetShippingCost()
    {
        if (addressA.ConfirmIfLocal() == true)
            _shippingCost = 5;
        else
            _shippingCost = 35;

        return _shippingCost;
    }
}