using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# coding made easy", "John Dennis", 300);
        videos.Add(video1);
        video1.AddComment("Philip", "Great video! very helpful.");
        video1.AddComment("Sarah", "I learned a lot, thanks!");
        video1.AddComment("Emily", "Can you make a video on advanced topics?");
        video1.AddComment("Techguru", "clear and concise explanations.");
        
        // video2
        Video video2 = new Video("Learn python in 10 minutes", "Jane Smith", 600);
        videos.Add(video2);
        video2.AddComment("Alex", "This was a great introduction to python.");
        video2.AddComment("Maria", "I wish there were more examples.");
        video2.AddComment("David", "Can you make a follow-up video on data science with python?");
        video2.AddComment("CodeMaster", "Well structured and easy to follow.");

        // video 3
        Video video3 = new Video("JavaScript for beginners", "Emily Davis", 450);
        videos.Add(video3);
        video3.AddComment("Christian", "This video helped me understand the basics of programming.");
        video3.AddComment("Sophia", "A very educative video, thank you!");
        video3.AddComment("Mike", "How am i just finding your channel now");
        video3.AddComment("Blessing", "Exactly the video i have been looking for");
        
        // Display video information
        foreach (Video video in videos)
        {
            video.Display();
            
        }
    }
    
    


}