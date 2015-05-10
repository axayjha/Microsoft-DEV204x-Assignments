//As asked by the assignment, just the modified LINQ code and not everything


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