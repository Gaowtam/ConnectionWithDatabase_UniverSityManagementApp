<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="UniverSityManagementApp.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblID" runat="server" Text="ID : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblRegNo" runat="server" Text="Reg No : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtRegNo" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="Name : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Email : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPhone" runat="server" Text="Phone : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <strong>
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </strong>
        <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="Show" style="height: 29px" />
    </form>
    <asp:Label ID="lblShow" runat="server" Text=""></asp:Label>
</asp:Content>
