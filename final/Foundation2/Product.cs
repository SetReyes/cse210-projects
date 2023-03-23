public class Product
{
    // Member variables 
    private string _productName;
    private string _productId;
    private float _price;
    private int _quantity;

    private string[,] _productInfo = {{ "Apples", "AFW", "4.5 "}, { "Banana", "BFW", "1.5" }
    };

    // A constructor
    public Product()
    {
    }
    // Member Functions 
    public float ProductPrice()
    {
        return 2;
    }
    public string GetProductId()
    {
        return "AS";
    }
    public string GetProductName()
    {
        return "sss";
    }
    public string SetProductQuantity()
    {
        return "sss";
    }
}