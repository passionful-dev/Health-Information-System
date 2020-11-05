<%@ Page Title="" Language="C#" UnobtrusiveValidationMode="none" MaintainScrollPositionOnPostback="true" MasterPageFile="~/MasterPage_OtherUser.master" AutoEventWireup="true" CodeFile="Hospital_Add_OtherUserMaster.aspx.cs" Inherits="Hospital_Add_OtherUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            /*width: 100%;*/
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="Panel2" runat="server">
        <table class="auto-style1" align="center">
            <tr>
                <td>&nbsp;<asp:HyperLink ID="HyperLink10" runat="server" CssClass="link" NavigateUrl="~/Hospital_OtherUserMaster.aspx">VIEW</asp:HyperLink>
                    &nbsp;<asp:HyperLink ID="HyperLink12" runat="server" CssClass="link" NavigateUrl="~/Hospital_Del_OtherUserMaster.aspx">DEL</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Add Hospital"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label23" runat="server" Font-Italic="True" Text="All the fields marked as '*' sign are compulsory to fill."></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="color: #00CC00">&nbsp;&nbsp;&nbsp;&nbsp;
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
                    <asp:Label ID="Label10" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label25" runat="server" Text="Type"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtboxName" runat="server" placeholder="Name" MaxLength="49"></asp:TextBox>
                    <asp:Label ID="lblFirstNameAsterik" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtboxName" ErrorMessage="Name required!" Style="color: #FF3300">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="txtboxName" Display="Dynamic" ErrorMessage="Name provided is not in the correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z ]*|[a-zA-Z ]*|[a-z ]*|[A-Z ]*$/">*</asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:DropDownList ID="dropdownlistType" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Public Hospital</asp:ListItem>
                        <asp:ListItem>Primary Health Care Centre</asp:ListItem>
                        <asp:ListItem>Health Post</asp:ListItem>
                        <asp:ListItem>Sub Health Post</asp:ListItem>
                        <asp:ListItem>Clinic</asp:ListItem>
                        <asp:ListItem>Female Community Health  Service</asp:ListItem>
                        <asp:ListItem>Extended Program of Immunization</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="lblGenderAsterik0" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="dropdownlistType" ErrorMessage="Type required!" Style="color: #FF3300">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label22" runat="server" Text="Address"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtboxHouseAdd" runat="server" placeholder="House Address" MaxLength="39"></asp:TextBox>
                    &nbsp;<asp:TextBox ID="txtboxDistrict" runat="server" placeholder="District" MaxLength="19"></asp:TextBox>
                    <asp:Label ID="lblDistrictAsterik" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtboxDistrict" ErrorMessage="District required!" Style="color: #FF3300">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="txtboxDistrict" Display="Dynamic" ErrorMessage="District provided is not in the correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z]*[ ]*|[a-zA-Z]*[ ]*|[a-z]*[ ]*|[A-Z]*[ ]*$/">*</asp:RegularExpressionValidator>
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtboxCity" runat="server" placeholder="City" MaxLength="19"></asp:TextBox>
                    <asp:Label ID="lblCityAsterik" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtboxCity" ErrorMessage="City required!" Style="color: #FF3300">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="txtboxCity" Display="Dynamic" ErrorMessage="City provided is not in the correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z]*[ ]*|[a-zA-Z]*[ ]*|[a-z]*[ ]*|[A-Z]*[ ]*$/">*</asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label26" runat="server" Text="Description"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtboxDescrip" runat="server" placeholder="Description" TextMode="MultiLine" Width="168px" MaxLength="299"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" Width="70px" OnClick="btnAdd_Click" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </asp:Panel>
    <p>
        <br />
    </p>
</asp:Content>

