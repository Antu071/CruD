<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PR_UserInformation.aspx.cs" Inherits="Crud_V2.UI.PR_UserInformation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <fieldset>
        <legend>User Information</legend>

        <table class="table table-border">
            <tr>
                <td>
                    <asp:DropDownList ID="dropdowncompanyname" runat="server" Height="35px" Width="150px" BackColor="WhiteSmoke"></asp:DropDownList>
                </td>

                <td>
                    <asp:Label ID="lblusername" runat="server" Text="Username:"></asp:Label>
                </td>

                <td>
                    <asp:TextBox ID="txtusername" runat="server" CssClass="form-control" Height="35px" Width="150px"></asp:TextBox>
                </td>

                <td>
                    <asp:Label ID="lblpassword" runat="server" Text="Password:"></asp:Label>
                </td>

                <td>
                    <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" CssClass="form-control" Height="35px" Width="150px"></asp:TextBox>
                </td>

                <td>
                    <asp:Label ID="lblname" runat="server" Text="Name:"></asp:Label>
                </td>

                <td>
                    <asp:TextBox ID="txtname" runat="server" CssClass="form-control" Height="35px" Width="150px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblmail" runat="server" Text="Mail:"></asp:Label>
                </td>

                <td>
                    <asp:TextBox ID="txtmail" runat="server" CssClass="form-control" Height="35px" Width="150px"></asp:TextBox>
                </td>

            </tr>

            <tr>
                <td>
                    <asp:DropDownList ID="dropdowndeptname" runat="server" Height="35px" Width="150px" BackColor="WhiteSmoke"></asp:DropDownList>
                </td>

                <td>
                    <asp:DropDownList ID="dropdownrole" runat="server" Height="35px" Width="150px" BackColor="WhiteSmoke"></asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="dropdownisactive" runat="server" Height="35px" Width="150px" BackColor="WhiteSmoke"></asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="lblshortcode" runat="server" Text="Short Code:"></asp:Label>
                </td>

                <td>
                    <asp:TextBox ID="txtshortcode" runat="server" CssClass="form-control" Height="35px" Width="150px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblprofileid" runat="server" Text="Profile ID:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtprofileid" runat="server" CssClass="form-control" Height="35px" Width="150px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:DropDownList ID="dropdownusergroup" runat="server" Height="35px" Width="150px" BackColor="WhiteSmoke"></asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="dropdowncompanyaccess" runat="server" Height="35px" Width="150px" BackColor="WhiteSmoke"></asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="dropdownuserlocation" runat="server" Height="35px" Width="150px" BackColor="WhiteSmoke"></asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="lblbusinesstype" runat="server" Text="Business Type:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtbusinesstype" runat="server" CssClass="form-control" Height="35px" Width="150px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblfoldername" runat="server" Text="Folder Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtfoldername" runat="server" CssClass="form-control" Height="35px" Width="150px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblprofileimagename" runat="server" Text="Profile Image Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtprofileimagename" runat="server" CssClass="form-control" Height="35px" Width="150px"></asp:TextBox>
                </td>
                <td>
                    <asp:DropDownList ID="dropdownaccessthrough" runat="server" Height="35px" Width="150px" BackColor="WhiteSmoke"></asp:DropDownList>
                </td>

            </tr>

        </table>

    </fieldset>

    <fieldset>
        <table>

            <tr>
                <td>
                    <asp:Button ID="btnInsert" runat="server" Text="Insert" CssClass="btn btn-success" OnClick="btnInsert_Click" />
                </td>

            </tr>

        </table>
    </fieldset>

</asp:Content>
