<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="EvidencijaUcenika._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 142px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        &nbsp;</h2>
    <table style="width:100%;">
        <tr>
            <td class="style1">
                Ime:</td>
            <td>
                <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                Prezime:</td>
            <td>
                <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                Razred:</td>
            <td>
                <asp:DropDownList ID="ddlRazred" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <asp:Button ID="btnPretraga" runat="server" Text="Pretraga" 
        onclick="btnPretraga_Click" />


    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Ime" HeaderText="Ime" />
            <asp:BoundField DataField="Prezime" HeaderText="Prezime" />
            <asp:BoundField DataField="Razred" HeaderText="Razred" />
        </Columns>
</asp:GridView>
    <br />
    <br />
</asp:Content>

