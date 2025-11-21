using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new("Pepe320", "This is the greatest video I've ever seen!!!");
        Comment comment2 = new("Firedragon1997", "YouTube is not what it used to be");
        Comment comment3 = new("skibidiBrainrot", "First to comment!!!!!!");

        List<Comment> video1Comments = [comment1, comment2, comment3];

        Video video1 = new("The greatest video you'll ever see!!", "Pepe319", 6200, video1Comments);
        video1.DisplayInfo();

        Comment comment4 = new("Pepe319", "THESE ARE ALL LIESS!!!!!1!!");
        Comment comment5 = new("chillguy", "idk man, I'm just chillin");
        Comment comment6 = new("skibidiBrainrot", "I like cheese");

        List<Comment> video2Comments = [comment4, comment5, comment6];

        Video video2 = new("Critic to Pepe319", "Adam638", 8100, video2Comments);
        video2.DisplayInfo();

        Comment comment7 = new("Pepe319", "This is actually epic");
        Comment comment8 = new("skibidiBrainrot", "What a wonderful world");
        Comment comment9 = new("Adam638", "I feel humble");

        List<Comment> video3Comments = [comment7, comment8, comment9];

        Video video3 = new("The Wonders of The Earth", "chillguy", 10490, video3Comments);

        List<Video> videos = [video1, video2, video3];

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}