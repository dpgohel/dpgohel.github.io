<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:21%;" border="1">
            <tr>
                <td align="center">
                    Repeter Control</td>
            </tr>
            <tr>
                <td>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <table style="width:100%;">
                                <tr>
                                    <td align="center">
                                        <asp:Image ID="Image1" runat="server" Height="100px" 
                                            ImageUrl='<%# Eval("image", "~/uploads/{0}") %>' Width="100px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        Name:
                                        <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("name") %>'></asp:Literal>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        Price:
                                        <asp:Literal ID="Literal2" runat="server" Text='<%# Eval("price") %>'></asp:Literal>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:Repeater>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
