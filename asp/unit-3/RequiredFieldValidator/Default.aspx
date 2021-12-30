<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        RequiredFieldValidator: 
        ErrorMessage | Text | ControlToValidate | InitialValue<br />
        <br />
        Page Properties: IsValidd<br />
        <br />
        <asp:Literal ID="Literal1" runat="server" Text="Name"></asp:Literal>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox1" ErrorMessage="Enter Name" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Literal ID="Literal2" runat="server" Text="City"></asp:Literal>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="-1">Select City</asp:ListItem>
            <asp:ListItem Value="0">Rajkot</asp:ListItem>
            <asp:ListItem Value="1">Gondal</asp:ListItem>
            <asp:ListItem Value="2">Jetpur</asp:ListItem>
            <asp:ListItem Value="3">Morbi</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="DropDownList1" ErrorMessage="Select City" ForeColor="Red" 
            InitialValue="-1"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <asp:Literal ID="Literal3" runat="server"></asp:Literal>
    
    </div>
    </form>
</body>
</html>
