<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChatRoom.aspx.cs" Inherits="WebApplication2.ChatRoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="label_count" runat="server" Text="Label"></asp:Label>
        <div>
        </div>
        <asp:ListBox ID="listbox_usernames" runat="server" Height="296px" style="margin-top: 0px" Width="500px"></asp:ListBox>
&nbsp;<asp:TextBox ID="textbox_records" runat="server" Height="290px" Width="327px" style="margin-top: 19px"></asp:TextBox>
        <br />
        <asp:TextBox ID="textbox_sendmsg" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="发送" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="退出" />
    </form>
</body>
</html>
