<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SplashScreen.aspx.cs" Inherits="Final_News_Lakay.SplashScreen" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
	<script type="text/javascript">
        window.onload = function () {
            setTimeout(function () {
                window.location.replace("MainNews.aspx");
            }, 5000);
        }
    </script>
	
<head runat="server">
	<title>Nouvèl Lakay</title>
	<link href="CSS/StyleSheet.css" rel="stylesheet" />
	<style>
		body {
			background-image: url("CSS//imageBack.jpg");
			background-size: cover;
		}
	</style>
</head>

<body>
    <form id="form" runat="server">
        <div>
			<p>N</p>
			<p>o</p>
			<p>u</p>
			<p>v</p>
			<p>è</p>
			<p>l</p>
			<p>&nbsp; L</p>
			<p>a</p>
			<p>k</p>
			<p>a</p>
			<p>y</p>
		</div>
    </form>
</body>

</html>


