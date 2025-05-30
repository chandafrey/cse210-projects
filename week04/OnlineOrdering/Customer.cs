using System;


// Customer
// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return 
// whether they live in the USA or not. 
// (Hint this should call a method on the address to find this.)


// CLASS DECLARATION
public class Customer
{
    // ATTRIBUTE NAMES
    private string _customer;
    // **just like string is a data type for _customer, 
    // Address is the data type for _address
    private Address _address;

    // -------------------------------------------
    // A WORD ON USING _customer vs customer:
        // private string _customer;      // ← class field
        // private Address _address;      // ← class field

        // public Customer(string customer, Address address) // ← method parameters
        // {
        //     _customer = customer;  // ← assign parameter to field
        //     _address = address;    // ← assign parameter to field
        // }

        // customer and address are temporary values passed in during construction.
        // _customer and _address are the permanent storage in the class.
    
    // more below    
    // -------------------------------------------


    // CONSTRUCTOR
    public Customer(string customer, Address address)
    {
        _customer = customer;
        _address = address;
    }

    // GETTERS/SETTERS
    // I am going to get/set the customer so it can be used in my order and program
    public string GetName()
    {
        return _customer;
    }

    // METHODS

    // 1.  IsUSA()     - Keep Consistancy by naming same as in Address Class
    // The customer should have a method that can return whether they live 
    // in the USA or not. (Hint this should call a method on the address 
    // to find this.)
    public bool IsUSA()
    {
        return _address.IsUSA();
    }

    // 2. GetCustomerData()
    // A shipping label should list the name and address of the customer
    // So I need to create a GetCustomerData() method to use in my Order class
    public string GetCustomerData()
    {
    // -------------------------------------------
    // A WORD ON USING _customer vs customer:
    
    // Don't use just address.GetAddress() here.
    // address only exists in the constructor.
    // Outside of that, you'd get an error saying it's undefined 
    // — unless it’s a method parameter or local variable.
    
    // Use the dot (.) to call a method on an object.
    // Use _name when referring to your class’s internal object or value.
    // like this:   _address.GetAddress()
    // ---------------------------------------------
    
        // add "\n" after {_customer} so the address will print on a new WriteLine
        return $"{_customer}\n{_address.GetAddress()}";
    }
}