﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainUI.aspx.cs" Inherits="ASP.NET_MVC_WebApp_SimpleLibraryManagement.MainUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Height="20px" Text="Borrow Book UI" Width="122px"></asp:Label>
        <br />
        <br />
        <asp:Label ID="numberLabel" runat="server" Text="Enter Member No"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="numberTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <br />
&nbsp;
        <asp:Label ID="selectedBookLabel" runat="server" Text="Book"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="selectBookDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="selectBookDropDownList_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
&nbsp;
        <asp:Label ID="authorLabel" runat="server" Text="Author"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:Label ID="publisherLabel" runat="server" Text="Publisher"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="publisherTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="borrowButton" runat="server" OnClick="borrowButton_Click" Text="Borrow" />
        <br />
        <br />
        <asp:Label ID="messageLabel" runat="server" Text="Show Message"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Return Book UI"></asp:Label>
        <br />
        <br />
        <asp:Label ID="numberLabel0" runat="server" Text="Enter Member No"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="memberNumberTextBox0" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="showSelectedNumBooksButton" runat="server" OnClick="showSelectedNumBooksButton_Click" Text="Show Borrowed Books" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Borrowed Booklist"></asp:Label>
&nbsp;&nbsp;
        <asp:DropDownList ID="borrowedBookListDropDownList" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="returnButton" runat="server" OnClick="returnButton_Click" Text="Return" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>