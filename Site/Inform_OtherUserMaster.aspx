<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_OtherUser.master" UnobtrusiveValidationMode="none" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Inform_OtherUserMaster.aspx.cs" Inherits="Inform_OtherUserMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel2" runat="server">
        <table class="auto-style1" align="center">
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Inform"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">Problem when first literal msg comes, then Validation summary to come, then both shows. And vice versa problem.</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label23" runat="server" Font-Italic="True" Text="All the fields marked as '*' sign are compulsory to fill."></asp:Label>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="color: #00CC00" class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" Style="color: #FF3300" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Literal ID="ltrMessageGreen" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="color: #FF3300">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Username"></asp:Label>
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label27" runat="server" Text="Subject"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="dropdownlistUsername" runat="server" CausesValidation="True">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="lblFirstNameAsterik" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="dropdownlistUsername" ErrorMessage="Username required!" Style="color: #FF3300">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="txtboxSubject" runat="server" placeholder="Subject" TextMode="MultiLine" Width="168px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label28" runat="server" Text="Message"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="txtboxMessage" runat="server" placeholder="Message" TextMode="MultiLine" Width="168px"></asp:TextBox>
                    <asp:Label ID="lblDistrictAsterik0" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="txtboxMessage" ErrorMessage="Message required!" Style="color: #FF3300">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click" Text="Send" Width="70px" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </asp:Panel>
    <p>
        <br />
    </p>
</asp:Content>


