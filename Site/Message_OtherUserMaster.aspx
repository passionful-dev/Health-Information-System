<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_OtherUser.master" AutoEventWireup="true" CodeFile="Message_OtherUserMaster.aspx.cs" Inherits="Message_OtherUserMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style3 {
        }

        .auto-style4 {
            border-top-style: solid;
            border-top-color: grey;
            width: 100px;
        }

        .auto-style5 {
            width: 100px;
        }
    </style>
    <link href="StyleSheet_CommonOnAll.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="Panel2" runat="server">
        <table align="center">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center">&nbsp;</td>
                <td style="text-align: center">
                    <asp:HyperLink ID="HyperLink9" runat="server" CssClass="headerlink" Font-Bold="True" Font-Size="Large" NavigateUrl="~/Message_OtherUserMaster.aspx">Message</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="color: #FF3300">
                    <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
                </td>
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
                <td style="text-align: left" class="auto-style5">&nbsp;</td>
                <td style="text-align: left">&nbsp;
                    <asp:LinkButton ID="lnkbtn_InboxReport" runat="server" CssClass="link" OnClick="lnkbtn_InboxReport_Click"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="lnkbtn_SentReport" runat="server" CssClass="link" OnClick="lnkbtn_SentReport_Click" Visible="False"></asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;
                    <asp:LinkButton ID="lnkbtn_NewMessage" runat="server" CssClass="link" OnClick="lnkbtn_NewMessage_Click">New</asp:LinkButton>
                </td>
                <td rowspan="8">
                    <div class="ToLabel" style="text-align: center">
                        <asp:Label ID="lbl_ToLabel" runat="server" Text="To" Visible="False"></asp:Label>
                        &nbsp;<asp:Label ID="lbl_ToUsername" runat="server" Visible="False" style="background-color: #FFFF00"></asp:Label>
                    </div>
                    <div>
                    </div>
                    <div class="SubjectLabel" style="text-align: center">
                        <asp:Label ID="lbl_Subject" runat="server" Text="Subject" Visible="False"></asp:Label>
                    </div>
                    <div class="SubjectTextbox" style="text-align: center">
                        <asp:TextBox ID="txtbox_Subject" runat="server" placeholder="Subject" TextMode="MultiLine" Visible="False" Width="168px" MaxLength="99"></asp:TextBox>
                    </div>
                    <div class="MessageLabel" style="text-align: center">
                        <asp:Label ID="lbl_Message" runat="server" Text="Message" Visible="False"></asp:Label>
                    </div>
                    <div class="MessageTextbox" style="text-align: center">
                        <asp:TextBox ID="txtbox_Message" runat="server" placeholder="Message" TextMode="MultiLine" Visible="False" Width="168px" MaxLength="399"></asp:TextBox>
                    </div>
                    <div>
                    </div>
                    <div class="SendButton" style="text-align: center">
                        <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click" Text="Send" ValidationGroup="Message" Visible="False" Width="70px" />
                    </div>
                    &nbsp;<div style="overflow-x: auto; width: 800px; text-align: center">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" align="center" Width="800px">
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <AlternatingRowStyle BackColor="#CCCCCC" />
                            <Columns>
                                <%--<asp:ButtonField CommandName="Select" Text="Delete" />--%><%--To get a column with sno.--%>
                                <asp:TemplateField HeaderText="No.">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                                <asp:BoundField DataField="username" HeaderText="From" SortExpression="username" />
                                <asp:BoundField DataField="Subject" HeaderText="Subject" SortExpression="Subject" />
                                <asp:BoundField DataField="Message" HeaderText="Message" SortExpression="Message" />
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" />
                            <%--<SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />--%>
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        </asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dropdownlist_SendToUsernameList" runat="server" Visible="False">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;
                    <asp:Button ID="btn_Ok_SendToUsernameList" runat="server" OnClick="btn_Ok_SendToUsernameList_Click" Text="Ok" Visible="False" />

                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;
                    <asp:LinkButton ID="lnkbtn_Inbox" runat="server" CssClass="link" OnClick="lnkbtn_Inbox_Click">Inbox</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;
                    <asp:LinkButton ID="lnkbtn_Sent" runat="server" CssClass="link" OnClick="lnkbtn_Sent_Click">Sent</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" align="">&nbsp; 
                    <div>
                        &nbsp;
                    </div>
                    <div>
                        &nbsp;
                    </div>
                    <div>
                        &nbsp;
                    </div>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;
                    
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>


