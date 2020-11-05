<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_OtherUser.master" AutoEventWireup="true" CodeFile="Log_EntryUserLog_OtherUserMaster.aspx.cs" Inherits="Log_EntryUserLog_OtherUserMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .headerlink {
            color: black;
            text-decoration: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <table class="auto-style1">
        <tr>
            <td colspan="2" style="text-align: left">
                    <asp:HyperLink ID="HyperLink13" runat="server" CssClass="link" NavigateUrl="~/Log_EntryUser_OtherUserMaster.aspx">ENTRY USER LIST</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:HyperLink ID="HyperLink9" runat="server" CssClass="headerlink" Font-Bold="True" Font-Size="Large" NavigateUrl="~/Log_EntryUserLog_OtherUserMaster.aspx">Entry User Log</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="color: #FF3300">
                <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:DataList ID="DataList1" runat="server" align="center" Width="700px">
                    <AlternatingItemStyle BackColor="White" />
                    <ItemStyle BackColor="Silver" />
                    <ItemTemplate>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date:
                        <asp:Label ID="DateLabel" runat="server" Text='<%# Eval("Dates") %>' />
                        <br />
                        &nbsp; Operation:
                        <asp:Label ID="DiseaseLabel" runat="server" Text='<%# Eval("userIndivFieldLog_Operation") %>' />
                        <br />
                        &nbsp; 
                        <asp:Label ID="RemarksLabel" runat="server" Text='<%# Eval("username") %>' />
                        <br />
                        <br />
                        &nbsp; Field:
                        <asp:Label ID="HospitalLabel" runat="server" Text='<%# Eval("userIndivFieldLog_Field") %>' />
                        <br />
                        &nbsp; Before:
                        <asp:Label ID="CheckedByLabel" runat="server" Text='<%# Eval("userIndivFieldLog_Databefore") %>' />
                        <br />
                        &nbsp; Later:
                        <asp:Label ID="DataLaterLabel" runat="server" Text='<%# Eval("userIndivFieldLog_DataLater") %>' />
                        <br />
                        <br />
                    </ItemTemplate>
                </asp:DataList>
                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HISConnectionString %>" SelectCommand="SELECT Dates, Operation, Name, FieldChanged, DataBefore, DataLater FROM OtherUser_Home ORDER BY CONVERT (DATETIME, Dates, 103) DESC"></asp:SqlDataSource>--%>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>



