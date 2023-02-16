using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("Bassols", "Barcelona", "Barcelona", "España");

        Lectures l1 = new Lectures("First Event", "Description of Lectures","15-02-2023","18h","Lectures", a1, "Dorian Delugo",16);
        Receptions r1 = new Receptions("Second Event", "Description of Receptions","15-02-2023","18h","Receptions", a1, "doriandelugo@gmail.com");
        OutdoorGatherings o1 = new OutdoorGatherings("Third Event", "Description of OutdoorGatherings","15-02-2023","18h","OutdoorGatherings", a1, "sunny");

        Console.Clear();

        l1.DisplayStandard();
        Console.WriteLine();
        l1.DisplayShort();
        Console.WriteLine();
        l1.DisplayFull();
        Console.WriteLine();
        Console.WriteLine("--------");

        r1.DisplayStandard();
        Console.WriteLine();
        r1.DisplayShort();
        Console.WriteLine();
        r1.DisplayFull();
        Console.WriteLine();
        Console.WriteLine("--------");

        o1.DisplayStandard();
        Console.WriteLine();
        o1.DisplayShort();
        Console.WriteLine();
        o1.DisplayFull();
        Console.WriteLine();
        Console.WriteLine("--------");
        
            
           
        
    }
}