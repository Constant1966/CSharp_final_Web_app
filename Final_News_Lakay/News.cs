using System;

namespace Final_News_Lakay
{
    public class News
    {
        private string name;
        private byte[] urlToImageBytes;

        public News()
        {
        }

        public News(string name, string author, string title, string description, string url, byte[] urlToImageBytes, DateTime publishedAt, string content)
        {
            this.name = name;
            Author = author;
            Title = title;
            Description = description;
            Url = url;
            this.urlToImageBytes = urlToImageBytes;
            PublishedAt = publishedAt;
            Content = content;
        }

        public string Source { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }
        public int Id { get; set; }
        public System.Drawing.Image Images { get; set; }
    }
}