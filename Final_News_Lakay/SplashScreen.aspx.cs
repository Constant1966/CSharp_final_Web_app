using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Final_News_Lakay
{
    public partial class SplashScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        static List<News> newsList = new List<News>();

        public static void Connect()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["nouvellakay"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
            }
        }

        public static void CreateDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["nouvellakay"].ConnectionString;

            // Création de la table News
            string sqlCreate = @"CREATE TABLE IF NOT EXISTS news (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            Source TEXT,
                            Author TEXT,
                            Title TEXT,
                            Description TEXT,
                            Url TEXT,
                            UrlToImage LONGBLOB,
                            PublishedAt DATETIME,
                            Content TEXT
                        )";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sqlCreate, connection);
                command.ExecuteNonQuery();
            }
        }


        public static void InsertIntoDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["nouvellakay"].ConnectionString;

            List<News> list = Utilities.GetNews();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                foreach (News item in list)
                {
                    string sqlInsertQuery = @"INSERT INTO news (Source, Author, Title, Description, Url, UrlToImage, PublishedAt, Content)
                                              VALUES (@Source, @Author, @Title, @Description, @Url, @UrlToImage, @PublishedAt, @Content)";

                    MySqlCommand command = new MySqlCommand(sqlInsertQuery, connection);

                    command.Parameters.AddWithValue("@Source", item.Source);
                    command.Parameters.AddWithValue("@Author", item.Author);
                    command.Parameters.AddWithValue("@Title", item.Title);
                    command.Parameters.AddWithValue("@Description", item.Description);
                    command.Parameters.AddWithValue("@Url", item.Url);
                    command.Parameters.AddWithValue("@UrlToImage", item.UrlToImage);
                    command.Parameters.AddWithValue("@PublishedAt", item.PublishedAt);
                    command.Parameters.AddWithValue("@Content", item.Content);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<News> SelectFromDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["nouvellakay"].ConnectionString;
            string sqlSelectQuery = @"SELECT Source, Author, Title, Description, Url, UrlToImage, PublishedAt, Content FROM news";
            List<News> newsList = new List<News>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(sqlSelectQuery, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string Source = reader.GetString(0);
                            string Author = reader.GetString(1);
                            string Title = reader.GetString(2);
                            string Description = reader.GetString(3);
                            string Url = reader.GetString(4);
                            byte[] UrlToImageBytes = (byte[])reader["UrlToImage"];
                            DateTime PublishedAt = reader.GetDateTime(6);
                            string Content = reader.GetString(7);

                            newsList.Add(new News(Source, Author, Title, Description, Url, UrlToImageBytes, PublishedAt, Content));
                        }
                    }
                }
            }

            return newsList;
        }
    }
}
