<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Guest.master" AutoEventWireup="true" CodeFile="Home_Guest.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 700px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="Panel1" runat="server">
        <table class="auto-style1" align="center">
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Home"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">Welcome to Health Information System, a health portal of Nepal.</td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

