<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td align="center">
                    DataList Control</td>
            </tr>
            <tr>
                <td>
                    <asp:DataList ID="DataList1" runat="server" BackColor="LightGoldenrodYellow" 
                        BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
                        RepeatColumns="3" RepeatDirection="Horizontal">
                        <AlternatingItemStyle BackColor="PaleGoldenrod" />
                        <FooterStyle BackColor="Tan" />
                        <HeaderStyle BackColor="Tan" Font-Bold="True" />
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
                        <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                    </asp:DataList>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
