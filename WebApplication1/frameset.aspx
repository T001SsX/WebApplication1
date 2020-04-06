<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frameset.aspx.cs" Inherits="WebApplication1.frameset" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <frameset cols="25%,50%,25%">
            <frame src="frame_a.htm" />
            <frame src="frame_b.htm" />
            <frame src="frame_c.htm" />
        </frameset>
        </div>
    </form>
</body>
</html>
