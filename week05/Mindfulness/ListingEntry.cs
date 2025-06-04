using System;

// CLASS DECLARATION
public class ListingEntry
{
    // CLASS ATTRIBUTES
    // Create three variables to hold the ListingEntry details
    private string _date;
    private string _prompt;
    private List<string> _entries;


    // CONSTRUCTOR
    public ListingEntry()
    {
        _date = DateTime.Now.ToShortDateString();
        _prompt = "";
        _entries = new List<string>();
    }


    // GETTER/SETTER
   // ---------------------
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
       // ---------------------
       public string GetPrompt()
    {
        return _prompt;
    }
    public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }
       // ---------------------
       public List<string> GetEntries()
    {
        return _entries;
    }
    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }
}