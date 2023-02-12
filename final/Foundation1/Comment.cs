using System;

class Comment
{
    //Attributes
    private string _name, _comment;
    //Constructors
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }
    //Getters and Setters

    //Methods
    public void DisplayComment()
    {
        Console.WriteLine($"{_name}\n{_comment}");
    }
    
}