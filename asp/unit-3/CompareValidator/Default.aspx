<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Compare Validator: Error Message or Text | ForeColor | ControlToValidate | 
        ControlToComapare | ValueToCompare | Display | Operator | Type | SetFocush<br />
        <br />
        TextBox Property: TextMode<br />
        <br />
        <asp:Literal ID="Literal1" runat="server" Text="Password"></asp:Literal>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Enter password" 
            ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Literal ID="Literal2" runat="server" Text="Retype Password"></asp:Literal>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="TextBox1" ControlToValidate="TextBox2" Display="Dynamic" 
            ErrorMessage="Password does not match." ForeColor="Red"></asp:CompareValidator>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="TextBox2" Display="Dynamic" 
            ErrorMessage="Enter retype password" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Literal ID="Literal3" runat="server" Text="Age"></asp:Literal>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:CompareValidator ID="CompareValidator2" runat="server" 
            ControlToValidate="TextBox3" Display="Dynamic" 
            ErrorMessage="Enter age in numeric digit" ForeColor="Red" 
            Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="Enter age" 
            ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Literal ID="Literal4" runat="server" Text="Date"></asp:Literal>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:CompareValidator ID="CompareValidator3" runat="server" 
            ControlToValidate="TextBox4" Display="Dynamic" 
            ErrorMessage="Fill the form before 31/12/2021" ForeColor="Red" 
            Operator="LessThanEqual" SetFocusOnError="True" Type="Date" 
            ValueToCompare="31/12/2021"></asp:CompareValidator>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Enter Date" 
            ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <asp:Literal ID="Literal5" runat="server"></asp:Literal>
    
    </div>
    </form>
</body>
</html>
