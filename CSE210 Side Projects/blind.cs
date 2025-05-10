public class Blind
{
    public double _width;
    public double _height;
    public string _color;

    // we are going to add a location property to the Blind class so we can use it in the list code in the main program file
    public string _location;


    // Constructor to initialize the blind with default values  
    public Blind()
    {
        _width = 0;
        _height = 0;
        _color = "white";
        // don't forget to set the _location property to an empty string here just like you set variable in python to an empty string or 0 before using them.
        // this is important because if you don't set it to an empty string, it will be null and you will get an error when you try to use it in the list code in the main program file
        _location = "";
    }

    public double GetArea()
    {
        return _width * _height;
    }

}
