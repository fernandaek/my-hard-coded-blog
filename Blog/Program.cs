using System;
using System.Globalization;
using Blog.Entities;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment comment_1 = new Comment("Have a nice trip!"); //Hard coded
            Comment comment_2 = new Comment("Wow that's awesome!");

            Post post_1 = new Post(
                DateTime.ParseExact("21/06/2019 13:05:44", "dd/MM/yyyy H:mm:ss", null),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
                );
            post_1.AddComment(comment_1);
            post_1.AddComment(comment_2);

            //Console.WriteLine(comment_1);

            Comment comment_3 = new Comment("Good Night!");
            Comment comment_4 = new Comment("May the force be with you.");

            Post post_2 = new Post(
                DateTime.ParseExact("28/07/2019 23:20:14", "dd/MM/yyyy H:mm:ss", null),
                "Good night guys",
                "See you tomorrow",
                5
                );
            post_2.AddComment(comment_3);
            post_2.AddComment(comment_4);

            Console.WriteLine(post_1);
            Console.WriteLine(post_2);
        }
    }
}
