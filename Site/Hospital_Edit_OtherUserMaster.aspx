<%@ Page Title="" Language="C#" UnobtrusiveValidationMode="none" MaintainScrollPositionOnPostBack="true" MasterPageFile="~/MasterPage_OtherUser.master" AutoEventWireup="true" CodeFile="Hospital_Edit_OtherUserMaster.aspx.cs" Inherits="Hospital_Edit_OtherUserMaster" %>

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
                    <asp:HyperLink ID="HyperLink10" runat="server" CssClass="link" NavigateUrl="~/Hospital_Add_OtherUserMaster.aspx">ADD</asp:HyperLink>
                    &nbsp;<asp:HyperLink ID="HyperLink13" runat="server" CssClass="link" NavigateUrl="~/Hospital_OtherUserMaster.aspx">VIEW</asp:HyperLink>
                    &nbsp;<asp:HyperLink ID="HyperLink12" runat="server" CssClass="link" NavigateUrl="~/Hospital_Del_OtherUserMaster.aspx">DEL</asp:HyperLink>
                </td>
                <td style="text-align: left">
                    &nbsp;</td>
                <td colspan="2" style="text-align: left">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">&nbsp;</td>
                <td style="text-align: left">
                    <asp:HyperLink ID="HyperLink9" runat="server" CssClass="headerlink" Font-Bold="True" Font-Size="Large" NavigateUrl="~/Hospital_Edit_OtherUserMaster.aspx">Edit Hospital Record</asp:HyperLink>
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
                <td>
                    <asp:Label ID="lblName" runat="server">Name</asp:Label>
                    <asp:Label ID="lblNameLabel" runat="server" Visible="False">Name</asp:Label>
                </td>
                <td colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_Name" runat="server" CausesValidation="False" CssClass="link" OnClick="lnkbtnEdit_Name_Click">Edit Name</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtboxName" placeholder="Name" runat="server" Visible="False" MaxLength="49"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:Button ID="btnOk_Name" runat="server" OnClick="btnOk_Name_Click" Text="Ok" ValidationGroup="Name" Visible="False" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ReqFieldVald_Name" runat="server" ControlToValidate="txtboxName" ErrorMessage="Name required!" style="color: #FF3300" ValidationGroup="Name">Name required!</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="txtboxName" Display="Dynamic" ErrorMessage="Name provided is not in the correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z ]*|[a-zA-Z ]*|[a-z ]*|[A-Z ]*$/">Not in correct format!</asp:RegularExpressionValidator>
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
                    <asp:Label ID="lblType" runat="server">Type</asp:Label>
                    <asp:Label ID="lblTypeLabel" runat="server" Visible="False">Type</asp:Label>
                </td>
                <td class="separator" colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_Type" runat="server" CausesValidation="False" OnClick="lnkbtnEdit_Type_Click" CssClass="link">Edit Type</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px">
                    <asp:DropDownList ID="dropdownlistType" runat="server" Visible="False">
                        <asp:ListItem>Public Hospital</asp:ListItem>
                        <asp:ListItem>Primary Health Care Centre</asp:ListItem>
                        <asp:ListItem>Health Post</asp:ListItem>
                        <asp:ListItem>Sub Health Post</asp:ListItem>
                        <asp:ListItem>Clinic</asp:ListItem>
                        <asp:ListItem>Female Community Health  Service</asp:ListItem>
                        <asp:ListItem>Extended Program of Immunization</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;</td>
                <td colspan="2">
                    <asp:Button ID="btnOk_Type" runat="server" Text="Ok" Visible="False" OnClick="btnOk_Type_Click" ValidationGroup="Type" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ReqFieldVald_Type" runat="server" ControlToValidate="dropdownlistType" ErrorMessage="Type required!" style="color: #FF3300" ValidationGroup="Type">Type required!</asp:RequiredFieldValidator>
                </td>
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
            <tr>
                <td style="margin-left: 160px" class="separator">
                    <asp:Label ID="lblAddress" runat="server" Visible="False">Address</asp:Label>
                </td>
                <td class="separator" colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_Address" runat="server" CausesValidation="False" OnClick="lnkbtnEdit_Address_Click" CssClass="link">Edit Address</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px">
                    <asp:Label ID="lblHouseAdd" runat="server">HouseAdd</asp:Label>
                    <asp:TextBox ID="txtboxHouseAdd" runat="server" placeholder="House Address" Visible="False" MaxLength="39"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:Label ID="lblDistrict" runat="server">District</asp:Label>
                    <asp:TextBox ID="txtboxDistrict" runat="server" placeholder="District" Visible="False" MaxLength="19"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ReqFieldVald_District" runat="server" ControlToValidate="txtboxDistrict" ErrorMessage="District required!" style="color: #FF3300" ValidationGroup="Address">District required!</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="txtboxDistrict" Display="Dynamic" ErrorMessage="District provided is not in the correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z]*[ ]*|[a-zA-Z]*[ ]*|[a-z]*[ ]*|[A-Z]*[ ]*$/">Not in correct format!</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 160px">
                    <asp:Label ID="lblCity" runat="server">City</asp:Label>
                    <asp:TextBox ID="txtboxCity" runat="server" placeholder="City" Visible="False" MaxLength="19"></asp:TextBox>
                </td>
                <td colspan="2">
                    &nbsp;</td>
                <td>
                    <asp:RequiredFieldValidator ID="ReqFieldVald_City" runat="server" ControlToValidate="txtboxCity" ErrorMessage="City required!" style="color: #FF3300" ValidationGroup="Address">City required!</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ControlToValidate="txtboxCity" Display="Dynamic" ErrorMessage="City is not in correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z]*[ ]*|[a-zA-Z]*[ ]*|[a-z]*[ ]*|[A-Z]*[ ]*$/">Not in correct format!</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 160px">&nbsp;</td>
                <td colspan="2">
                    <asp:Button ID="btnOk_Address" runat="server" Text="Ok" ValidationGroup="Address" Visible="False" OnClick="btnOk_Address_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px" class="separator">
                    <asp:Label ID="lblDescription" runat="server">Description</asp:Label>
                    <asp:Label ID="lblDescriptionLabel" runat="server" Visible="False">Description</asp:Label>
                </td>
                <td class="separator" colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_Description" runat="server" CausesValidation="False" OnClick="lnkbtnEdit_Description_Click" CssClass="link">Edit Description</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px">
                    <asp:TextBox ID="txtboxDescription" runat="server" placeholder="Description" Visible="False" TextMode="MultiLine" MaxLength="299"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:Button ID="btnOk_Description" runat="server" Text="Ok" Visible="False" OnClick="btnOk_Description_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>


