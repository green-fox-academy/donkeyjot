using System;
namespace Blog
{

    public class BlogPost
    {
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string PublicationDate { get; set; }

        public BlogPost(string authorName, string title, string text, string publicationDate)
        {
            AuthorName = authorName;
            Title = title;
            Text = text;
            PublicationDate = publicationDate;
        }
    }

}
