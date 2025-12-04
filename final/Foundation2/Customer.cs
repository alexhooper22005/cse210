public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public void GetName(string name)
    {
        _name = name;
    }
    public void GetAddress(Address address)
    {
        _address = address;
    }

    // public void SetName()
    // {
       
    // }
    // public void SetAddress()
    // {
    
    // }

    public bool LivesInUsa()
    {
        return true;
    }
}