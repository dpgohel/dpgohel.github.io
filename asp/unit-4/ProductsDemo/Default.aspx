<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 100%;">
            <tr>
                <td align="center">
                    &nbsp;</td>
                <td align="center">
                    Dashboard</td>
                <td align="center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="Dashboard" />
                </td>
                <td align="center">
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                        Text="Categories" />
                </td>
                <td align="center">
                    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                        Text="Products" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
