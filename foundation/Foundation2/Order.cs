using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetShipping()
    {
        // Calculate shipping cost based on customer's location
        return _customer.isUSA() ? 5.0 : 35.0;
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;

        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalCost();
        }

        totalPrice += GetShipping(); // Add shipping cost
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        // Build packing label using StringBuilder for efficiency
        StringBuilder packingLabel = new StringBuilder("Packing Label:\n");
        foreach (Product product in _products)
        {
            packingLabel.AppendLine($"{product.GetName()} - {product.GetID()}");
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        // Generate shipping label using customer details
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
    }

    public string GetOrderDetails()
    {
        // Build the order details including products, shipping cost, and total cost
        StringBuilder orderDetails = new StringBuilder("\nProducts:\n");

        foreach (Product product in _products)
        {
            orderDetails.AppendLine(
                $"{product.GetName()} ({product.GetID()}) - ${product.GetPrice().ToString("F2")} x {product.GetQuantity()} = ${product.GetTotalCost().ToString("F2")}"
            );
        }

        orderDetails.AppendLine($"Shipping Cost: ${GetShipping().ToString("F2")}");
        orderDetails.AppendLine($"Total: ${GetTotalPrice().ToString("F2")}");

        return orderDetails.ToString();
    }

    public void Display()
    {
        // Display the complete order details
        string packingLabel = GetPackingLabel();
        string shippingLabel = GetShippingLabel();
        string orderDetails = GetOrderDetails();

        Console.WriteLine($"{packingLabel}\n{shippingLabel}\n{orderDetails}");
    }
}