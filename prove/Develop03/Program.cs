using System;

class Program
{
    static void Main(string[] args)
    {
        //Store Reference
        string scripture = "Helaman";
        int chapter = 3;
        int verseStart = 28;
        int verseEnd = 29;

        Reference reference1 = new Reference(scripture, chapter, verseStart, verseEnd);
        // Reference reference1 = new Reference();
        

        //Store Scripture
        string wholeEcripture = "Yea, thus we see that the gate of heaven is open unto all, even to those who will believe on the name of Jesus Christ, who is the Son of God; Yea, we see that whosoever will may lay hold upon the word of God, which is quick and powerful, which shall divide asunder all the cunning and the snares and the wiles of the devil, and lead the man of Christ in a strait and narrow course across that everlasting gulf of misery which is prepared to engulf the wicked-";
        Scripture scripture1 = new Scripture(wholeEcripture);
        // Scripture scripture1 = new Scripture();
        

        //Clear Console and start to hide or quit the program
        Hide hide1 = new Hide(scripture1.ScriptureSplit());
        


        string desition = "";
        Console.Clear();
        reference1.Display();
        scripture1.Display();

        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        desition = Console.ReadLine();
        if (desition == "")
        {
            bool status = hide1.Status();
            Console.WriteLine(status);
            while (desition != "quit" && status == false)
            {
                
                Console.Clear();
                
                reference1.Display();
                hide1.DisplayBetterHide();

                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
                status = hide1.Status();
                if (status == false)
                {
                    desition = Console.ReadLine();
                }
                
            }        
        }
        
        
        

        



        
        




    }
}