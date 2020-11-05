<%@ Page Title="" Language="C#" UnobtrusiveValidationMode="none" MasterPageFile="~/MasterPage_EntryUser.master" AutoEventWireup="true" CodeFile="Patient_CheckupWithHistory_EntryUserMaster.aspx.cs" Inherits="Patient_CheckupWithHistory_EntryUserMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="~/Patient_EntryUserMaster.aspx" CssClass="link">VIEW</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="5" style="text-align: center">
                <asp:HyperLink ID="HyperLink9" runat="server" CssClass="headerlink" Font-Bold="True" Font-Size="Large" NavigateUrl="~/Patient_CheckupWithHistory_EntryUserMaster.aspx">Check Up</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="5" style="color: #FF3300">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="5" style="color: #FF3300">
                <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
                <asp:Literal ID="ltrMessage1" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td style="text-align: center">
                &nbsp;<asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="Label3" runat="server" Text="Full Name"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="Label5" runat="server" Text="Dob"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="Label7" runat="server" Text="Age Grp"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="Label9" runat="server" Text="Sex"></asp:Label>
            </td>
        </tr>
        <tr>
            <td width ="145px" style="text-align: center">
                &nbsp;<asp:Label ID="lbl_Username" runat="server" Text="Label" style="color: #000000; background-color: #FFFF00"></asp:Label>
            </td>
            <td width="190px" style="text-align: center">
                <asp:Label ID="lbl_Name" runat="server" Text="Label" style="background-color: #FFFF00"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="lbl_Dob" runat="server" Text="Label" style="background-color: #FFFF00"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="lbl_AgeGrp" runat="server" Text="Label" style="background-color: #FFFF00"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="lbl_Gender" runat="server" Text="Label" style="background-color: #FFFF00"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="5" style="text-align: center">
                <asp:Label ID="Label10" runat="server" Text="Disease Name"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="5" style="text-align: left">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtbox_DiseaseName" runat="server" MaxLength="49"></asp:TextBox>
                <asp:Label ID="Label12" runat="server" Text="*"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtbox_DiseaseName" ErrorMessage="Disease Name required!" Style="color: #FF3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="5">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="5" style="text-align: center">
                <asp:Label ID="Label11" runat="server" Text="Remarks"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="5" style="text-align: center">
                <asp:TextBox ID="txtbox_Remarks" runat="server" TextMode="MultiLine" Width="167px" MaxLength="399"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="5" style="text-align: center">
                <asp:Button ID="btn_Ok" runat="server" Text="Ok" Width="70px" OnClick="btn_Ok_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="5">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:GridView ID="GridView1" runat="server" align="center" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="6" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <%--<asp:ButtonField CommandName="Select" Text="Delete" />--%>
                        <%--To get a column with sno.--%>
                        <asp:TemplateField HeaderText="No.">
                            <ItemTemplate>
                                <%# Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                        <asp:BoundField DataField="Disease" HeaderText="Disease" SortExpression="Disease" />
                        <asp:BoundField DataField="Remarks" HeaderText="Remarks" SortExpression="Remarks" />
                        <asp:BoundField DataField="Hospital" HeaderText="Hospital" SortExpression="Hospital" />
                        <asp:BoundField DataField="Checkedby" HeaderText="Checked By" SortExpression="Checkedby" />
                        <%--Putting Contacts in one column--%>
                        <%--<asp:TemplateField HeaderText="Contacts">
                            <ItemTemplate>
                                <%# Eval("patientContact") %> ; <%# Eval("patientSecContact") %>
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        <%--<asp:ButtonField CommandName="Select" Text="Delete" />--%>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

