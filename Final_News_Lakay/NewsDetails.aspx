<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsDetails.aspx.cs" Inherits="Final_News_Lakay.NewsDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form2" runat="server">
    <div>
        <h1>Nouvèl Lakay</h1>
        <h1>
            <asp:Label ID="lblTitre" runat="server" Text="Titre: " Font-Bold="True" Font-Size="Smaller"></asp:Label>
            </h1>
    </div>

        <style>
            .custom-button {
                background-color: #565180;
                color: white;
                padding: 5px 25px;
                text-align: center;
                text-decoration: none;
                display: inline-block;
                font-size: 20px;
                border-radius: 52px;
                border: none;
                cursor: pointer;
                position: absolute;
                bottom: 20px;
                left: 50px;
            }
            .news-image {
                width: 300px;
            }
            .news-description {
                font-size: 18px;
            }
        </style>

        <div>
            <asp:Image ID="Image1" runat="server" Height="279px" Width="342px" />
        </div>

        <asp:Button ID="Btn_Avant" runat="server" CssClass="custom-button" Text="Avant" OnClick="Btn_Avant_Click1" />

    <footer>
    </footer>
        <asp:Label ID="Label1" runat="server" Text="Auteur"></asp:Label>
        :
        <br />
        <asp:Label ID="lblDate" runat="server" Text="Date: "></asp:Label>
        <br />
        <asp:Label ID="lblContent" runat="server" Text="Content News: "></asp:Label>
    </form>
</body>
</html>
