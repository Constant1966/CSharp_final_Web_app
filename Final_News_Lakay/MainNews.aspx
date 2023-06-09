<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainNews.aspx.cs" Inherits="Final_News_Lakay.MainNews" %>


<!DOCTYPE html>
<html lang="fr">
<head>
    <title>Nouvèl Lakay</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style>
        .navbar {
            margin-bottom: 50px;
            border-radius: 0;
        }

        .jumbotron {
            margin-bottom: 0;
        }

        footer {
            background-color: #f2f2f2;
            padding: 25px;
        }
    </style>
</head>
<body>

    <script>
        function checkConnectivity() {
            return navigator.onLine;
        }
        function ConnexionChange() {
            var icon = document.getElementById("status-icon");
            if (checkConnectivity()) {
                icon.style.color = "green";
            } else {
                icon.style.color = "red";
            }
        }
        ConnexionChange();

        window.addEventListener("online", ConnexionChange);
        window.addEventListener("offline", ConnexionChange);

    </script>

    <form id="form1" runat="server">
        <div class="jumbotron">
            <div class="container text-center">
                <h1>Nouvèl Lakay</h1>      
            </div>
        </div>

        <div class="container">    
            <div class="row">
                <div class="col-sm-4">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <asp:Label ID="lbl_Titre" runat="server" Text="Titre: "></asp:Label>
                        </div>
                        <div class="panel-body"><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="https://placehold.it/150x80?text=IMAGE" CssClass="img-responsive" Style="width:100%" AlternateText="Image" OnClick="ImageButton1_Click"></asp:ImageButton>
                            <asp:Label ID="lbl_Author_1" runat="server" Text="Auteur: "></asp:Label>
                            <br />
                            <asp:Label ID="lbl_PublishdAte_1" runat="server" Text="Date: "></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="col-sm-4"> 
                    <div class="panel panel-danger">
                        <div class="panel-heading">
                            <asp:Label ID="lbl_Titre_2" runat="server" Text="Titre: "></asp:Label>
                        </div>
                        <div class="panel-body"><asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="https://placehold.it/150x80?text=IMAGE" CssClass="img-responsive" Style="width:100%" AlternateText="Image" OnClick="ImageButton2_Click"></asp:ImageButton>
                            <asp:Label ID="lbl_Author_2" runat="server" Text="Auteur: "></asp:Label>
                            <br />
                            <asp:Label ID="lbl_PublishdAte_2" runat="server" Text="Date"></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="col-sm-4"> 
                    <div class="panel panel-success">
                        <div class="panel-heading">
                            <asp:Label ID="lbl_Titre_3" runat="server" Text="Titre: "></asp:Label>
                        </div>
                        <div class="panel-body"><asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="https://placehold.it/150x80?text=IMAGE" CssClass="img-responsive" Style="width:100%" AlternateText="Image" OnClick="ImageButton3_Click"></asp:ImageButton>
                            <asp:Label ID="lbl_Author_3" runat="server" Text="Auteur: "></asp:Label>
                            <br />
                            <asp:Label ID="lbl_PublishedAte_3" runat="server" Text="Date: "></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div><br>

        <div class="container">    
            <div class="row">
                <div class="col-sm-4">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <asp:Label ID="lbl_Titre_4" runat="server" Text="Titre: "></asp:Label>
                        </div>
                        <div class="panel-body"><asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="https://placehold.it/150x80?text=IMAGE" CssClass="img-responsive" Style="width:100%" AlternateText="Image" OnClick="ImageButton4_Click1"></asp:ImageButton>
                            <asp:Label ID="lbl_Author_4" runat="server" Text="Auteur"></asp:Label>
                            <br />
                            <asp:Label ID="lbl_PublishdAte_4" runat="server" Text="Date: "></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="col-sm-4"> 
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <asp:Label ID="lbl_Titre_5" runat="server" Text="Titre: "></asp:Label>
                        </div>
                        <div class="panel-body"><asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="https://placehold.it/150x80?text=IMAGE" CssClass="img-responsive" Style="width:100%" AlternateText="Image" OnClick="ImageButton5_Click"></asp:ImageButton>
                            <asp:Label ID="lbl_Author_5" runat="server" Text="Aueur: "></asp:Label>
                            <br />
                            <asp:Label ID="lbl_PublishdAte_5" runat="server" Text="Date: "></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="col-sm-4"> 
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <asp:Label ID="lbl_Titre_7" runat="server" Text="Titre: "></asp:Label>
                        </div>
                        <div class="panel-body"><asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="https://placehold.it/150x80?text=IMAGE" CssClass="img-responsive" Style="width:100%" AlternateText="Image" OnClick="ImageButton6_Click"></asp:ImageButton>
                            <asp:Label ID="lbl_Author_6" runat="server" Text="Auteur"></asp:Label>
                            :
                            <br />
                            <asp:Label ID="lbl_PublishdAte_6" runat="server" Text="Date: "></asp:Label>
                        </div>
                    </div>
                </div>
                <br />
            </div>

            
        </div>
        <br>

       <style>
            .custom-button {
                background-color: #565180;
                color: white;
                padding: 5px 25px;
                text-align: center;
                text-decoration: none;
                display: inline-block;
                font-size: 20px;
                border-radius: 32px;
                border: none;
                cursor: pointer;
            }
        </style>


                <asp:Label ID="lblTitle" runat="server" Text="Titre:"></asp:Label>


        <footer class="container-fluid text-center">
           <asp:Button ID="Btn_Premier" runat="server" CssClass="custom-button" Text="Premier" OnClick="Btn_Premier_Click" />
            <asp:Button ID="Btn_Avant" runat="server" CssClass="custom-button" Text="Avant" OnClick="Btn_Avant_Click" />
            <asp:Button ID="Btn_Suivant" runat="server" CssClass="custom-button" Text="Suivant" OnClick="Btn_Suivant_Click" />
            <asp:Button ID="Btn_Dernier" runat="server" CssClass="custom-button" Text="Dernier" OnClick="Btn_Dernier_Click" />

        </footer>
    </form>
</body>
</html>
