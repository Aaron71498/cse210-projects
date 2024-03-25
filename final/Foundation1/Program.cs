using System;

class Program
{
    static void Main(string[] args)
    {
        // list of the videos
        List<Video> videos = new List<Video>();

        // video 1 creation
        Video v1 = new Video("How to Drink Water", "Water_Drinker_9000", 30);
        // video 1 comments
        Comment v1c1 = new Comment("Water_Lover", "Your video was so helpful!");
        Comment v1c2 = new Comment("Water_Hater", "Who needs to drink water?");
        Comment v1c3 = new Comment("Normal Human", "Ah, yes. I, too, drink water, just like my fellow normal humans.");
        // add comments to video 1
        v1.AddComment(v1c1);
        v1.AddComment(v1c2);
        v1.AddComment(v1c3);
        // add video 1 to videos list
        videos.Add(v1);

        // video 2 creation
        Video v2 = new Video("Top 10 Kahoot Upsets", "Kahoot_Player_Man", 600);
        // video 2 comments
        Comment v2c1 = new Comment("Kahoot_Enjoyer", "Number 7 was insane!");
        Comment v2c2 = new Comment("Kahoot_Player", "I was there for number 3!");
        Comment v2c3 = new Comment("Kahoot_Hater", "Who cares? It's a dumb game anyway.");
        Comment v2c4 = new Comment("Normal Human", "As a fellow normal human, I enjoy Kahoot.");
        // add comments to video 2
        v2.AddComment(v2c1);
        v2.AddComment(v2c2);
        v2.AddComment(v2c3);
        v2.AddComment(v2c4);
        // add video 2 to videos list
        videos.Add(v2);

        // video 3 creation
        Video v3 = new Video("Computers are Spying on Us for the Government!", "Computer_Conspiracist", 1200);
        // video 3 comments
        Comment v3c1 = new Comment("Conspiracy_Man", "I knew it! Computers are magic, and using them lets the government control our minds!");
        Comment v3c2 = new Comment("Conspiracy_Debunker", "This is clearly false. You obviously don't understand how computers work.");
        Comment v3c3 = new Comment("Normal Human", "Oh no! I better be more careful with my normal human computer!");
        // add comments to video 3
        v3.AddComment(v3c1);
        v3.AddComment(v3c2);
        v3.AddComment(v3c3);
        // add video 3 to videos list
        videos.Add(v3);

        // display video details
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------"); // buffer line
            video.DisplayInfo();
        }
    }
}