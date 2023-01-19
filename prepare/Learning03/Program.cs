using System;

class Program
{
    static void Main(string[] args)
    {
        //Trying constructors
        Fraction fraction1 = new Fraction();
        fraction1.SetTop(6);
        Console.WriteLine($"_bottom rn: {fraction1.GetBottom()}");
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(25);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(25,5);
         Console.WriteLine($"_bottom rn: {fraction3.GetBottom()}");
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        //Prove
        int top = -1;
        int bottom= -1;
        
        while (top != 0)
        {
            Console.Write("Write Top number: ");
            top = int.Parse(Console.ReadLine());

            Console.Write("Write Bottom number: ");
            bottom = int.Parse(Console.ReadLine());

            Fraction fraction4 = new Fraction(top, bottom);
            Console.WriteLine(fraction4.GetFractionString());
            Console.WriteLine(fraction4.GetDecimalValue().ToString());

        }


    }
}