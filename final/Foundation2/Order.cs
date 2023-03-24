using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
public class Order
{
    // Member variables 
    private List<string> _orderList1 = new List<string>();
    private List<double> _subtotals = new List<double>();
    private double _subtotalCost;
    private double _TotalOrderCost;

    // Instantiations of Customer Class
    Customer customerA = new Customer();

    // A constructor
    public Order()
    {
    }
    // Member Functions

    public double TotalOrderCost()
    {
        // Get last/new item of the 
        if (_orderList1.Count > 0)
        {
            string item = _orderList1[^1];
            string[] _temporalArray = item.Split('$');
            double _temporaldouble = Convert.ToDouble(_temporalArray[2]);
            _subtotals.Add(_temporaldouble);
        }
        _TotalOrderCost = TotalOrderProduct();
        return _TotalOrderCost;
    }
    public void PackingLabel()
    {
        Console.WriteLine("\nPacking Label");
        foreach (string items in _orderList1)
        {
            string[] _temporalArray1 = items.Split(',');
            Console.WriteLine($"Product: {_temporalArray1[0]} | Product ID: {_temporalArray1[1]}");
        }
    }
    public void ShippingLabel(string address)
    {
        string[] _temporalArray2 = address.Split(',');
        Console.WriteLine("\nShipping Label ");
        Console.WriteLine($"Name: {_temporalArray2[0]}\nStreet: {_temporalArray2[1]}\nCity: {_temporalArray2[2]}\nState: {_temporalArray2[3]}\nCountry: {_temporalArray2[4]}\n");
    }
    public void SetOrderList(string listPiece)
    {
        _orderList1.Add(listPiece);
    }
    public double TotalOrderProduct()
    {
        _subtotalCost = Math.Round(_subtotals.Sum(), 2, MidpointRounding.ToEven);
        return _subtotalCost;
    }
}
