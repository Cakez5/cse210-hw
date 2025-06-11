using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        List<Video> videos = new List<Video>();

        Video v1 = new Video { Title = "Video game dev starter course", Author = "Devmaster123", Length = 900 };
        v1.AddComment(new Comment("Alice", "Great explanation!"));
        v1.AddComment(new Comment("Matt", "Thanks for the tips."));
        v1.AddComment(new Comment("Tanner", "Very helpful!"));
        videos.Add(v1);

        Video v2 = new Video { Title = "C# in schools Tutorial", Author = "Code#", Length = 450 };
        v2.AddComment(new Comment("Dana", "I finally get C# now!"));
        v2.AddComment(new Comment("Eli", "So well explained."));
        v2.AddComment(new Comment("Finn", "Great pacing and examples."));
        videos.Add(v2);

        Video v3 = new Video { Title = "IF only i knew Programming", Author = "TechWorld", Length = 380 };
        v3.AddComment(new Comment("Grace", "This helped me so much!"));
        v3.AddComment(new Comment("Hank", "this makes more sense now."));
        v3.AddComment(new Comment("Ivy", "Clear and concise."));
        videos.Add(v3);

        // Display "home screen"
        Console.WriteLine("===== Video Stats =====");
        Console.WriteLine("Select one or more videos to view by number (e.g., 1,2,3):");

        for (int i = 0; i < videos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {videos[i].Title}");
        }

        Console.Write("\nYour selection: ");
        string input = Console.ReadLine();
        string[] selections = input.Split(',');

        Console.Clear();
        Console.WriteLine("===== Video Details =====\n");

        foreach (var s in selections)
        {
            if (int.TryParse(s.Trim(), out int index) && index >= 1 && index <= videos.Count)
            {
                var video = videos[index - 1];
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length} seconds");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Invalid selection: {s}\n");
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}