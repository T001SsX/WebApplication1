<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iframe.aspx.cs" Inherits="WebApplication1.iframe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--iframe-->
            <iframe src="iframe.html" height="400" width="400" name="iframe" id="iframe1" frameborder="0">

            </iframe>
        </div>
        <div>
            <iframe src="iframe.html" height="400" width="400"  frameborder="1" border="1">

            </iframe>
        </div>

    </form>
</body>
</html>
