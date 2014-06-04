<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>ZapierTokenRequest</title>
</head>
<body>
    <div>
        <%: ViewData["client_id"] %><br />
        <%: ViewData["code"] %>
    </div>
</body>
</html>
