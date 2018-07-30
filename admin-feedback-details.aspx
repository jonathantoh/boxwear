<%@ Page Title="" Language="C#" MasterPageFile="~/site-admin.master" AutoEventWireup="true" CodeFile="admin-feedback-details.aspx.cs" Inherits="admin_feedback_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     </h1>Feedback Details<table class="nav-justified">
        <tr>
            <td>
                <asp:Label ID="lbl_FName" runat="server" Text="Label"></asp:Label>
                &nbsp
                <asp:Label ID="lbl_LName" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbl_Email" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl_OrderNo" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl_Message" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

