using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Video 1
        //Create an empty list for the comments
        List<Comment> video1Comments = new List<Comment>();
        //Create the video
        Video video1 = new Video("Cute Kittens", "petlover123", 60, video1Comments);
        //Add the comments to the list
        Comment v1Comment1 = new Comment("cats4ever", "So cute!");
        video1Comments.Add(v1Comment1);
        Comment v1Comment2 = new Comment("huey23", "Adorable!");
        video1Comments.Add(v1Comment2);
        Comment v1Comment3 = new Comment("ashley3eva", "Love the little gray one!");
        video1Comments.Add(v1Comment3);

        //Display Info
        video1.DisplayInfo();
        Console.WriteLine();

        //Video 2
        //Create an empty list for the comments
        List<Comment> video2Comments = new List<Comment>();
        //Create the video
        Video video2 = new Video("Hilarious Dives", "swim123", 50, video2Comments);
        //Add the comments to the list
        Comment v2Comment1 = new Comment("swimmm", "So funny!");
        video2Comments.Add(v2Comment1);
        Comment v2Comment2 = new Comment("tree123", "What???");
        video2Comments.Add(v2Comment2);
        Comment v2Comment3 = new Comment("torrence12", "Looks painful...");
        video2Comments.Add(v2Comment3);

        //Display Info
        video2.DisplayInfo();
        Console.WriteLine();

        //Video 3
        //Create an empty list for the comments
        List<Comment> video3Comments = new List<Comment>();
        //Create the video
        Video video3 = new Video("Sweet Dance Moves", "discodiva", 30, video3Comments);
        //Add the comments to the list
        Comment v3Comment1 = new Comment("tatert0t", "You go girl!");
        video3Comments.Add(v3Comment1);
        Comment v3Comment2 = new Comment("yoohoo15", "Jealous!!!");
        video3Comments.Add(v3Comment2);
        Comment v3Comment3 = new Comment("dancer321", "Love it!");
        video3Comments.Add(v3Comment3);

        //Display Info
        video3.DisplayInfo();
        Console.WriteLine();
    }
}