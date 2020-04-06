<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsersManager.aspx.cs" Inherits="WebApplication1.UsersManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div> 
           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="170px" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="序号" />
                    <asp:BoundField DataField="Email" HeaderText="邮箱" />
                    <asp:BoundField DataField="Nickname" HeaderText="昵称" />
                    <asp:BoundField DataField="Photo" HeaderText="图片" />
                    <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
                    <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="index.aspx?Id={0}" HeaderText="编辑" Text="修改" />
                </Columns>
            </asp:GridView>
          
        </div>
    </form>

</body>
</html>
