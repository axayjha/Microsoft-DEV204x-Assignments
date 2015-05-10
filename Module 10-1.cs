//As asked by the assignment, just the modified LINQ code and not everything

public void Linq3()
{
    List<Product> products = GetProductList();

    //TODO: Create code to implement the functionality listed in the [Description] tag for this query
    var expensiveInStockProducts =
        from item in products
        where item.UnitPrice > 3
        select item;


    Console.WriteLine("In-stock products that cost more than 3.00:");
    foreach (var product in expensiveInStockProducts)
    {
        Console.WriteLine("{0} is in stock and costs more than 3.00.", product.ProductName);
    }
}

public void Linq4()
{
    List<Customer> customers = GetCustomerList();

    //TODO: Create code to implement the functionality listed in the [Description] tag for this query
    var waCustomers =
        from people in customers
        where people.City == "WA" || people.Region=="WA"  //Only People.Region will do but just in case
        select people;

    Console.WriteLine("Customers from Washington and their orders:");
    foreach (var customer in waCustomers)
    {
        Console.WriteLine("Customer {0}: {1}", customer.CustomerID, customer.CompanyName);
        foreach (var order in customer.Orders)
        {
            Console.WriteLine("  Order {0}: {1}", order.OrderID, order.OrderDate);
        }
    }
}