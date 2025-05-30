using System;


// Product
// Contains the name, product id, price, and quantity of each product.
// The total cost of this product is computed by multiplying the price 
// per unit and the quantity. (If the price per unit was $3 and they 
// bought 5 of them, the product total cost would be $15.)


// CLASS DECLARATION
public class Product
{
     // ATTRIBUTE NAMES
    //  ------------------------------------
    //  keep names short and clear
    // It is better to say _name, than to say _productName because we are already in the
    // Product class...and if we have to refer to it, it is less wordy to write
    // Product name, versus Product productName
    // --------------------------------------
    private string _name;
    private string _id;
    // Use "double" for price because "int" is for WHOLE numbers, "double" allows for DECIMALS
    private double _price;
    private int _quantity;

     // CONSTRUCTOR
    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    // GETTERS and SETTERS
    // -------------------------------------------------------
    // ***This allows another part of the program the ability to
    // GET (read) or SET (modify) the value of private variables, 
    // like _name, and access when needed, BUT it does it by 
    // CALLING these METHODS, rather than accessing the variables
    // directly...This is an example of ENCAPSULATION
    // -------------------------------------------------------
    // Not sure if I need these, but putting them here for maybe
    
    // GETTER: We can write it like this:
    // public string GetName() => _name;
    
    // OR like this:
    public string GetName()
    {
        return _name;
    }

    // SETTER: We can write it like this:
    // public void SetName(string name) => _name = name;

    // Or like this:
    public void SetName(string name)
    {
        _name = name;
    }
// ------------------------
    public string GetId()
    {
        return _id;
    }
    public void SetId(string id)
    {
        _id = id;
    }
// -------------------------
    public double GetPrice()
    {
        return _price;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
// --------------------------
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    // -------------------------------------------------
        //🔍 Explanation:
        // public — This method can be called from outside the class.

        // void — This method doesn't return anything.

        // SetName(string name) — This method takes one parameter called name, which is a string.

        // 🔁 What it's doing:
        // It assigns the value passed in (name) to the private field _name.

        // So if you do this in your Program.cs:

        // Product product = new Product("Widget", "W123", 4.99, 2);
        // product.SetName("Gadget");
        // You're telling the product to change its internal name 
        // from "Widget" to "Gadget" by using the setter method — 
        // rather than directly accessing the _name field.
    // ---------------------------------------------------


    // METHODS

    // 1.  GetTotalCost()
    // Total Cost of the product is computed by multiplying the
    // price per unit and the quantity
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // 2.  GetProductData()
    // A packing label should list the name and product id of each product in the order.
    // So I will also need a method to return NAME and ID

    // ***I added quantity because I personally want to know
    // - the quantity of an item purchased
    // - the price of the item
    public string GetProductData()
    {
        return $"Product Name:  {_name},  Product ID:  {_id},  Quantity:  {_quantity}  Unit Price: ${_price:0,0.00}";
    }
}
