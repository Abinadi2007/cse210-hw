using System;

public class Entry
{
    private string _text;
    private DateTime _date;

    public Entry(string text)
    {
        _text = text;
        _date = DateTime.Now; 
    }

    public void Display()
    {
        Console.WriteLine($"{_date}: {_text}");
    }

    public string GetText()
    {
        return _text;
    }

    public DateTime GetDate()
    {
        return _date;
    }
}
