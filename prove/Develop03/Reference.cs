using System;
using System.Collections.Generic;

public class Reference
{
    //Esta clase recoge la información individual de la referencia de la escritura 
    //(Libro, cápitulo, versiculo inicial, versiculo final)
    //y te la muestra por panntalla con el siguiente formato:
    // --> Genesis 1:1-2 

    //Attrbutes
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    //Constructors 
    public Reference()
    {
        _book = "Genesis";
        _chapter = 1;
        _verseStart = 1;
        _verseEnd = 0;
    }
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }
    //Getters and Setters are not needed


    //Methods
    public void Display()
    {
        if (_verseEnd < _verseStart)
        {
            Console.Write($"{_book} {_chapter}:{_verseStart} ");
        }
        else 
        {
            Console.Write($"{_book} {_chapter}:{_verseStart}-{_verseEnd} ");
        }
    }
}