<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="UniverSityManagementApp.Students" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div><h2 style="text-align:center">Students</h2></div>

    <asp:GridView ID="gridStudents" runat="server" AutoGenerateColumns="False" CellPadding="15" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />

        <Columns>
            <asp:TemplateField HeaderText="Student ID">
                <ItemTemplate>
                    <%#Eval(expression:"StudentId") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Register No">
                <ItemTemplate>
                    <%#Eval(expression:"RegNo") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Student Name">
                <ItemTemplate>
                    <%#Eval(expression:"Name") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Email">
                <ItemTemplate>
                    <%#Eval(expression:"Email") %>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Phone Number">
                <ItemTemplate>
                    <%#Eval(expression:"Phone") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
