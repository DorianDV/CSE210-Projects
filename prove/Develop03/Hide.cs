using System;
using System.Linq;
using System.Collections.Generic;

public class Hide
{
    //Atributes
    private List<string> _hiddenList = new List<string>();
    private string _hiddenListToString;
    private bool _isAllEqual;
    //Constructors
    public Hide(List<string> scriptureInList)
    {
        _hiddenList = scriptureInList;
    }

    // Getters and Setters

    //Methods 

    private void DisplayHide()
    {
        Random randomGenerator = new Random();
        int number1 = randomGenerator.Next(0, _hiddenList.Count -1);
        int number2 = randomGenerator.Next(0, _hiddenList.Count -1);
        int number3 = randomGenerator.Next(0, _hiddenList.Count -1);

        _hiddenList[number1] = "___";
        _hiddenList[number2] = "___";
        _hiddenList[number3] = "___";

        _hiddenListToString = string.Join(" ", _hiddenList);
        Console.WriteLine(_hiddenListToString);
    }

    public void DisplayBetterHide()
    {
        
        if (Status() == false)
        {
            for (int i = 0; i < 3; i++)
            {
                 
                if (Status() == true)
                {
                    break;
                }
                else
                {
                    Random randomGenerator = new Random();
                    int number = randomGenerator.Next(0, _hiddenList.Count -1);

                    if (_hiddenList[number] == "___")
                    {
                        while (_hiddenList[number] == "___")
                        {    
                            number = randomGenerator.Next(0, _hiddenList.Count);                    
                            if (_hiddenList[number] != "___")
                            {
                            _hiddenList[number] = "___";
                            break;
                            }
                        }
                    
                    
                    }
                    else
                    {
                        _hiddenList[number] = "___";
                    }
                }
            }
            _hiddenListToString = string.Join(" ", _hiddenList);
            Console.WriteLine(_hiddenListToString);
        }
        
              
    }
    public bool Status()
    {
        _isAllEqual = _hiddenList.Distinct().Count() == 1;
        return _isAllEqual;
    }
}