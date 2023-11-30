

public class Product
{
    private string _productName;
    private string _productId;
    private decimal _productPrice;
    private int _quantity;

    public Product(string productName, string productId, decimal productPrice, int quantity)
    {
        _productId = productId;
        _productName = productName;
        _productPrice = productPrice;
        _quantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return _productPrice * _quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}