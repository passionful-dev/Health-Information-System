<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Patient.master" UnobtrusiveValidationMode="none" MaintainScrollPositionOnPostBack="true" AutoEventWireup="true" CodeFile="EditProfile_Patient.aspx.cs" Inherits="EditProfile_Patient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            /*width: 100%;*/
        }
        .auto-style3 {
            height: 30px;
        }
        </style>
    <link href="StyleSheet_CommonOnAll.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel2" runat="server">
        <table class="auto-style1" align="center">
            <tr>
                <td style="text-align: right">
                    &nbsp;</td>
                <td style="text-align: left">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="Edit Profile"></asp:Label>
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
                    <asp:Label ID="lblFirstName" runat="server">FirstName</asp:Label>
                    <asp:Label ID="lblMiddleName" runat="server">MiddleName</asp:Label>
                    <asp:Label ID="lblLastName" runat="server">LastName</asp:Label>
                    <asp:Label ID="lblName" runat="server" Visible="False">Name</asp:Label>
                </td>
                <td colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_Name" runat="server" CausesValidation="False" CssClass="link" OnClick="lnkbtnEdit_Name_Click">Edit Name</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtboxFirstName" placeholder="First Name" runat="server" Visible="False" MaxLength="19"></asp:TextBox>
                </td>
                <td colspan="2">
                    &nbsp;</td>
                <td>
                    <asp:RequiredFieldValidator ID="ReqFieldVald_FirstName" runat="server" ControlToValidate="txtboxFirstName" ErrorMessage="First Name required!" style="color: #FF3300" ValidationGroup="Name">First Name required!</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtboxFirstName" Display="Dynamic" ErrorMessage="First name provided is not in the correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z]*[ ]*|[a-zA-Z]*[ ]*|[a-z]*[ ]*|[A-Z]*[ ]*$/">Not in correct format!</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtboxMiddleName" runat="server" placeholder="Middle Name" Visible="False" MaxLength="19"></asp:TextBox>
                </td>
                <td colspan="2">&nbsp;</td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="txtboxMiddleName" Display="Dynamic" ErrorMessage="Middle name provided is not in the correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z ]*|[a-zA-Z ]*|[a-z ]*|[A-Z ]*$/">Not in the correct format!</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:TextBox ID="txtboxLastName" runat="server" placeholder="Last Name" Visible="False" MaxLength="19"></asp:TextBox>
                </td>
                <td class="auto-style3" colspan="2">
                    <asp:Button ID="btnOk_Name" runat="server" OnClick="btnOk_Name_Click" Text="Ok" ValidationGroup="Name" Visible="False" />
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="ReqFieldVald_LastName1" runat="server" ControlToValidate="txtboxLastName" ErrorMessage="Last Name required!" style="color: #FF0000" ValidationGroup="Name">Last Name required!</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="txtboxLastName" Display="Dynamic" ErrorMessage="Last name provided is not in the correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z]*[ ]*|[a-zA-Z]*[ ]*|[a-z]*[ ]*|[A-Z]*[ ]*$/">Not in correct format!</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 80px" class="separator">
                    <asp:Label ID="lblUsername" runat="server">Username</asp:Label>
                    <asp:Label ID="lblUsernameLabel" runat="server" Visible="False">UsernameLabel</asp:Label>
                </td>
                <td class="separator" colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_Username" runat="server" CausesValidation="False" CssClass="link" OnClick="lnkbtnEdit_Username_Click">Edit Username</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 120px">
                    <asp:TextBox ID="txtboxUsername" placeholder="Username" runat="server" Visible="False" MaxLength="49"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:Button ID="btnOk_Username" runat="server" Text="Ok" Visible="False" OnClick="btnOk_Username_Click" ValidationGroup="Username" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ReqFieldVald_Username0" runat="server" ControlToValidate="txtboxUsername" ErrorMessage="Username required!" style="color: #FF3300" ValidationGroup="Username">Username required!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 120px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 120px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 120px" class="separator">
                    <asp:Label ID="lblPassword" runat="server">*****</asp:Label>
                    <asp:Label ID="lblPasswordLabel" runat="server" Visible="False">Password</asp:Label>
                </td>
                <td class="separator" colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_Password" runat="server" CausesValidation="False" OnClick="lnkbtnEdit_Password_Click" CssClass="link">Edit Password</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 120px">
                    <asp:TextBox ID="txtboxOldPassword" placeholder="Old Password" runat="server" Visible="False" TextMode="Password" MaxLength="19"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtboxNewPassword" placeholder="New Password" runat="server" Visible="False" TextMode="Password" MaxLength="19"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ReqFieldVald_NewPassword0" runat="server" ControlToValidate="txtboxNewPassword" ErrorMessage="New Password required!" style="color: #FF3300" ValidationGroup="Password">New Password required!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 120px">
                    <asp:RequiredFieldValidator ID="ReqFieldVald_OldPassword" runat="server" ControlToValidate="txtboxOldPassword" ErrorMessage="Old Password required!" style="color: #FF3300" ValidationGroup="Password">Old Password required!</asp:RequiredFieldValidator>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtboxNewConfirmPassword" runat="server" placeholder="Confirm New Password" TextMode="Password" Visible="False" MaxLength="19"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ReqFieldVald_NewConfirmPassword" runat="server" ControlToValidate="txtboxNewConfirmPassword" ErrorMessage="Confirm New Password required!" style="color: #FF3300" ValidationGroup="Password">Confirm New Password required!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 120px">&nbsp;</td>
                <td colspan="2">
                    <asp:Button ID="btnOk_Password" runat="server" OnClick="btnOk_Password_Click" Text="Ok" ValidationGroup="Password" Visible="False" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 120px" class="separator">
                    <asp:Label ID="lblEmail" runat="server">Email</asp:Label>
                    <asp:Label ID="lblEmailLabel" runat="server" Visible="False">Email</asp:Label>
                </td>
                <td class="separator" colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_Email" runat="server" CausesValidation="False" OnClick="lnkbtnEdit_Email_Click" CssClass="link">Edit Email</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 120px">
                    <asp:TextBox ID="txtboxEmail" placeholder="Email" runat="server" Visible="False" MaxLength="49"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:Button ID="btnOk_Email" runat="server" Text="Ok" Visible="False" OnClick="btnOk_Email_Click" ValidationGroup="Email" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ReqFieldVald_Email0" runat="server" ControlToValidate="txtboxEmail" ErrorMessage="Email required!" style="color: #FF3300" ValidationGroup="Email">Email required!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 120px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtboxEmail" Display="Dynamic" ErrorMessage="Not in correct format!" style="color: #FF0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Email">Not in correct format!</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 120px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 120px" class="separator">
                    <asp:Label ID="lblDob" runat="server">Date of birth</asp:Label>
                    <asp:Label ID="lblDobLabel" runat="server" Visible="False">Date of birth</asp:Label>
                </td>
                <td class="separator" colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_Dob" runat="server" CausesValidation="False" OnClick="lnkbtnEdit_Dob_Click" CssClass="link">Edit Date of Birth</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 120px">
                    <asp:TextBox ID="txtboxDob" placeholder="Date of Birth (dd/mm/yyyy)" runat="server" Visible="False" TextMode="Date" Width="167px"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:Button ID="btnOk_Dob" runat="server" Text="Ok" Visible="False" OnClick="btnOk_Dob_Click" CausesValidation="False" ValidationGroup="Dob" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ReqFieldVald_Dob0" runat="server" ControlToValidate="txtboxDob" ErrorMessage="Date of Birth required!" style="color: #FF3300" ValidationGroup="Dob">Date of Birth required!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 120px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>
                    <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtboxDob" Display="Dynamic" ErrorMessage="Not in correct format!" style="color: #FF0000" ValidationExpression="^\d{1,2}\/\d{1,2}\/\d{4}$" ValidationGroup="Dob">Not in correct format!</asp:RegularExpressionValidator>--%>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 120px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px" class="separator">
                    <asp:Label ID="lblGender" runat="server">Gender</asp:Label>
                    <asp:Label ID="lblGenderLabel" runat="server" Visible="False">Gender</asp:Label>
                </td>
                <td class="separator" colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_Gender" runat="server" CausesValidation="False" OnClick="lnkbtnEdit_Gender_Click" CssClass="link">Edit Gender</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px">
                    <asp:DropDownList ID="dropdownlistGender" runat="server" Visible="False">
                        <asp:ListItem Value="M">Male</asp:ListItem>
                        <asp:ListItem Value="F">Female</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;</td>
                <td colspan="2">
                    <asp:Button ID="btnOk_Gender" runat="server" Text="Ok" Visible="False" OnClick="btnOk_Gender_Click" ValidationGroup="Gender" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ReqFieldVald_Gender0" runat="server" ControlToValidate="dropdownlistGender" ErrorMessage="Gender required!" style="color: #FF3300" ValidationGroup="Gender">Gender required!</asp:RequiredFieldValidator>
                </td>
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
            <tr>
                <td style="margin-left: 160px" class="separator">
                    <asp:Label ID="lblContact" runat="server">Contact Number</asp:Label>
                    <asp:Label ID="lblContactLabel" runat="server" Visible="False">Contact Number</asp:Label>
                </td>
                <td class="separator" colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_Contact" runat="server" CausesValidation="False" OnClick="lnkbtnEdit_Contact_Click" CssClass="link">Edit Contact Number</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px">
                    <asp:TextBox ID="txtboxContact" placeholder="Contact Number" runat="server" Visible="False" MaxLength="19"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:Button ID="btnOk_Contact" runat="server" Text="Ok" Visible="False" OnClick="btnOk_Contact_Click" ValidationGroup="Contact" />
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ReqFieldVald_Contact0" runat="server" ControlToValidate="txtboxContact" ErrorMessage="Contact Number required!" style="color: #FF3300" ValidationGroup="Contact">Contact Number required!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 160px">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtboxContact" Display="Dynamic" ErrorMessage="Not in correct format!" style="color: #FF0000" ValidationExpression="^[+|0\d][\d|\s]*" ValidationGroup="Contact">Not in correct format!</asp:RegularExpressionValidator>
                </td>
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
                    <asp:RequiredFieldValidator ID="ReqFieldVald_District0" runat="server" ControlToValidate="txtboxDistrict" ErrorMessage="District required!" style="color: #FF3300" ValidationGroup="Address">District required!</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="txtboxDistrict" Display="Dynamic" ErrorMessage="District provided is not in the correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z]*[ ]*|[a-zA-Z]*[ ]*|[a-z]*[ ]*|[A-Z]*[ ]*$/">Not in correct format!</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 160px">
                    <asp:Label ID="lblCity" runat="server">City</asp:Label>
                    <asp:TextBox ID="txtboxCity" runat="server" placeholder="City" Visible="False" MaxLength="19"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:Label ID="lblCountry" runat="server">Country</asp:Label>
                    <asp:TextBox ID="txtboxCountry" runat="server" placeholder="Country" Visible="False" MaxLength="24"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="ReqFieldVald_City" runat="server" ControlToValidate="txtboxCity" ErrorMessage="City required!" style="color: #FF3300" ValidationGroup="Address">City required!</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ControlToValidate="txtboxCity" Display="Dynamic" ErrorMessage="City is not in correct format!" style="color: #FF0000" ValidationExpression="/^[A-Za-z]*[ ]*|[a-zA-Z]*[ ]*|[a-z]*[ ]*|[A-Z]*[ ]*$/">Not in correct format!</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 160px">&nbsp;</td>
                <td colspan="2">
                    <asp:Button ID="btnOk_Address" runat="server" OnClick="btnOk_Address_Click" Text="Ok" ValidationGroup="Address" Visible="False" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px" class="separator">
                    <asp:Label ID="lblSecEmail" runat="server">Secondary Email</asp:Label>
                    <asp:Label ID="lblSecEmailLabel" runat="server" Visible="False">Secondary Email</asp:Label>
                </td>
                <td class="separator" colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_SecEmail" runat="server" CausesValidation="False" OnClick="lnkbtnEdit_SecEmail_Click" CssClass="link">Edit Secondary Email</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px">
                    <asp:TextBox ID="txtboxSecEmail" runat="server" placeholder="Secondary Email" Visible="False" MaxLength="49"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:Button ID="btnOk_SecEmail" runat="server" Text="Ok" Visible="False" OnClick="btnOk_SecEmail_Click" ValidationGroup="SecEmail" />
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtboxSecEmail" Display="Dynamic" ErrorMessage="Not in correct format!" style="color: #FF0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="SecEmail">Not in correct format!</asp:RegularExpressionValidator>
                </td>
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
            <tr>
                <td style="margin-left: 160px" class="separator">
                    <asp:Label ID="lblSecContact" runat="server">Secondary Contact Number</asp:Label>
                    <asp:Label ID="lblSecContactLabel" runat="server" Visible="False">Secondary Contact Number</asp:Label>
                </td>
                <td class="separator" colspan="2">
                    <asp:LinkButton ID="lnkbtnEdit_SecContact" runat="server" CausesValidation="False" OnClick="lnkbtnEdit_SecContact_Click" CssClass="link">Edit Secondary Contact Number</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 160px">
                    <asp:TextBox ID="txtboxSecContact" runat="server" placeholder="Secondary Contact Number" Visible="False" MaxLength="49"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:Button ID="btnOk_SecContact" runat="server" Text="Ok" Visible="False" OnClick="btnOk_SecContact_Click" ValidationGroup="SecContact" />
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtboxSecContact" Display="Dynamic" ErrorMessage="Not in correct format!" style="color: #FF0000" ValidationExpression="^[+|0\d][\d|\s]*" ValidationGroup="SecContact">Not in correct format!</asp:RegularExpressionValidator>
                </td>
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


