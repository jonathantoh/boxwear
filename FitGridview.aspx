<%@ Page Title="" Language="C#" MasterPageFile="~/site.master" AutoEventWireup="true" CodeFile="FitGridview.aspx.cs" Inherits="FitGridview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">





</asp:Content>





<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:GridView ID="gvsize" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False" DataKeyNames="height">
       <%-- Theme Properties --%>
         <Columns>
             <asp:BoundField DataField="height" HeaderText="height" ReadOnly="True" SortExpression="height" >
             <ControlStyle Height="20px" Width="20px" />
             </asp:BoundField>
             <asp:BoundField DataField="weight" HeaderText="weight" SortExpression="weight" >
             <ControlStyle Height="20px" Width="20px" />
             </asp:BoundField>
             <asp:BoundField DataField="topsize" HeaderText="topsize" SortExpression="topsize" />
             <asp:BoundField DataField="bottomsize" HeaderText="bottomsize" SortExpression="bottomsize" />
             <asp:BoundField DataField="footlength" HeaderText="footlength" SortExpression="footlength" />
                
                <asp:CommandField ShowEditButton="True" />
                
                </Columns>
         
       
        
        
         <EmptyDataTemplate>
             <asp:ImageButton ID="ImageButton1" runat="server" Height="16px" Width="16px" />
             <asp:ImageButton ID="ImageButton2" runat="server" />
        </EmptyDataTemplate>
         
       
        
        
         <FooterStyle BackColor="White" ForeColor="#000066" height="20px" Width="20px"/>
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" height="20px" Width="20px"/>
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" height="20px" Width="20px"/>
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" height="20px" Width="20px"/>
        <SortedAscendingCellStyle BackColor="#F1F1F1" height="20px" Width="20px"/>
        <SortedAscendingHeaderStyle BackColor="#007DBB" height="20px" Width="20px"/>
        <SortedDescendingCellStyle BackColor="#CAC9C9" height="20px" Width="20px"/>
        <SortedDescendingHeaderStyle BackColor="#00547E" height="20px" Width="20px"/>


       



    </asp:GridView>
    </asp:Content>




