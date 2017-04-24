﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="InventoryManagementSystemApp.UI.Index" %>

<!DOCTYPE html>
<html>
<head>
<title>Page Title</title>
    <style type="text/css">
        .auto-style3 {
            width: 217px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style3" >
                    <asp:Label ID="Label5" runat="server" Text="Category"></asp:Label></td>
              
                  <td>
                      <asp:DropDownList ID="categoryDropDownList" runat="server"></asp:DropDownList> 
                  </td>
                
            </tr>
            <tr>
                <td class="auto-style3" >
                    <asp:Label ID="Label1" runat="server" Text="Product Code"></asp:Label></td>
                <td>
                    <asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox></td>
                <asp:HiddenField ID="productHiddenField" runat="server" />
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Product Name"></asp:Label></td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
              
            </tr>
            <tr>
                <td class="auto-style3" >
                    <asp:Label ID="Label3" runat="server" Text="Unit Price"></asp:Label></td>
                <td>
                    <asp:TextBox ID="unitPriceTextBox" runat="server"></asp:TextBox></td>
               
            </tr>
            <tr>
                <td class="auto-style3" >
                    <asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label></td>
                <td>
                    <asp:TextBox ID="quantityTextBox" runat="server"></asp:TextBox></td>
               
            </tr>
            <tr>
                <td class="auto-style3" >
                    <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" /> 
                </td>
                <td >
                    <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" /> 
                </td>
                 
            </tr>
            <tr>
               <td class="auto-style3" >
                    <asp:Label ID="msgLabel" runat="server" Text="message"></asp:Label></td>
            </tr>
        </table>
    </div>
        <asp:GridView ID="productGridView" runat="server" Width="357px" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="Product Code">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="Code" Text='<%# Eval("Code") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Product Name">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="Name" Text='<%# Eval("Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Unit Price">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="UnitPrice" Text='<%# Eval("UnitPrice") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="Quantity" Text='<%# Eval("Quantity") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Total Price">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="TotalPrice" Text='<%# Eval("TotalPrice") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:HyperLink runat="server" NavigateUrl='<%#string.Format("Index.aspx?ProductCode={0}",Eval("Code")) %>' >Edit</asp:HyperLink>
                        </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
