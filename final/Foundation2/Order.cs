public class Order
{
    private Customer _customer;

    List<Product> products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
   
    public double GetShippingCost()
    {
        if(_customer.LivesInUsa())
        {
            return 5;
        }
        else 
            return 35;
    }
    public string GetPackingLabel()
    {
       string label = "Packing label:\n";

       foreach (Product p in products)
        {
            label += $"{p.GetName()}, ID: {p.GetProductId()}\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping label:\n{_customer.GetName()}\n{_customer.GetAddress().ToString()}";
    }


    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;

        foreach (Product p in products)
        {
            total += p.GetTotalCost();
        }

        total += GetShippingCost();
        return total;
    }

}