using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
public class Product
{
    // Member variables 
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;
    private double _totalPerItem;
    private int _keySelection;
    private string _selectionMade;
    private string _temporalString;
    private Dictionary<int, string> _productsAvailable = new Dictionary<int, string>() { { 1, "Tank Tops;TT; 11.25" },
    { 2, "T-Shirts;TS; 15.5" }, { 3, "Henleys;H; 24.19" }, { 4, "Polos;P; 27.99" }, { 5, "Long Sleeve Tops;LST; 42.49" },
    { 6, "Dress Shirts;DS; 56.25" }, { 7, "Tuxedo Shirts;TS; 65.05" } };
    
    // A constructor
    public Product()
    {
    }
    // Member Functions 
    public int DisplayMenu()
    {
        Console.WriteLine("\nplease select from the following options:");
        Console.WriteLine("1. Tank Tops         Price = $11.25");
        Console.WriteLine("2. T-Shirts          Price = $15.5");
        Console.WriteLine("3. Henleys           Price = $24.19");
        Console.WriteLine("4. Polos             Price = $27.99");
        Console.WriteLine("5. Long Sleeve Tops  Price = $42.49");
        Console.WriteLine("6. Dress Shirts      Price = $56.25");
        Console.WriteLine("7. Tuxedo Shirts     Price = $65.05");
        Console.WriteLine("8. Proceed to checkout");
        Console.WriteLine("9. No shopping");
        Console.Write("Your selection: ");
        _keySelection = Convert.ToInt16(Console.ReadLine());
        return _keySelection;
    }
    public string ProductPrice(int keySelection)
    {
        _temporalString = _productsAvailable[keySelection];

        //Separate dictionary values linked to the selected product
        string[] _temporalList = _temporalString.Split(';');

        //Assign those values to designated variables
        _productName = _temporalList[0];
        _productId = _temporalList[1];
        _price = Convert.ToDouble(_temporalList[2]);

        // Request user the quantity of this product
        Console.Write($"How many do you want? ");
        _quantity = Convert.ToInt16(Console.ReadLine());

        // Calculate total cost for this product
        _totalPerItem = _quantity * _price;

        // Obtain a valid string to add to the orderList
        _selectionMade = $"{_productName}, {_productId}, ${_price}, {_quantity}, ${_totalPerItem}";
        return _selectionMade;
    }
}