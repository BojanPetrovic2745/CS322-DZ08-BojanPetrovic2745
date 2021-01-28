<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieForm.aspx.cs" Inherits="CS322_DZ08_BojanPetrovic2745.MovieForm" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>Add a Movie</title>
</head>
<body>
<h1>Add a Movie</h1>
<form method="post" class="form"  runat="server">
        <asp:Label for="title" runat="server">Title:</asp:Label>
            <asp:TextBox ID="title" runat="server"></asp:TextBox>
       

        <asp:Label for="genre">Genre:</asp:Label>
            <asp:TextBox ID="genre" runat="server"></asp:TextBox>
       

      <asp:Label for="year">Year:</asp:Label>
            <asp:TextBox ID="year" runat="server"></asp:TextBox>
     

        <asp:Button ID="insert" OnClick="Insert_Click"   runat="server" Text="Insert" />
    
    <hr/>
    <asp:ListBox ID="ListBox1" OnLoad="Label_Changed" runat="server"></asp:ListBox>
     
</form>
    


</body>
</html>

