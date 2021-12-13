<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Crud_V2.UI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <link href="../Content/style.css" rel="stylesheet"/>

    <div class="loginbox">
        <img src="../Photos/1234.jpg" alt="Alternate Text" class="user"/>
        <h2>Login Here</h2>
      
            <asp:Label Text="Username" CssClass="lblusername" runat="server" />
            <asp:TextBox ID="txtbox_username" runat="server" CssClass="txtusername" placeholder="Enter Username"/>
            <asp:Label Text="Password" CssClass="lblpass" runat="server" ForeColor="White" />
            <asp:TextBox ID="txtbox_password" runat="server" CssClass="txtpass" placeholder=" ******** " TextMode="Password" />
            <asp:Label ID="lbl_checkvalidation" runat="server" Text="Invalid Username And Password" ForeColor="Yellow" Visible="false"/>
           
            <asp:Button Text="Sign In" CssClass="btnsubmit" OnClick="login_Click" runat="server"/>       
    </div>

</asp:Content>
