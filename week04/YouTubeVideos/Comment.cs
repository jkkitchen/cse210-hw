using System;
using System.Runtime.CompilerServices;

public class Comment
{
    //----Member Attributes----
    private string _commentAuthor;
    private string _commentText;

    //----Constructor----
    public Comment(string name, string text)
    {
        _commentAuthor = name;
        _commentText = text;
    }

    //----Method----
    public string DisplayComment()
    {
        return $"{_commentAuthor}: {_commentText}";
    }


}

