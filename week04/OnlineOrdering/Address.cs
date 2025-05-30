using System;

// Address:
// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in
//  one string (with newline characters where appropriate)

// CLASS DECLARATION
public class Address
{
    // ATTRIBUTE NAMES
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    
    private bool _isUSA;

    // CONSTRUTOR
    // Because I want to initialize the address fields when creating an 
    // Address object, I need to add parameters for street, city, state, country
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;

        // If country (converted to uppercase) is exactly 
        _isUSA = (country.ToUpper() == "USA" || country.ToUpper() == "UNITED STATES");
    }

    // METHODS
    // ---------------------------------------------------------
    // A WORD ON USING "GET":
    // Use "GET" when the method is RETURNING STORED data like GetAddres()
    // DO NOT use "GET" when the method is ANSWERING A QUESTION like Boolean methods(yes/no, true/false)
    // -------------------------------------------------------



    // 1. bool isUSA()
    // The address should have a method that can return whether it is 
    // in the USA or not.

    // ------------------------------------
    // Use PascalCase for METHODS -  so capital I on "Is" and capital U on "USA"
    // IsUSA
    // **But keep lowercase i on "is" on the return variable
    // _isUSA
    // --------------------------------------
    public bool IsUSA()
    {
        return _isUSA;
    } 

    // 2.  GetAddress()
    // The address should have a method to return a string all of its 
    // fields together in one string (with newline characters where appropriate)
    // **Don't forget data type(string) here 
    public string GetAddress()
    {
        // Use "\n" when you want a formatted string with newline charcters
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}