

Product product1 = new Product { Name = "Product A", Price = 10.0m };
Product product2 = new Product { Name = "Product B", Price = 20.0m };

PaymentGateway paymentGateway = new PaymentGateway();
ShoppingCart cart = new ShoppingCart(paymentGateway);

cart.AddItemToCart(product1);
cart.AddItemToCart(product2);

cart.Checkout();

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class ShoppingCart
{
    
    private decimal _totalPrice = 0;

    private readonly PaymentGateway paymentGateway;

    public ShoppingCart(PaymentGateway paymentGateway)
    {
        this.paymentGateway = paymentGateway;
    }

    public void AddItemToCart(Product product)
    {
        _totalPrice += product.Price;
        Console.WriteLine($"Added {product.Name} to the cart. Total Price: {_totalPrice}");
    }

    public void Checkout()
    {
        Console.WriteLine("Checkout initiated.");

        paymentGateway.ProcessPayment(_totalPrice);

        Reset();
    }

    public decimal TotalPrice => _totalPrice;

    public void Reset()
    {
        _totalPrice = 0;
    }
}

public class PaymentGateway
{   
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount}...");

        // Simulate successful payment
 
    }
}