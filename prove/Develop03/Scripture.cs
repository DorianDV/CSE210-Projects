using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    //Attributes
    private string _scripture;
    private List<string> _split = new List<string>();
    //Constructors
    public Scripture()
    {
        _scripture = "In the beginning God created the heaven and the earth.";
    }
    public Scripture(string wholeScripture)
    {
        _scripture = wholeScripture;
    }
    //Getters and Setters

    //Methods
    public void Display()
    {
        Console.WriteLine(_scripture);
    }
    public List<string> ScriptureSplit()
    {        
        _split = _scripture.Split(" ").ToList();
        return _split;
    }   
}