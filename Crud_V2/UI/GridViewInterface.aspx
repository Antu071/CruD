<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GridViewInterface.aspx.cs" Inherits="Crud_V2.UI.GridViewInterface" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:RadioButton ID="testradiobtn" runat="server" AutoPostBack="true" OnCheckedChanged="testradiobtn_CheckedChanged" />
        <asp:GridView ID="gvVoucherType" runat="server" CssClass="table" AutoGenerateColumns="false">

            <Columns>

                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="slckCheckBox" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label ID="lblid" Text='<%# Eval("ID") %>' runat="server">
                        </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="VoucherName">
                    <ItemTemplate>
                        <asp:Label ID="lblVoucherName" Text='<%# Eval("VoucherName") %>' runat="server">
                        </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="NameBehind">
                    <ItemTemplate>
                        <asp:Label ID="lblNameBehind" Text='<%# Eval("NameBehind") %>' runat="server">
                        </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="CompanyName">
                    <ItemTemplate>
                        <asp:Label ID="lblCompanyName" Text='<%# Eval("CompanyName") %>' runat="server">
                        </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

        </asp:GridView>




    <asp:Button ID="btnInsertGrid" runat="server" Text="Insert Grid" CssClass="btn btn-primary" OnClick="btnInsertGrid_Click" />



</asp:Content>
