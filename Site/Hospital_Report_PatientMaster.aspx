<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Patient.master" AutoEventWireup="true" CodeFile="Hospital_Report_PatientMaster.aspx.cs" Inherits="Hospital_Report_PatientMaster" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

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
    <asp:Panel ID="Panel1" runat="server">
        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <asp:HyperLink ID="HyperLink13" runat="server" CssClass="link" NavigateUrl="~/Hospital_PatientMaster.aspx">VIEW</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:HyperLink ID="HyperLink14" runat="server" Font-Bold="True" Font-Size="Large" CssClass="headerlink" NavigateUrl="~/Hospital_Report_PatientMaster.aspx">Hospital Report</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:LinkButton ID="lnkbtn_A" runat="server" CssClass="link" OnClick="lnkbtn_A_Click">A</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_B" runat="server" CssClass="link" OnClick="lnkbtn_B_Click">B</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_C" runat="server" CssClass="link" OnClick="lnkbtn_C_Click">C</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_D" runat="server" CssClass="link" OnClick="lnkbtn_D_Click">D</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_E" runat="server" CssClass="link" OnClick="lnkbtn_E_Click">E</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_F" runat="server" CssClass="link" OnClick="lnkbtn_F_Click">F</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_G" runat="server" CssClass="link" OnClick="lnkbtn_G_Click">G</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_H" runat="server" CssClass="link" OnClick="lnkbtn_H_Click">H</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_I" runat="server" CssClass="link" OnClick="lnkbtn_I_Click">I</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_J" runat="server" CssClass="link" OnClick="lnkbtn_J_Click">J</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_K" runat="server" CssClass="link" OnClick="lnkbtn_K_Click">K</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_L" runat="server" CssClass="link" OnClick="lnkbtn_L_Click">L</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_M" runat="server" CssClass="link" OnClick="lnkbtn_M_Click">M</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_N" runat="server" CssClass="link" OnClick="lnkbtn_N_Click">N</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_O" runat="server" CssClass="link" OnClick="lnkbtn_O_Click">O</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_P" runat="server" CssClass="link" OnClick="lnkbtn_P_Click">P</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_Q" runat="server" CssClass="link" OnClick="lnkbtn_Q_Click">Q</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_R" runat="server" CssClass="link" OnClick="lnkbtn_R_Click">R</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_S" runat="server" CssClass="link" OnClick="lnkbtn_S_Click">S</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_T" runat="server" CssClass="link" OnClick="lnkbtn_T_Click">T</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_U" runat="server" CssClass="link" OnClick="lnkbtn_U_Click">U</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_V" runat="server" CssClass="link" OnClick="lnkbtn_V_Click">V</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_W" runat="server" CssClass="link" OnClick="lnkbtn_W_Click">W</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_X" runat="server" CssClass="link" OnClick="lnkbtn_X_Click">X</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_Y" runat="server" CssClass="link" OnClick="lnkbtn_Y_Click">Y</asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_Z" runat="server" CssClass="link" OnClick="lnkbtn_Z_Click">Z</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="color: #FF3300">
                    <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="648px" style="margin-right: 0px">
                        <LocalReport ReportPath="Report_Hospital_OtherUserMaster.rdlc">
                            <DataSources>
                                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                            </DataSources>
                        </LocalReport>
                    </rsweb:ReportViewer>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="DataSet_Hospital_Report_OtherUserMasterTableAdapters.DataTable1TableAdapter"></asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ScriptManager ID="ScriptManager2" runat="server">
                    </asp:ScriptManager>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </asp:Panel>
</asp:Content>


