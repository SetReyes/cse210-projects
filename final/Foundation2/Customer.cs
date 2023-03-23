public class Customer
{
    // Member variables 
    private string _customerName;
    private string _address;

    // A constructor
    public Customer()
    {
    }
    // Member Functions
    public bool ConfirmLocalAddress()
    {
        return false;
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
    public string GetCustomerAddress()
    {
        return _address;
    }
}