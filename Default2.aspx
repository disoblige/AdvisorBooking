<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>
    <%@ Register TagPrefix="uc1" TagName="ctlCalendar" Src="UserControls/ctlCalendar.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
	<uc1:ctlCalendar id="ctlCalendar" runat="server"></uc1:ctlCalendar>
    </div>
    </form>
</body>
</html>
