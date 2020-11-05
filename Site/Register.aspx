<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Login.master" MaintainScrollPositionOnPostBack="true" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" UnobtrusiveValidationMode="none" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel2" runat="server">
        <table align="center">
            <tr>
                <td colspan="3" style="text-align: center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" style="font-size: large" Text="Patient Register"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label23" runat="server" Font-Italic="True" Text="All the fields marked as '*' sign are compulsory to fill."></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" style="color: #FF3300" />
                </td>
            </tr>
            <tr>
                <td colspan="3" style="color: #FF0000">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Name"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtboxFirstName" placeholder="First Name" runat="server" MaxLength="19"></asp:TextBox>
                    <asp:Label ID="lblFirstNameAsterik" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtboxFirstName" ErrorMessage="First Name required!" style="color: #FF3300">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtboxFirstName" Display="Dynamic" ErrorMessage="First name provided is not in the correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z]*[ ]*|[a-zA-Z]*[ ]*|[a-z]*[ ]*|[A-Z]*[ ]*$/">*</asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:TextBox ID="txtboxMiddleName" placeholder="Middle Name" runat="server" MaxLength="19"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="txtboxMiddleName" Display="Dynamic" ErrorMessage="Middle name provided is not in the correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z ]*|[a-zA-Z ]*|[a-z ]*|[A-Z ]*$/">*</asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:TextBox ID="txtboxLastName" placeholder="Last Name" runat="server" MaxLength="19"></asp:TextBox>
                    <asp:Label ID="lblLastNameAsterik0" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtboxLastName" ErrorMessage="Last Name required!" style="color: #FF0000">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="txtboxLastName" Display="Dynamic" ErrorMessage="Last name provided is not in the correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z]*[ ]*|[a-zA-Z]*[ ]*|[a-z]*[ ]*|[A-Z]*[ ]*$/">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Username"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label18" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label19" runat="server" Text="Confirm Password"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtboxUsername" runat="server" MaxLength="49"></asp:TextBox>
                    <asp:Label ID="lblUsernameAsterik" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtboxUsername" ErrorMessage="Username required!" style="color: #FF3300">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="txtboxPassword" runat="server" TextMode="Password" MaxLength="19"></asp:TextBox>
                    <asp:Label ID="lblPasswordAsterik" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtboxPassword" ErrorMessage="Password required!" style="color: #FF3300">*</asp:RequiredFieldValidator>
                    &nbsp;</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtboxConfirmPassword" runat="server" TextMode="Password" MaxLength="19"></asp:TextBox>
                    <asp:Label ID="lblConfirmPasswordAsterik" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtboxConfirmPassword" ErrorMessage="Confirm Password required!" style="color: #FF3300">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label13" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label14" runat="server" Text="Secondary Email"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtboxEmail" runat="server" MaxLength="49"></asp:TextBox>
                    <asp:Label ID="lblEmailAsterik" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtboxEmail" ErrorMessage="Email required!" style="color: #FF3300">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtboxEmail" Display="Dynamic" ErrorMessage="Email provided is not in the correct format!" style="color: #FF0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    &nbsp; </td>
                <td>
                    <asp:TextBox ID="txtboxSecEmail" runat="server" MaxLength="49"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtboxSecEmail" Display="Dynamic" ErrorMessage="Secondary Email provided is not in the correct format!" style="color: #FF0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label24" runat="server" Text="Date of Birth"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label25" runat="server" Text="Gender"></asp:Label>
                </td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtboxDob" runat="server" TextMode="Date" Width="167px"></asp:TextBox>
                    <asp:Label ID="lblDobAsterik0" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="txtboxDob" ErrorMessage="Date of Birth required!" style="color: #FF3300">*</asp:RequiredFieldValidator>
                    <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtboxDob" Display="Dynamic" ErrorMessage="Dob provided is not in the correct format!" style="color: #FF0000" ValidationExpression="^\d{1,2}\/\d{1,2}\/\d{4}$">*</asp:RegularExpressionValidator>--%>
                </td>
                <td>
                    <asp:DropDownList ID="dropdownlistGender" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="lblGenderAsterik0" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="dropdownlistGender" ErrorMessage="Gender required!" style="color: #FF3300">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label20" runat="server" Text="Contact Number"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label21" runat="server" Text="Secondary Contact Number"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtboxContact" runat="server" MaxLength="19"></asp:TextBox>
                    <asp:Label ID="lblContactAsterik" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtboxContact" ErrorMessage="Contact Number required!" style="color: #FF3300">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtboxContact" Display="Dynamic" ErrorMessage="Contact Number provided is not in the correct format! Accepts only +... or 0... or decimal..." style="color: #FF0000" ValidationExpression="^[+|0\d][\d|\s]*">*</asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:TextBox ID="txtboxSecContact" runat="server" MaxLength="49"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtboxSecContact" Display="Dynamic" ErrorMessage="Secondary Contact Number provided is not in the correct format! Accepts only +... or 0... or decimal..." style="color: #FF0000" ValidationExpression="^[+|0\d][\d|\s]*">*</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label22" runat="server" Text="Address"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtboxHouseAdd" placeholder="House Address" runat="server" MaxLength="39"></asp:TextBox>
                </td>
                <td style="margin-left: 40px">
                    <asp:TextBox ID="txtboxDistrict" placeholder="District" runat="server" MaxLength="19"></asp:TextBox>
                    <asp:Label ID="lblDistrictAsterik" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtboxDistrict" ErrorMessage="District required!" style="color: #FF3300">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="txtboxDistrict" Display="Dynamic" ErrorMessage="District provided is not in the correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z]*[ ]*|[a-zA-Z]*[ ]*|[a-z]*[ ]*|[A-Z]*[ ]*$/">*</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtboxCity" placeholder="City" runat="server" MaxLength="19"></asp:TextBox>
                    <asp:Label ID="lblCityAsterik" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtboxCity" ErrorMessage="City required!" style="color: #FF3300">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="txtboxCity" Display="Dynamic" ErrorMessage="City provided is not in the correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z]*[ ]*|[a-zA-Z]*[ ]*|[a-z]*[ ]*|[A-Z]*[ ]*$/">*</asp:RegularExpressionValidator>
                </td>
                <td style="margin-left: 40px">
                    <asp:TextBox ID="txtboxCountry" placeholder="Country: Nepal by default" runat="server" MaxLength="24"></asp:TextBox>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="margin-left: 40px">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td style="margin-left: 40px">
                    <asp:Button ID="btnRegister" runat="server" Text="Register" Width="70px" OnClick="btnRegister_Click" />
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: left">&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

