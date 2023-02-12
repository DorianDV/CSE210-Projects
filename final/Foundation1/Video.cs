using System;
using System.Collections.Generic;

class Video
{
    //Attributes
    private string _tittle, _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    //Constructors
    public Video(string tittle, string author, int length)
    {
        _tittle = tittle;
        _author = author;
        _length = length;
    }
    //Getters and Setters
    public void SetComments(List<Comment> comments)
    {
        _comments = comments;
    }
    //Methods
    private int NumberOfComments()
    {
        return _comments.Count();
    }
    public void Display()
    {
        Console.WriteLine($"{_tittle}\n{_author}\nDuration: {_length} seconds\n{NumberOfComments()} Comments");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        
    }
    

}