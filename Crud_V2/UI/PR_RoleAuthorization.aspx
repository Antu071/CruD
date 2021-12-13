<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PR_RoleAuthorization.aspx.cs" Inherits="Crud_V2.UI.PR_RoleAuthorization" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <fieldset>

        <legend>Role Authorization
        </legend>

        <table class="table table-border">

            <tr>
                <td>
                    <asp:DropDownList ID="dropdownrolename" runat="server" Height="35px" Width="150px" BackColor="WhiteSmoke">
                    </asp:DropDownList>
                </td>

                <td>
                    <asp:DropDownList ID="dropdowncompanyname" runat="server" Height="35px" Width="150px" BackColor="WhiteSmoke">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="lblpageurl" runat="server" Text="Page Url :">
                    </asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtpageurl" runat="server" CssClass="form-control"></asp:TextBox>
                </td>

                <td>
                    <asp:Label ID="lblmenuname" runat="server" Text="Menu Name :"></asp:Label>

                </td>

                <td>
                    <asp:TextBox ID="txtmenuname" runat="server" CssClass="form-control">

                    </asp:TextBox>
                </td>

                <td>
                    <asp:Button ID="btnInsert" runat="server" Text="Insert" CssClass="btn btn-success" OnClick="btnInsert_Click" />
                </td>
            </tr>

        </table>

    </fieldset>

</asp:Content>
