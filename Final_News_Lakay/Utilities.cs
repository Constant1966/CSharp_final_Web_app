using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System;

namespace Final_News_Lakay
{
    public class Utilities
    {
        public static List<News> GetNews()
        {

            List<News> listnews = new List<News>();
            //string MyapiKey = "a48488323df048f0afe6279043eee27f";

            using (WebClient client = new WebClient())
            {
                string jsonString = client.DownloadString("https://newsapi.org/v2/top-headlines?sources=techcrunch&apiKey=a48488323df048f0afe6279043eee27f");

                var jsonDocument = JsonDocument.Parse(jsonString);
                var root = jsonDocument.RootElement;

                if (root.TryGetProperty("articles", out JsonElement articlesElement) && articlesElement.ValueKind == JsonValueKind.Array)
                {
                    foreach (var article in articlesElement.EnumerateArray())
                    {
                        // Access properties of each article
                        string name = article.GetProperty("source").GetProperty("name").GetString();
                        string author = article.GetProperty("author").GetString();
                        string title = article.GetProperty("title").GetString();
                        string description = article.GetProperty("description").GetString();
                        string url = article.GetProperty("url").GetString();
                        string UrlToImage = article.GetProperty("urlToImage").GetString();
                        byte[] imageBytes;

                        using (var webClient = new WebClient())
                        {
                            imageBytes = webClient.DownloadData(UrlToImage);

                        }
                        DateTime publishedAt = article.GetProperty("publishedAt").GetDateTime();
                        string content = article.GetProperty("content").GetString();

                        News news = new News(name, author, title, description, url, imageBytes, publishedAt, content);

                        listnews.Add(news);
                    }
                }
            }
            return listnews;
        }
    }
}