using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video v1 = new Video("Vsause", "Science", 300);
        v1.NewComment(new Comment("Robert", "This was such an interesting Video!!"));
        v1.NewComment(new Comment("Alison", "MIND BLOWN"));
        v1.NewComment(new Comment("Carlos", "This cant be true"));
        videoList.Add(v1);

        Video v2 = new Video("Markaplier", "Rage Game", 3600);
        v2.NewComment(new Comment("Listen_To_Me", "SOOooooo Funny!!!"));
        v2.NewComment(new Comment("DonTheDon", "Play getting over it next!"));
        v2.NewComment(new Comment("Lissa18", "I LOVE YOUR VIDEOS!!"));
        videoList.Add(v2);

        Video v3 = new Video("Kurzgesagt - In a Netshell", "The Universe", 1200);
        v3.NewComment(new Comment("ScienceBrad", "I Love Black Holes So Much!!"));
        v3.NewComment(new Comment("AustinTheCat", "If what your saying is true, than how has the universe not collapsed on itsel yet?"));
        v3.NewComment(new Comment("TheCarGoesVroom", "You guys are so smart!"));
        videoList.Add(v3);

        foreach (Video v in videoList)
        {
            v.Display();
        }
    }
}