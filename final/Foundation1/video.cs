using System;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthSeconds;
    public List<Comment> _comments;

    public Video(string title, string author, int lenghtSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lenghtSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }

    public int GetCommentsNumber()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {   
        Console.WriteLine();
        Console.WriteLine($"Video title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds} seconds.");
        Console.WriteLine($"Number of comments: {GetCommentsNumber()} comments.");
        Console.WriteLine();
        Console.WriteLine("Comments: ");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }


    }
}
