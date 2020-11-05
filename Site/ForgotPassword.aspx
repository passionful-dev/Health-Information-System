<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Login.master" UnobtrusiveValidationMode="none" AutoEventWireup="true" CodeFile="ForgotPassword.aspx.cs" Inherits="ForgotPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel2" runat="server" style="text-align: center">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table class="auto-style1" align="center">
            <tr>
                <td class="auto-style2"><strong style="text-align: center">Forgot Password</strong></td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: left">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" style="text-align: left" Text="Your Email address that you registered in this website"></asp:Label>
                    &nbsp;<asp:TextBox ID="txtboxEmail_ForgotPassword" runat="server" Width="200px"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtboxEmail_ForgotPassword" ErrorMessage="Email address required!" style="color: #FF3300">*</asp:RequiredFieldValidator>
                    <asp:Button ID="btnForgotPassword_Enter" runat="server" OnClick="btnForgotPassword_Enter_Click" Text="Enter" />
                </td>
            </tr>
            <tr>
                <td style="text-align: left; color: #FF3300;">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: left; color: #33CC33;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Literal ID="ltrMessageGreen" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td style="text-align: left; color: #FF3300;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Literal ID="ltrMessageRed" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td style="text-align: left; color: #FF3300;">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    &nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

