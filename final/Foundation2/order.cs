

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _customer = customer;
        _products = products;
    }    

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;

        foreach(var product in _products)
        {
            totalPrice += product.GetTotalPrice();
        }

        decimal shippingfee;

        if (_customer.IsUSA())
        {
            shippingfee = 5;
        }
        else 
        {
            shippingfee = 35;
        }

        return totalPrice + shippingfee;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer: {_customer.GetName()}\n";
        shippingLabel += $"Address: {_customer.GetAddress().GetFullAddress()}";
        return shippingLabel;
    }
}