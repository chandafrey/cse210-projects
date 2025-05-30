using System;
using System.Collections.Generic;

// Order
// -> Contains a list of products and a customer. 

// -> Can return a string for the shipping label.
    // - A shipping label should list the name and address of the customer

// -> Can return a string for the packing label. 
    // - A packing label should list the name and product id 
    // of each product in the order.
    
// - Can calculate the total cost of the order. 
    // - The total price is calculated as the sum of the 
    // total cost of each product plus a one-time shipping cost.

    // This company is based in the USA. 
    // - If the customer lives in the USA, then the shipping cost is $5. 
    // - If the customer does not live in the USA, then the shipping cost is $35.


// CLASS DECLARATION
public class Order
{
    // ATTRIBUTE NAMES
    // - Contains a list of products and a customer. 
    // --------------------------------------------
    // LIST ATTRIBUTE>>>>
    // use private 
    // use List<> because your data type is a list
    // use <Product> because you're creating a list that holds Product objects
    // use _products because its the name of the list(needs to be plural)
    // ---------------------------------------------
    private List<Product> _products;
    // **just like string is a data type, Customer is the data type for _customer
    private Customer _customer;

        // CONSTRUCTOR
    // ----------------------------------
    // We are NOT going to add List<Product> products in the parameters because:
        // Encapsulation: You’re keeping control over how the products list is managed inside the Order class.
        // Flexibility: You can start with an empty list and add products later using your AddProduct() method.
    // -----------------------------------
    // -----------------------------------
    // ***the parameter Customer customer means we are passing in the 
    // WHOLE OBJECT Customer with all its information
        // -string name
        // -Address object
        // -customer.IsUSA() to check for shipping cost
    // --------------------------------------
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }


    // METHODS

    // 1. AddProduct()
    // Before moving on, we need to ADD products to the products List
    // --------------------------------------
    // **Data type is "void" because:
    // this method DOES NOT RETURN ANYTHING.. it simply performs an action
    // taking in a Product object and adding it to the _products list.
    // ---------------------------------------
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // 2. GetShippingLabel()
    // - Can return a string for the shipping label.
    // - A shipping label should list the name and address of the customer
    public string GetShippingLabel()
    {        
        return $"Shipping Label:\n{_customer.GetCustomerData()}";
    }

    // 3. GetPackingLabel()  
    // - Can return a string for the packing label. 
    // - A packing label should list the name and product id 
    // of each product in the order.
    // **In other words - foreach product...return a label with name and id
    public string GetPackingLabel()
    {

        // We need a label variable declared BEFORE the foreach loop
        // set it to empty ""
        string label = "";

        // Use the data type in the parameters...
        // Since product is coming from the Product class - 
        // that is its data type (not string)
        foreach (Product product in _products)
        {
            // Use the += to interate thru each product
             // For each product in the order:
            // - Add the product's data to the label string
            // - Add a newline character to move to the next line
            // - Add a dashed separator line for better readability
            label += product.GetProductData() + "\n";
            label += new string('-', 40) + "\n";

        }
        return $"Packing Label: \n{label}";
    }

    // 4. GetTotalCost()
    //  Can calculate the total cost of the order. 
    // - The total price is calculated as the sum of the 
    // total cost of each product plus a one-time shipping cost.
    // ------------------
     // This company is based in the USA. 
    // - If the customer lives in the USA, then the shipping cost is $5. 
    // - If the customer does not live in the USA, then the shipping cost is $35.
    // -------------------
    // **In other words - foreach product...
    // get the price and += ADD it to the previous product to get a sum
    // THEN check IF the customer lives in the USA (isUSA)
        // if isUSA is true, then ADD shipping cost of $5
        // else isUSA is false, then Add shipping cost of $35

    public double GetTotalCost()
    {
        
        // We need a subtotal variable declared BEFORE the foreach loop
        // set it to 0
        double subtotal = 0;
        double shippingCostUSA = 5;
        double shippingCostNotUSA = 35;
        double totalCost = 0;

        foreach (Product product in _products)
        {
            subtotal += product.GetTotalCost();
        }

        // Add shipping cost based on customer's location
        // double shippingCost = _customer.IsUSA() ? shippingCostUSA : shippingCostNotUSA;
        // double totalCost = subtotal + shippingCost;

        // OR WRITE IT WITH IF/ELSE Statement
        // (_customer.IsUSA()) returns true if customer is in USA
        // we could also write (_customer.IsUSA == true) but is redundant
        if (_customer.IsUSA())
        {
            // If customer is in USA, use domestic shipping
            totalCost = subtotal + shippingCostUSA;
        }
        else
        {
            // If customer is Not in USA, use international shipping
            totalCost = subtotal + shippingCostNotUSA;
        }
        return totalCost;
    }

    // I am going to add another method here to get only customer name
    public string GetCustomerName()
    {
        return _customer.GetName();
    }

}