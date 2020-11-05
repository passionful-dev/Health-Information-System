<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Patient.master" AutoEventWireup="true" CodeFile="Report_PatientMaster.aspx.cs" Inherits="Report_PatientMaster" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td colspan="2" style="text-align: center">
                    <asp:HyperLink ID="HyperLink14" runat="server" CssClass="headerlink" Font-Bold="True" Font-Size="Large" NavigateUrl="~/Report_PatientMaster.aspx">Patient Report</asp:HyperLink>
                </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" style="color: #FF3300">
                    <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
                </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="545px">
                    <LocalReport ReportPath="Report_PatientMaster.rdlc">
                        <DataSources>
                            <rsweb:ReportDataSource DataSourceId="ObjectDataSource2" Name="DataSet1" />
                        </DataSources>
                    </LocalReport>
                </rsweb:ReportViewer>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetData" TypeName="DataSet_Report_PatientMasterTableAdapters.DataTable1TableAdapter"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="DataSet_Patient_Report_OtherUserMasterTableAdapters.DataTable1TableAdapter"></asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

