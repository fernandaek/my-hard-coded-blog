using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        //Most of the time we need add and remove an object so just do it unless its explicit to dont
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Title);
            stringBuilder.Append(Likes);
            stringBuilder.Append(" Likes - " + Moment );
            stringBuilder.AppendLine(Content);
            stringBuilder.AppendLine("Comments: ");

            foreach(Comment comment in Comments)
            {
                stringBuilder.AppendLine(comment.Text);
            }
            return stringBuilder.ToString();
        }
    }
}
