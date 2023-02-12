using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("First Video", "Dorian Delugo", 190);
        Comment cv1 = new Comment("Dorian Delugo","this is the firts comment.");
        Comment cv2 = new Comment("Dorian Delugo","this is the second comment.");
        Comment cv3 = new Comment("Dorian Delugo","this is the third comment.");
        List<Comment> commentsv1= new List<Comment>()
        {
            cv1,cv2,cv3
        };
        v1.SetComments(commentsv1);

        Video v2 = new Video("Second Video", "Dorian Delugo", 195);
        Comment cv21 = new Comment("Dorian Delugo","this is the firts comment.");
        Comment cv22 = new Comment("Dorian Delugo","this is the second comment.");
        Comment cv23 = new Comment("Dorian Delugo","this is the third comment.");
        List<Comment> commentsv2= new List<Comment>()
        {
            cv21,cv22,cv23
        };
        v2.SetComments(commentsv2);

        Video v3 = new Video("Third Video", "Dorian Delugo", 200);
        Comment cv31 = new Comment("Dorian Delugo","this is the firts comment.");
        Comment cv32 = new Comment("Dorian Delugo","this is the second comment.");
        Comment cv33 = new Comment("Dorian Delugo","this is the third comment.");
        List<Comment> commentsv3= new List<Comment>()
        {
            cv31,cv32,cv33
        };
        v3.SetComments(commentsv3);

        List<Video> videos = new List<Video>()
        {
            v1,v2,v3
        };

        Console.Clear();

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}