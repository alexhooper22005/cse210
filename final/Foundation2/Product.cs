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

    public void SetName(string name)
    {
        _name = name;
    }
    public void SetProductId(int productid)
    {
        _productid = productid;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetProductId()
    {
        return _productid;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }


    public double GetTotalCost()
    {
        return GetPrice() * GetQuantity();
    }

}