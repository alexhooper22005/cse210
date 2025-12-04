public class Product
{
    private string _name;
    private int _productid;
    private double _price;
    private int _quantity;

    public Product(string name, int productid, double price, int quantity)
    {
        _name = name;
        _productid = productid;
        _price = price;
        _quantity = quantity;
    }

    public void GetName(string name)
    {
        _name = name;
    }
    public void GetProductId(int productid)
    {
        _productid = productid;
    }
    public void GetPrice(double price)
    {
        _price = price;
    }
    public void GetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    // public void SetName()
    // {
        
    // }
    // public void SetProductId()
    // {
        
    // }
    // public void SetPrice()
    // {
        
    // }
    // public void SetQuantity()
    // {
        
    // }


    public double GetTotalCost()
    {
        return GetPrice(45.32) * GetQuantity(5);
    }

}