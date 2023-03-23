public class Order
{
    // Member variables 
    private float _shippingCostLocal = 5;
    private float _shippingCostOut = 35;


    // A constructor
    public Order()
    {

    }
    // Member Functions
    public float TotalOrderCost()
    {
        // Price of products + shipping cost
        return 2;
    }
    public string PackingLabel()
    {
        return "Name+ID of each product";
    }
    public string ShippingLabel()
    {
        return "Name+addres of customer";
    }
}