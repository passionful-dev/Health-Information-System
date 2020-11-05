<%@ Page Title="" Language="C#" UnobtrusiveValidationMode="none" MaintainScrollPositionOnPostBack="true" MasterPageFile="~/MasterPage_OtherUser.master" AutoEventWireup="true" CodeFile="EntryUserForm_Edit_OtherUserMaster.aspx.cs" Inherits="EntryUserForm_Edit_OtherUserMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            /*width: 100%;*/
        }
        </style>
    <link href="StyleSheet_CommonOnAll.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel2" runat="server">
        <table class="auto-style1" align="center">
            <tr>
                <td style="text-align: left">
                    <asp:HyperLink ID="HyperLink10" runat="server" CssClass="link" NavigateUrl="~/EntryUserForm_Add_OtherUserMaster.aspx">ADD</asp:HyperLink>
                    &nbsp;<asp:HyperLink ID="HyperLink13" runat="server" CssClass="link" NavigateUrl="~/EntryUserForm_OtherUserMaster.aspx">VIEW</asp:HyperLink>
                    &nbsp;</td>
                <td style="text-align: left">
                    &nbsp;</td>
                <td colspan="2" style="text-align: left">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">&nbsp;</td>
                <td style="text-align: left">
                    <asp:HyperLink ID="hprlnk_header" runat="server" CssClass="headerlink" Font-Bold="True" Font-Size="Large" NavigateUrl="~/EntryUserForm_Edit_OtherUserMaster.aspx">Edit Entry User Record</asp:HyperLink>
                </td>
                <td colspan="2" style="text-align: left">&nbsp;</td>
            </tr>
            <tr>
                <td style="color: #FF0000" colspan="4">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="Name; Email" />
                </td>
            </tr>
            <tr>
                <td colspan="4" style="color: #FF0000">
                    <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td colspan="4" style="color: #FF0000">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHospital" runat="server">Hospital</asp:Label>
                    <asp:Label ID="lblHospitalLabel" runat="server" Visible="False">Hospital</asp:Label>
                </td>
                <td colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_Hospital" runat="server" CausesValidation="False" CssClass="link" OnClick="lnkbtnEdit_CurrentHospital_Click">Edit Hospital</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="dropdownlist_Hospital" runat="server" Visible="False">
                    </asp:DropDownList>
                </td>
                <td colspan="2">
                    <asp:Button ID="btnOk_Hospital" runat="server" OnClick="btnOk_CurrentHospital_Click" Text="Ok" ValidationGroup="Hospital" Visible="False" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ReqFieldVald_Name" runat="server" ControlToValidate="dropdownlist_Hospital" ErrorMessage="Hospital required!" style="color: #FF3300" ValidationGroup="Hospital">Hospital required!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 120px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px" class="separator">
                    <asp:Label ID="lblStatus" runat="server">Status</asp:Label>
                    <asp:Label ID="lblStatusLabel" runat="server" Visible="False">Status</asp:Label>
                </td>
                <td class="separator" colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_Status" runat="server" CausesValidation="False" OnClick="lnkbtnEdit_Status_Click" CssClass="link">Edit Status</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px">
                    <asp:DropDownList ID="dropdownlistStatus" runat="server" Visible="False">
                        <asp:ListItem>Inactive</asp:ListItem>
                        <asp:ListItem>Active</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;</td>
                <td colspan="2">
                    <asp:Button ID="btnOk_Status" runat="server" Text="Ok" Visible="False" OnClick="btnOk_Status_Click" ValidationGroup="Type" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>



