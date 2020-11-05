<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Guest.master" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="Panel1" runat="server">
        <br />
        <fieldset style="width: 300px">
            <legend>Login Form</legend>
            <table align="center" class="auto-style1" style="width: 56%">
                <tr>
                    <td colspan="2" style="text-align: center">User Login</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="User ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUid" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUid" ErrorMessage="User ID required!">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd" ErrorMessage="Password required!">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:Button ID="btnLogin" runat="server" Text="Login " OnClick="btnLogin_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center; color: #FF0000;">
                        <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
                    </td>
                </tr>
            </table>
        </fieldset>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <br />
        <br />
    </asp:Panel>
</asp:Content>


