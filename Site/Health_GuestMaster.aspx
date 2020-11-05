<%@ Page Title="" Language="C#" UnobtrusiveValidationMode="none" MaintainScrollPositionOnPostback="true" MasterPageFile="~/MasterPage_Guest.master" AutoEventWireup="true" CodeFile="Health_GuestMaster.aspx.cs" Inherits="Health_GuestMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
        .auto-style1 {
            /*width: 100%;*/
        }
        .auto-style2 {
            height: 23px;
            color: #FF3300;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel2" runat="server">
        <table class="auto-style1" align="center">
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Health Analysis"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Literal ID="ltrMessage" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Analyse on"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:DropDownList ID="dropdownlist_Of2" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Date and Disease</asp:ListItem>
                        <asp:ListItem>Date and Unhealthy People</asp:ListItem>
                        <asp:ListItem>Date and Unhealthy Female</asp:ListItem>
                        <asp:ListItem>Date and Unhealthy Male</asp:ListItem>
                        <asp:ListItem>Date and Unhealthy AgeGrp</asp:ListItem>
                        <asp:ListItem>Date and Unhealthy District</asp:ListItem>
                        <asp:ListItem>Date and Unhealthy City</asp:ListItem>
                        <asp:ListItem>Date and Disease and People</asp:ListItem>
                        <asp:ListItem>Date and Disease and Female</asp:ListItem>
                        <asp:ListItem>Date and Disease and Male</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btn_Of2_Ok" runat="server" OnClick="btn_Of2_Ok_Click" Text="Ok" />
                    &nbsp;<asp:DropDownList ID="dropdownlist_AgeGrp" runat="server" Visible="False">
                        <asp:ListItem>1-4</asp:ListItem>
                        <asp:ListItem>5-14</asp:ListItem>
                        <asp:ListItem>15-19</asp:ListItem>
                        <asp:ListItem>20-29</asp:ListItem>
                        <asp:ListItem>30-39</asp:ListItem>
                        <asp:ListItem>40-49</asp:ListItem>
                        <asp:ListItem>50-59</asp:ListItem>
                        <asp:ListItem>60-64</asp:ListItem>
                        <asp:ListItem>&gt;=65</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnOk_AgeGrp" runat="server" OnClick="btnOk_AgeGrp_Click" Text="Ok" Visible="False" />
                    &nbsp;<asp:DropDownList ID="dropdownlist_District" runat="server" Visible="False">
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnOk_District" runat="server" OnClick="btnOk_District_Click" Text="Ok" Visible="False" />
                    &nbsp;<asp:DropDownList ID="dropdownlist_City" runat="server" Visible="False">
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnOk_City" runat="server" OnClick="btnOk_City_Click" Text="Ok" Visible="False" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;<br />&nbsp;&nbsp;&nbsp;<br /> 
                    &nbsp;<asp:Chart ID="Chart1" runat="server" Height="250px" Width="950px">
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1">
                            </asp:ChartArea>
                        </ChartAreas>
                        <Legends>
                            <asp:Legend Name="Legend1">
                            </asp:Legend>
                        </Legends>
                    </asp:Chart>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 40px">
                    <asp:Label ID="Label4" runat="server" Text="Analyse on"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 40px" colspan="2">
                    <asp:DropDownList ID="dropdownlist_Of3" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Date and Disease and People</asp:ListItem>
                        <asp:ListItem>Date and Disease and Female</asp:ListItem>
                        <asp:ListItem>Date and Disease and Male</asp:ListItem>
                        <asp:ListItem>Date and Disease and AgeGrp</asp:ListItem>
                        <asp:ListItem>Date and Disease and District</asp:ListItem>
                        <asp:ListItem>Date and Disease and City</asp:ListItem>
                        <asp:ListItem>Date and People and AgeGrp</asp:ListItem>
                        <asp:ListItem>Date and Female and AgeGrp</asp:ListItem>
                        <asp:ListItem>Date and Male and AgeGrp</asp:ListItem>
                        <asp:ListItem>Date and AgeGrp and District</asp:ListItem>
                        <asp:ListItem>Date and AgeGrp and City</asp:ListItem>
                        <asp:ListItem>Date and People and District</asp:ListItem>
                        <asp:ListItem>Date and Female and District</asp:ListItem>
                        <asp:ListItem>Date and Male and District</asp:ListItem>
                        <asp:ListItem>Date and People and City</asp:ListItem>
                        <asp:ListItem>Date and Female and City</asp:ListItem>
                        <asp:ListItem>Date and Male and City</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btn_Of3_Ok" runat="server" Text="Ok" OnClick="btn_Of3_Ok_Click" />
                    &nbsp;<asp:DropDownList ID="dropdownlist_AgeGrp_Of3" runat="server" Visible="False">
                        <asp:ListItem>1-4</asp:ListItem>
                        <asp:ListItem>5-14</asp:ListItem>
                        <asp:ListItem>15-19</asp:ListItem>
                        <asp:ListItem>20-29</asp:ListItem>
                        <asp:ListItem>30-39</asp:ListItem>
                        <asp:ListItem>40-49</asp:ListItem>
                        <asp:ListItem>50-59</asp:ListItem>
                        <asp:ListItem>60-64</asp:ListItem>
                        <asp:ListItem>&gt;=65</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnOk_AgeGrp_Of3" runat="server" Text="Ok" Visible="False" OnClick="btnOk_AgeGrp_Of3_Click" />
                    &nbsp;<asp:DropDownList ID="dropdownlist_District_Of3" runat="server" Visible="False">
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnOk_District_Of3" runat="server" Text="Ok" Visible="False" OnClick="btnOk_District_Of3_Click" />
                    &nbsp;<asp:DropDownList ID="dropdownlist_City_Of3" runat="server" Visible="False">
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnOk_City_Of3" runat="server" Text="Ok" Visible="False" OnClick="btnOk_City_Of3_Click" />
                </td>
            </tr>
            <tr>
                <td style="margin-left: 40px" colspan="2">
                    <asp:Chart ID="Chart2" runat="server" Height="250px" Width="950px">
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1">
                            </asp:ChartArea>
                        </ChartAreas>
                        <Legends>
                            <asp:Legend Name="Legend1">
                            </asp:Legend>
                        </Legends>
                    </asp:Chart>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 40px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 40px; color: #FF3300;">
                    <asp:Label ID="Label5" runat="server" Text="Analyse on" style="color: #000000"></asp:Label>
                    <asp:Literal ID="ltrMessage_Of4" runat="server"></asp:Literal>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 40px" colspan="2">
                    <asp:DropDownList ID="dropdownlist_Of4" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Date and Disease and People and AgeGrp</asp:ListItem>
                        <asp:ListItem>Date and Disease and Female and AgeGrp</asp:ListItem>
                        <asp:ListItem>Date and Disease and Male and AgeGrp</asp:ListItem>
                        <asp:ListItem>Date and Disease and District and AgeGrp</asp:ListItem>
                        <asp:ListItem>Date and Disease and City and AgeGrp</asp:ListItem>
                        <asp:ListItem>Date and Disease and People and District</asp:ListItem>
                        <asp:ListItem>Date and Disease and Female and District</asp:ListItem>
                        <asp:ListItem>Date and Disease and Male and District</asp:ListItem>
                        <asp:ListItem>Date and Disease and People and City</asp:ListItem>
                        <asp:ListItem>Date and Disease and Female and City</asp:ListItem>
                        <asp:ListItem>Date and Disease and Male and City</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btn_Of4_Ok" runat="server" Text="Ok" OnClick="btn_Of4_Ok_Click" />
                    &nbsp;<asp:DropDownList ID="dropdownlist_AgeGrp_Of4" runat="server" Visible="False">
                        <asp:ListItem>1-4</asp:ListItem>
                        <asp:ListItem>5-14</asp:ListItem>
                        <asp:ListItem>15-19</asp:ListItem>
                        <asp:ListItem>20-29</asp:ListItem>
                        <asp:ListItem>30-39</asp:ListItem>
                        <asp:ListItem>40-49</asp:ListItem>
                        <asp:ListItem>50-59</asp:ListItem>
                        <asp:ListItem>60-64</asp:ListItem>
                        <asp:ListItem>&gt;=65</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnOk_AgeGrp_Of4" runat="server" Text="Ok" Visible="False" OnClick="btnOk_AgeGrp_Of4_Click" />
                    &nbsp;<asp:DropDownList ID="dropdownlist_District_Of4" runat="server" Visible="False">
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnOk_District_Of4" runat="server" Text="Ok" Visible="False" OnClick="btnOk_District_Of4_Click" />
                    &nbsp;<asp:DropDownList ID="dropdownlist_City_Of4" runat="server" Visible="False">
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnOk_City_Of4" runat="server" Text="Ok" Visible="False" OnClick="btnOk_City_Of4_Click" />
                </td>
            </tr>
            <tr>
                <td style="margin-left: 40px" colspan="2">
                    <asp:Chart ID="Chart3" runat="server" Height="250px" Width="950px">
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1">
                            </asp:ChartArea>
                        </ChartAreas>
                        <Legends>
                            <asp:Legend Name="Legend1">
                            </asp:Legend>
                        </Legends>
                    </asp:Chart>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 40px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 40px; color: #FF3300;">
                    <asp:Label ID="Label6" runat="server" Text="Analyse on" style="color: #000000"></asp:Label>
                    <asp:Literal ID="ltrMessage_Of5" runat="server"></asp:Literal>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="margin-left: 40px" colspan="2">
                    <asp:DropDownList ID="dropdownlist_Of5" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Date and Disease and People and AgeGrp and District</asp:ListItem>
                        <asp:ListItem>Date and Disease and Female and AgeGrp and District</asp:ListItem>
                        <asp:ListItem>Date and Disease and Male and AgeGrp and District</asp:ListItem>
                        <asp:ListItem>Date and Disease and People and AgeGrp and City</asp:ListItem>
                        <asp:ListItem>Date and Disease and Female and AgeGrp and City</asp:ListItem>
                        <asp:ListItem>Date and Disease and Male and AgeGrp and City</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btn_Of5_Ok" runat="server" Text="Ok" OnClick="btn_Of5_Ok_Click" />
                    &nbsp;<asp:DropDownList ID="dropdownlist_AgeGrp_Of5" runat="server" Visible="False">
                        <asp:ListItem>1-4</asp:ListItem>
                        <asp:ListItem>5-14</asp:ListItem>
                        <asp:ListItem>15-19</asp:ListItem>
                        <asp:ListItem>20-29</asp:ListItem>
                        <asp:ListItem>30-39</asp:ListItem>
                        <asp:ListItem>40-49</asp:ListItem>
                        <asp:ListItem>50-59</asp:ListItem>
                        <asp:ListItem>60-64</asp:ListItem>
                        <asp:ListItem>&gt;=65</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnOk_AgeGrp_Of5" runat="server" Text="Ok" Visible="False" OnClick="btnOk_AgeGrp_Of5_Click" />
                    &nbsp;<asp:DropDownList ID="dropdownlist_District_Of5" runat="server" Visible="False">
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnOk_District_Of5" runat="server" Text="Ok" Visible="False" OnClick="btnOk_District_Of5_Click" />
                    &nbsp;<asp:DropDownList ID="dropdownlist_City_Of5" runat="server" Visible="False">
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnOk_City_Of5" runat="server" Text="Ok" Visible="False" OnClick="btnOk_City_Of5_Click" />
                </td>
            </tr>
            <tr>
                <td style="margin-left: 40px" colspan="2">
                    <asp:Chart ID="Chart4" runat="server" Height="250px" Width="950px">
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1">
                            </asp:ChartArea>
                        </ChartAreas>
                        <Legends>
                            <asp:Legend Name="Legend1">
                            </asp:Legend>
                        </Legends>
                    </asp:Chart>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 40px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        
    </asp:Panel>
</asp:Content>


