using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_News_Lakay
{
    public partial class NewsDetails : System.Web.UI.Page
    {
         public static List<News> listNews = new List<News>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (listNews.Count >= 1)
            {
                Image1.ImageUrl = listNews[0].UrlToImage;
                lblTitre.Text = listNews[0].PublishedAt.ToString();
                lblTitre.Text = listNews[0].Author.ToString();
                lblDate.Text = listNews[0].Title.ToString();
                lblContent.Text = listNews[0].Content.ToString();

            }
            else
            {
                return;
            }

        }

        protected void Btn_Avant_Click1(object sender, EventArgs e)
        {
            Response.Redirect("All_News.aspx");
        }
    }
}