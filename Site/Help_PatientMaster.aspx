<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_Patient.master" AutoEventWireup="true" CodeFile="Help_PatientMaster.aspx.cs" Inherits="Help_PatientMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 500px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1" align="center">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">
            <p>
                In Home: every detail with date and all of the health of that patient.</p>
            <p>
                In Health, Hospital, social media link: shows all the same as that for guest user.
            </p>
            <p>
                In Report: Print format of the patient history according to date.</p>
            <p>
                In Notification: Shows appointment date, time and place (hospital name)</p>
            <p>
                In Search: Search history according to date, disease</p>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

