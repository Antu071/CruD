<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GridWithRadioButton.aspx.cs" Inherits="Crud_V2.UI.GridWithRadioButton" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <fieldset>
        <legend>Voucher Information</legend>
    </fieldset>

    <asp:RadioButton ID="rbtnBoth" runat="server" AutoPostBack="true" Text="Enable Both" Checked="true" GroupName="number" OnCheckedChanged="rbtnBoth_CheckedChanged" />
    <asp:RadioButton ID="rbtnOdd" runat="server" AutoPostBack="true" Text="Enable Odd Numbers" GroupName="number" OnCheckedChanged="rbtnOdd_CheckedChanged" />
    <asp:RadioButton ID="rbtnEven" runat="server" AutoPostBack="true" Text="Enable Even Numbers" GroupName="number" OnCheckedChanged="rbtnEven_CheckedChanged" />

    <div style="height: 500px; width: 1200px; overflow: auto;">
        <asp:GridView ID="Gv_Radio" runat="server" AutoGenerateColumns="false" CssClass="table">
            <AlternatingRowStyle />
            <Columns>

                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="selectChkBox" runat="server" AutoPostBack="true" />
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

                <asp:TemplateField HeaderText="Odd_Or_Even">
                    <ItemTemplate>
                        <asp:Label ID="lblOdd_Or_Even" Text='<%# Eval("Odd_Or_Even") %>' runat="server">
                        </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

        </asp:GridView>
    </div>
    <fieldset>

        <asp:Button ID="btnInsertGrid" runat="server" Text="Insert Grid" CssClass="btn btn-success" OnClick="btnInsertGrid_Click" />
        <asp:Button ID="btnOddDelete" runat="server" Text="Delete Odd Values" CssClass="btn btn-primary" OnClick="btnOddDelete_Click" />

    </fieldset>
</asp:Content>
