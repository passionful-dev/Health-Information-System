<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_EntryUser.master" AutoEventWireup="true" CodeFile="Help_EntryUserMaster.aspx.cs" Inherits="Help_EntryUserMaster" %>

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
                        Home:
                    </p>
                    <pre>        - What ALL the patients checked according to date
        - what informed</pre>
                    <p>
                    </p>
                    <p>
                        Health: What all the health report (remarks) provided by current user, according to date</p>
                    <p>
                        Patient:
                    </p>
                    <pre>            - Shows list of patient. 
            - At somewhere on that list, Search text box for patient username.
            - Either click, or search and hit enter, then that patient&#39;s hospital history or home of that user comes.
            - Also will have there place to enter data. 
               - This can be edited (means can update, delete). 
            - Report inside here: Print format of the Entry User history <u>checked patient</u> and <u>health published</u> according to date.
                 </pre>
                    <p>
                    </p>
                    <p>
                        Analysis: Same as that of Health in Guest user.</p>
                    <p>
                        Inform: Give the appointment date, time and place (hospital name).</p>
                    <p>
                        Notification: Can be anything from admin user.</p>
                    <p>
                        Search:
                    </p>
                    <pre>            - Disease name 
                  - Disease info that user provided.
            - Give date
                  - Patient checked
                  - Disease info provided
            - Patient name
                  - That&#39;s patient&#39;s home comes</pre>
                    <p>
                    </p>
                    <p>
                        Social button and rest: Same as guest user.</p>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

