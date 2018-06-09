<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    
        <h1>Customer Registration</h1>
        NAME&nbsp;
        <asp:TextBox ID="tb_CustName" runat="server" Width="266px"></asp:TextBox>
        <br />
        <br />
        NRIC&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tb_NRIC" runat="server" Width="163px"></asp:TextBox>
        <br />
        <br />
        HP&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_Hp" runat="server" Width="183px"></asp:TextBox>
        <br />
        <br />
        EMAIL
        <asp:TextBox ID="tb_Email" runat="server" Width="262px" AutoCompleteType="JobTitle"></asp:TextBox>
        <br />
        <asp:Panel ID="Panel1" runat="server" GroupingText="GENDER" Width="350px">
            <asp:RadioButtonList ID="rbl_Gender" runat="server" Width="186px">
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" GroupingText="NOTIFICATIONS" Width="351px">
            Send product updates and promotion info to :<asp:CheckBoxList ID="cbl_Notifications" runat="server" Width="120px">
                <asp:ListItem>HP</asp:ListItem>
                <asp:ListItem>EMAIL</asp:ListItem>
            </asp:CheckBoxList>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" GroupingText="BIRTHDAY MONTH" Width="352px">
            <asp:DropDownList ID="ddl_BirthdayMonth" runat="server">
                <asp:ListItem>Jan</asp:ListItem>
                <asp:ListItem>Feb</asp:ListItem>
                <asp:ListItem>Mar</asp:ListItem>
                <asp:ListItem>Apr</asp:ListItem>
                <asp:ListItem>May</asp:ListItem>
                <asp:ListItem>Jun</asp:ListItem>
            </asp:DropDownList>
        </asp:Panel>
        <br />
        <br />
        <asp:Button ID="btn_Submit" runat="server" Text="Submit" Width="160px" />
    
    </div>


</asp:Content>