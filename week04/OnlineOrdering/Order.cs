using System;
using System .Collections.Generic;
public class Order
{
    private Customer _customer;
    private List<Product> _products;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    // Add a product
    public void AddProduct(Product product)
    {
        _products.Add(product);

    }
    // total price = product + shipping
    public double GetTotalPrice()
    {
        double productTotal = 0;
        // calculate sum of product cost
        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCost();
        }
        // add shipping cost based on customer location
        double shippingCost;
        if (_customer.LivesInUSA())
        {
            shippingCost = 5.00; 
        }
        else
        {
            shippingCost = 35.00;
        }
        return productTotal + shippingCost;
    }
    // return packing Label
    public string GetPackingLabel()
    {
        string label = "=== Packing Label ===\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductID()})\n";
        }
        return label;
    }
    // return shipping label
    public string GetShippingLabel()
    {
        string label = "=== Shipping Label ===\n";
        label += $"{_customer.GetName()}\n{_customer.GetFullAddress()}";
        return label;
    }
}