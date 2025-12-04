public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public void GetStreet(string street)
    {
        _street = street;
    }
    public void GetCity(string city)
    {
        _city = city;
    }
    public void GetState(string state)
    {
        _state = state;
    }
    public void GetCountry(string country)
    {
        _country = country;
    }
    // public void SetStreet()
    // {
        
    // }
    // public void SetCity()
    // {
        
    // }
    // public void SetState()
    // {
        
    // }
    // public void SetCountry()
    // {
        
    // }

    public bool IsInUSA()
    {
        
        return true;
    }
}