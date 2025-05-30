using System;
using System.Security.Cryptography.X509Certificates;

public class Video
{
    //----Member Attributes
    private string _videoTitle = "";
    private string _videoAuthor = "";
    private int _length = 0;
    private List<Comment> _comments;


    //----Constructor-----
    public Video(string title, string author, int length, List<Comment> comments)
    {
        _videoTitle = title;
        _videoAuthor = author;
        _length = length;
        _comments = comments;
    }


    //----Methods----
    public void DisplayInfo()
    {
        //Determine the number of comments for the video
        int numberComments = _comments.Count;

        //Write out the info for each video and iterate through the list of comments to display them
        Console.WriteLine($"Title: {_videoTitle}");
        Console.WriteLine($"Author: {_videoAuthor}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {numberComments}");
        Console.WriteLine($"Comments:");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.DisplayComment());
        }

    }
}