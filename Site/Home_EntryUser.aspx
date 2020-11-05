<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_EntryUser.master" AutoEventWireup="true" CodeFile="Home_EntryUser.aspx.cs" Inherits="Home_EntryUser" %>

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
            <td colspan="2" style="text-align: center">
                    <asp:HyperLink ID="HyperLink9" runat="server" CssClass="headerlink" Font-Bold="True" Font-Size="Large" NavigateUrl="~/Home_OtherUser.aspx">Home</asp:HyperLink>
                </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: left; color: #FF3300;">
                <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
                </td>
        </tr>
        <tr>
            <td colspan="2">
                <%--<asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" align="center" Width="700px">--%>
                <asp:DataList ID="DataList1" runat="server" align="center" Width="700px">
                    <AlternatingItemStyle BackColor="White" />
                    <ItemStyle BackColor="Silver" />
                    <ItemTemplate>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date:
                        <asp:Label ID="DatesLabel" runat="server" Text='<%# Eval("Dates") %>' />
                        <br />
                        &nbsp; Operation:
                        <asp:Label ID="OperationLabel" runat="server" Text='<%# Eval("userIndivFieldLog_Operation") %>' />
                        <br />
                        &nbsp; Name:
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("username") %>' />
                        <br />
                        <br />
                        &nbsp; Field:
                        <asp:Label ID="FieldChangedLabel" runat="server" Text='<%# Eval("userIndivFieldLog_Field") %>' />
                        <br />
                        &nbsp; Before:
                        <asp:Label ID="DataBeforeLabel" runat="server" Text='<%# Eval("userIndivFieldLog_DataBefore") %>' />
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


