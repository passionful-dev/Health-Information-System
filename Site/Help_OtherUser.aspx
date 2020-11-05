<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_OtherUser.master" AutoEventWireup="true" CodeFile="Help_OtherUser.aspx.cs" Inherits="Help_OtherUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 500px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel2" runat="server">
        <table class="auto-style1" align="center">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <p>
                        Home: What ALL the things done by that user according to date
                    </p>
                    <pre>            - hospital insert, updated, deleted
            - patients insert, updated, deleted
            - feedback insert, delete 
        </pre>
                    <p>
                    </p>
                    <p>
                        Hospital:
                    </p>
                    <pre>        - Hospital record as: insert, update and delete
        - Report inside here: Print format of the Other User history of <u>hospital published</u> according to date.
        </pre>
                    <p>
                    </p>
                    <p>
                        Patient: Patient record as: insert, update and delete</p>
                    <p>
                        Analysis: Same as that of Health in Guest user.</p>
                    <p>
                        Inform: Inform anything to Entryuser.</p>
                    <p>
                        Log: 1. Patient: a. All inserted, updated, logged on, logged out log. ( b. This could be printed in report format also.) 2. Entry User: All inserted, updated, logged on, logged out log. ( b. This could be printed in report format also.)</p>
                    <p>
                        Search: <u>Same like Entry user search</u> - Disease name - Disease info that user provided. - Give date - Patient checked - Disease info provided - Patient name - That&#39;s patient&#39;s home comes</p>
                    Social button and rest: Same as guest user.</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

