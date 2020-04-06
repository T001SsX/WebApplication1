<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            编号<asp:TextBox ID="textID" runat="server"></asp:TextBox>
        </div>
        <div>
            电子邮件:<asp:TextBox ID="textEmail" runat="server"></asp:TextBox>
        </div>
        <div>
            密&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;码:
            <asp:TextBox ID="textPassword" runat="server"></asp:TextBox>
        </div>
        <div>
            昵&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;称:
            <asp:TextBox ID="textNickName" runat="server"></asp:TextBox>
        </div>
        <div>
            上传头像:<asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnSubmit" runat="server" Text="修改"  OnClick="btnSubmit_Click" />
            <asp:Button ID="btnReset" runat="server" Text="重置" OnClick="btnReset_Click"/>
        </div>
    </form>


</body>
</html>
