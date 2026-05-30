using System;
public class Product
{
    private string _name;
    private string _productID;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string productID, double pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;

    }
    // total cost (price * quantity)
    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;

    }
    // return product name and ID
    public string GetName()
    {
        return _name;

    }
    public string GetProductID()
    {
        return _productID;
    }
    
}