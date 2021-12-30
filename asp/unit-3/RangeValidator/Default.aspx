<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        RangeValidator: ErrorMessage | Text | ControlToValidate | MaximumValue | 
        MinimumValue | Type<br />
        <br />
        <asp:Literal ID="Literal1" runat="server" Text="Age"></asp:Literal>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="TextBox1" ErrorMessage="Enter Age Between 1 to 60" 
            ForeColor="Red" MaximumValue="60" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        &nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="TextBox1" ErrorMessage="Enter Age" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Literal ID="Literal3" runat="server" Text="Date"></asp:Literal>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RangeValidator ID="RangeValidator2" runat="server" 
            ControlToValidate="TextBox2" 
            ErrorMessage="Enter Date between 01/12/2021 to 31/12/2021" ForeColor="Red" 
            MaximumValue="31/12/2021" MinimumValue="1/12/2021" Type="Date"></asp:RangeValidator>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="Enter Date" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <asp:Literal ID="Literal2" runat="server"></asp:Literal>
    
    </div>
    </form>
</body>
</html>
