public class Order
{
    private Customer _customer;

    List<Product> products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void GetCustomer()
    {
        
    }
    public void GetProducts()
    {
        
    }
    public void GetShippingCost()
    {
        
    }
    public void GetPackingLabel()
    {
        
    }
    public void GetShippingLabel()
    {
        
    }

    public string AddProduct(Product product)
    {
        return products.Add(product);
    }

}