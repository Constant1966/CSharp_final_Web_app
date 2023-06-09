using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_News_Lakay
{
    public partial class MainNews : System.Web.UI.Page
    {
        public static int indice = 0;

        public static List<News> list;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DataLoad();
            }
            SplashScreen.Connect();
            SplashScreen.CreateDatabase();
            SplashScreen.InsertIntoDatabase();
            SplashScreen.SelectFromDatabase();

        }

        protected void DataLoad()
        {
            Thread.Sleep(3000);

            list = SplashScreen.SelectFromDatabase();

            if (indice == 0)
            {
                Btn_Premier.Enabled = false;
                Btn_Suivant.Enabled = false;
            }
            else
            {
                Btn_Suivant.Enabled = true;
                Btn_Avant.Enabled = true;
            }

            if (indice == list.Count - 6)
            {
                Btn_Premier.Enabled = false;
                Btn_Dernier.Enabled = false;
            }
            else
            {
                Btn_Dernier.Enabled = true;
                Btn_Premier.Enabled = true;
            }

            List<News> list_2 = new List<News>()
            {
                list[indice],
                list[indice + 1],
                list[indice + 2],

            };

            News news1 = list_2.ElementAt(0);

            lbl_Titre.Text = news1.Title;
            lbl_Author_1.Text = news1.Author;
            lbl_PublishdAte_1.Text = news1.PublishedAt.ToString();
            ImageButton1.ImageUrl = new Uri(news1.UrlToImage).AbsoluteUri;
            ImageButton1.Visible = true;




            News news2 = list_2.ElementAt(1);
            lbl_Titre_2.Text = news2.Title;
            lbl_Author_2.Text = news2.Author;
            lbl_PublishdAte_2.Text = news2.PublishedAt.ToString();
            ImageButton2.ImageUrl = new Uri(news2.UrlToImage).AbsoluteUri;
            ImageButton2.Visible = true;


            News news3 = list_2.ElementAt(2);
            lbl_Titre_3.Text = news3.Title;
            lbl_Author_3.Text = news3.Author;
            lbl_PublishedAte_3.Text = news3.PublishedAt.ToString();
            ImageButton3.ImageUrl = new Uri(news3.UrlToImage).AbsoluteUri;
            ImageButton3.Visible = true;



            News news4 = list_2.ElementAt(1);
            lbl_Titre_4.Text = news4.Title;
            lbl_Author_4.Text = news4.Author;
            lbl_PublishdAte_4.Text = news4.PublishedAt.ToString();
            ImageButton4.ImageUrl = new Uri(news4.UrlToImage).AbsoluteUri;
            ImageButton4.Visible = true;



            News news5 = list_2.ElementAt(1);
            lbl_Titre_5.Text = news5.Title;
            lbl_Author_5.Text = news5.Author;
            lbl_PublishdAte_5.Text = news5.PublishedAt.ToString();
            ImageButton5.ImageUrl = new Uri(news5.UrlToImage).AbsoluteUri;
            ImageButton5.Visible = true;


            News news6 = list_2.ElementAt(1);
            lbl_Titre_7.Text = news6.Title;
            lbl_Author_6.Text = news6.Author;
            lbl_PublishdAte_6.Text = news6.PublishedAt.ToString();
            ImageButton6.ImageUrl = new Uri(news6.UrlToImage).AbsoluteUri;
            ImageButton6.Visible = true;
        }


        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            NewsDetails.listNews.Clear();
            News newsinfo = new News();
            ImageButton btnNew = (ImageButton)sender;

            int indexElement = list.FindIndex(news => news.UrlToImage.Contains(btnNew.ImageUrl));

            if (indexElement != -1)
            {
                newsinfo.UrlToImage = list[indexElement].UrlToImage;
                newsinfo.Title = list[indexElement].Title;
                newsinfo.Author = list[indexElement].Author;
                newsinfo.PublishedAt = list[indexElement].PublishedAt;
                newsinfo.Content = list[indexElement].Content;

            }
            NewsDetails.listNews.Add(newsinfo);
            Response.Redirect("NewsDetails.aspx");

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            NewsDetails.listNews.Clear();
            News newsinfo = new News();


            int indexElement = list.FindIndex(news => news.Title.Contains(lbl_Titre.Text));

            if (indexElement != -1)
            {
                newsinfo.UrlToImage = list[indexElement].UrlToImage;
                newsinfo.Title = list[indexElement].Title;
                newsinfo.Author = list[indexElement].Author;
                newsinfo.PublishedAt = list[indexElement].PublishedAt;
                newsinfo.Content = list[indexElement].Content;

            }
            NewsDetails.listNews.Add(newsinfo);
            Response.Redirect("NewsDetails.aspx");

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            NewsDetails.listNews.Clear();
            News newsinfo = new News();

            int indexElement = list.FindIndex(news => news.Title.Contains(lbl_Titre_2.Text));

            if (indexElement != -1)
            {
                newsinfo.UrlToImage = list[indexElement].UrlToImage;
                newsinfo.Title = list[indexElement].Title;
                newsinfo.Author = list[indexElement].Author;
                newsinfo.PublishedAt = list[indexElement].PublishedAt;
                newsinfo.Content = list[indexElement].Content;

            }
            NewsDetails.listNews.Add(newsinfo);
            Response.Redirect("NewsDetails.aspx");

        }

        protected void ImageButton4_Click1(object sender, ImageClickEventArgs e)
        {
            NewsDetails.listNews.Clear();
            News newsinfo = new News();

            int indexElement = list.FindIndex(news => news.Title.Contains(lbl_Titre_2.Text));

            if (indexElement != -1)
            {
                newsinfo.UrlToImage = list[indexElement].UrlToImage;
                newsinfo.Title = list[indexElement].Title;
                newsinfo.Author = list[indexElement].Author;
                newsinfo.PublishedAt = list[indexElement].PublishedAt;
                newsinfo.Content = list[indexElement].Content;

            }
            NewsDetails.listNews.Add(newsinfo);
            Response.Redirect("NewsDetails.aspx");

        }



        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            NewsDetails.listNews.Clear();
            News newsinfo = new News();

            int indexElement = list.FindIndex(news => news.Title.Contains(lbl_Titre_2.Text));

            if (indexElement != -1)
            {
                newsinfo.UrlToImage = list[indexElement].UrlToImage;
                newsinfo.Title = list[indexElement].Title;
                newsinfo.Author = list[indexElement].Author;
                newsinfo.PublishedAt = list[indexElement].PublishedAt;
                newsinfo.Content = list[indexElement].Content;

            }
            NewsDetails.listNews.Add(newsinfo);
            Response.Redirect("NewsDetails.aspx");

        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            NewsDetails.listNews.Clear();
            News newsinfo = new News();

            int indexElement = list.FindIndex(news => news.Title.Contains(lbl_Titre_2.Text));

            if (indexElement != -1)
            {
                newsinfo.UrlToImage = list[indexElement].UrlToImage;
                newsinfo.Title = list[indexElement].Title;
                newsinfo.Author = list[indexElement].Author;
                newsinfo.PublishedAt = list[indexElement].PublishedAt;
                newsinfo.Content = list[indexElement].Content;

            }
            NewsDetails.listNews.Add(newsinfo);
            Response.Redirect("NewsDetails.aspx");

        }



        protected void Btn_Avant_Click(object sender, EventArgs e)
        {
            indice -= 6;
            DataLoad();
        }

        protected void Btn_Suivant_Click(object sender, EventArgs e)
        {
            indice += 6;
            DataLoad();
        }

        protected void Btn_Premier_Click(object sender, EventArgs e)
        {
            indice = 0;
            DataLoad();
        }

        protected void Btn_Dernier_Click(object sender, EventArgs e)
        {
            indice = list.Count - 6;
            DataLoad();
        }
    }
}