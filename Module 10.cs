//As asked by the assignment, just the modified LINQ code and not everything

//Part 1

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

// Part 2


public void Linq30()
    {
        List<Product> products = GetProductList();

        //TODO: Enter code here to order products by name
        // You don't need to write code to output these values as this next line of code does it for you

        var sortedProducts =
            from item in products
            orderby item
            select item;

        ObjectDumper.Write(sortedProducts); //this might throw errors in some older IDEs 
    }

public void Linq32()
    {
        double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

        //TODO: Enter code here to order this list in descending order
        var sortedDoubles =
            from num in doubles
            orderby num descending  
            select num;


        Console.WriteLine("The doubles from highest to lowest:");
        foreach (var d in sortedDoubles)
        {
            Console.WriteLine(d);
        }
    }
