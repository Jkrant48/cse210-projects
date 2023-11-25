using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Console.WriteLine("Video and comment tracking program!");
        Console.WriteLine();

        Video video1 = new Video("Inspiration video", "Mike studios", 300);
        video1.AddComment("User121", "Great video!!");
        video1.AddComment("User262", "Learnt alot from your video!");
        video1.AddComment("User453", "Nice one!!");
        videos.Add(video1);

        Video video2 = new Video("Demonstration video", "Joey studios", 300);
        video2.AddComment("User761", "Great video!!");
        video2.AddComment("User782", "Learnt alot from your video!");
        video2.AddComment("User983", "Nice one!!");
        videos.Add(video2);

        Video video3 = new Video("Educational video", "Sams studios", 300);
        video3.AddComment("User671", "Great video!!");
        video3.AddComment("User342", "Learnt alot from your video!");
        video3.AddComment("User433", "Nice one!!");
        videos.Add(video3);
        
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
        
    } 
    
}