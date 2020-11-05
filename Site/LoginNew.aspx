<%@ Page Title="" Language="C#" UnobtrusiveValidationMode="none" MaintainScrollPositionOnPostBack="true" MasterPageFile="~/MasterPage_Login.master" AutoEventWireup="true" CodeFile="LoginNew.aspx.cs" Inherits="LoginNew" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 500px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:Panel ID="Panel2" runat="server">
        <table class="auto-style1" align="center">
            <caption>
                <p>
                </p>
                <tr>
                    <td colspan="4" style="text-align: center">
                        <asp:Label ID="Label2" runat="server" Style="font-weight: 700; font-size: large" Text="Log in"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="text-align: center">&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp; &nbsp;&nbsp; <asp:Label ID="Label3" runat="server" Text="Username"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="txtboxUsername" runat="server" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtboxUsername" ErrorMessage="Username required!" style="color: #FF3300">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp; &nbsp;&nbsp; <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="txtboxPasswd" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtboxPasswd" ErrorMessage="Password required!" style="color: #FF3300">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp; &nbsp;&nbsp;</td>
                    <td colspan="3" style="text-align: left">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnLogIn" runat="server" Text="Log in" Width="70px" OnClick="btnLogIn_Click1" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4" style="text-align: left">&nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:HyperLink ID="HyperLink10" runat="server" CssClass="link" NavigateUrl="~/Register.aspx">Create a new account</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="text-align: left">&nbsp;&nbsp; &nbsp;&nbsp;
                        </td>
                </tr>
            </caption>

            <tr>
                <td colspan="4" style="text-align: left; color: #FF3300;">&nbsp;
                    <asp:ValidationSummary ID="ValidationSummary2" runat="server" />
                    </td>
            </tr>

            <tr>
                <td colspan="4" style="text-align: left; color: #FF3300;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
                </td>
            </tr>

        </table>
    </asp:Panel>

</asp:Content>

