using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();
        Console.WriteLine(new string( '=', 80));


    
    //  Once you have created these classes, write a program that:
    // - creates at least two orders with a 2-3 products each. 
    // - Call the methods to get the packing label, 
    // -the shipping label, 
    // -and the total price of the order, 
    // -and display the results of these methods.


    // -------------------------------------------
    // A WORD ON USING _customer vs customer:
    // ✅ In Program.cs (or any other class using Customer), you:
    // Don't use underscores like _customer or _address 
    // because those are private fields inside the Customer class.

    // Instead, you use the object name (customer) and call its public methods, 
    // like GetCustomerData().
    // --------------------------------------------

        // Address class
        Address address1 = new Address("1119 E Hoof Print Drive", "Eagle Mountain", "UT", "USA");
        Address address2 = new Address("1208 N Sage Park Road", "Denver", "CO", "USA");
        Address address3 = new Address("509 Tuhikaramea Road", "Temple View", "Hamilton", "New Zealand");
        // Console.WriteLine($"My Address is:\n{address.GetAddress()}");
    
        // Customer class
        Customer customer1 = new Customer("Chanda Frey", address1);
        // ***Notice that we need to add the address with the number that corresponds
        Customer customer2 = new Customer("George Clooney", address2);
        Customer customer3 = new Customer("Sandy Williams", address3);
        // Console.WriteLine(customer.GetCustomerData());
    
        // -------------------------------------------
        // To Reiterate what was said above...customer is the variable name for the object you just created.
        // You're calling its public method GetCustomerData(), which internally uses _customer and _address.
        // You don't and shouldn't access _customer or _address directly from outside the class — they’re marked private.
        // -------------------------------------------

        // Product class
        // Create new instances of products with numbers(product1, prodct2)
        // Example: Product("name", "id", price, quantity)
        Product product1 = new Product("Night Stand", "365475", 300.00, 2);
        Product product2 = new Product("Lamp", "987654", 65.99, 2);
        Product product3 = new Product("Headboard", "123456", 599.00, 1);
        Product product4 = new Product("Frame", "147258", 13.99, 3);
        Product product5 = new Product("Charging Cord", "369147", 11.50, 2);
        Product product6 = new Product("Pillow", "159263", 22.50, 6);
        Product product7 = new Product("Comforter", "478159", 199.00, 1);
        Product product8 = new Product("Sheets", "356489", 107.99, 1);

        //****Once you have created an order and added customer
        // THEN ADD these products to the product list in the 
        // Order>>>>   

    //  -----------------------------------------------------------------------------
        // Product Name and Id
        // Console.WriteLine(product.GetProductData());
        // // Total Cost of product
        // // ----------------------------------------
        // // FORMATTING FOR CENTS>>>
        // // at the End of a double method name - use :0.00 (don't forget colon)
        // // The number will always show 2 DECIMAL PLACES(even if it's a whole number)
        // // like this: ${product.GetTotalCost():0.00}....$10.00
        // // For THOUSAND SEPARATORS:
        // // like this:  ${product.GetTotaCost():0,0.00}.....$1,000.00
        // // ------------------------------------------
        // Console.WriteLine($"The total Cost is: ${product.GetTotalCost():0,0.00}");
        

        // // SETTING a new product name
        // product.SetName("Can Opener");
        // // Console.WriteLine(product.GetName());
        // Console.WriteLine($"Product with New Name; {product.GetProductData()}");
    // --------------------------------------------------------------------------------


        // Order Class
        // Do NOT put in the customer's name "Bob" in the "Order" parameter
            // We are passing in the WHOLE OBJECT "Customer" for Order
            // the WHOLE OBJECT holds:
            // - A string name ("Bob")
            // - An Address object (with street, city, state, country) 
            // - and customer.IsUSA() to check for shipping cost
        
        // **By typing customer1 or customer 2 in the parameters, we are able 
        // to get the address associated with that customer - so we don't have
        // to add a line for address here.
        Order order1 = new Order(customer1);
        // >>>>>>Now ADD the Products to this Order instance
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
       // ............................

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
       // ............................

        Order order3 = new Order(customer3);
        order3.AddProduct(product7);
        order3.AddProduct(product8);
        // ............................

       
        // These can be used here inside main, but I put them in a DisplayOrderSummary
        // method to make it easier to use for mulitple orders...
        // Now, I can just write:
        // DisplayOrderSummary(order1);
        // DisplayOrderSummary(order2);

        // ---------------------------------------------
        // - Call the methods to get the Packing label, 
        // string packingLabel = order.GetPackingLabel();
        // Console.WriteLine(packingLabel);

        //  // - Call the methods to get Total Price of Order, 
        // double totalCost = order.GetTotalCost();
        // // **Notice the formatting for the subtotal to get decimals
        // Console.WriteLine($"Total Cost: ${totalCost:0,0.00}");
        
        // // - Call the methods to get the Shipping label, 
        // string shippingLabel = order.GetShippingLabel();
        // Console.WriteLine(shippingLabel);
        // ------------------------------------------------

        
        // We DO NOT need to write Console.WriteLine(...) because that already
        // is happening in the method below...we just need to call it.
        DisplayOrderSummary(order1);
        DisplayOrderSummary(order2);
        DisplayOrderSummary(order3);

    }

// -----------------------------------------------------------------------

    // Outside my main program, I am going to create a method that will be called
    // in my main program to DISPLAY the packing label, total cost and the shipping label
    // my parameter will be the object order from my Order class
    static void DisplayOrderSummary(Order order)
    {
        // - Call the methods to get the Packing label, 
        string packingLabel = order.GetPackingLabel();
        Console.WriteLine($"Order Summary for Customer:  {order.GetCustomerName()}");
        Console.WriteLine(packingLabel);

         // - Call the methods to get Total Price of Order, 
        double totalCost = order.GetTotalCost();
        // **Notice the formatting for the subtotal to get decimals
        Console.WriteLine($"Total Cost with Shipping: ${totalCost:0,0.00}");
        Console.WriteLine();

        // - Call the methods to get the Shipping label, 
        string shippingLabel = order.GetShippingLabel();
        Console.WriteLine(shippingLabel);
        Console.WriteLine();
        Console.WriteLine(new string( '=', 80));

    
    }


}