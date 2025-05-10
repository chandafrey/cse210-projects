using System.Dynamic;

public class House
{
// set the _owner property to an empty string here just like you set variable in python to an empty string or 0 before using them.


    public string _owner = "";
    public Blind _kitchen = new Blind();
    public Blind _livingRoom = new Blind();

    public List<Blind> _blinds = new List<Blind>();
    // Constructor to initialize the house with default values

}