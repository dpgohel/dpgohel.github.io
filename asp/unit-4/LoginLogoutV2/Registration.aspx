<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- bootstrap-css -->
    <link rel="stylesheet" href="src/css/bootstrap.min.css" >
    <!-- //bootstrap-css -->
    <!-- Custom CSS -->
    <link href="src/css/style.css" rel='stylesheet' type='text/css' />
    <link href="src/css/style-responsive.css" rel="stylesheet"/>
    <!-- font CSS -->
    <link href='//fonts.googleapis.com/css?family=Roboto:400,100,100italic,300,300italic,400italic,500,500italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'>
    <!-- font-awesome icons -->
    <link rel="stylesheet" href="src/css/font.css" type="text/css"/>
    <link href="src/css/font-awesome.css" rel="stylesheet"> 
    <!-- //font-awesome icons -->
    <script src="src/js/jquery2.0.3.min.js"></script>
</head>
<body>
    <div class="reg-w3">
        <div class="w3layouts-main">
	        <h2>Register Now</h2>
		        <form id="form1" runat="server">
                    <asp:TextBox ID="TextBox1" runat="server" class="ggg" placeholder="NAME"></asp:TextBox>
                    <asp:TextBox ID="TextBox2" runat="server" class="ggg" placeholder="E-MAIL"></asp:TextBox>
                    <asp:TextBox ID="TextBox3" runat="server" class="ggg" placeholder="PASSWORD" 
                        TextMode="Password"></asp:TextBox>
                    <asp:TextBox ID="TextBox4" runat="server" class="ggg" 
                        placeholder="CONFIRM PASSWORD" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" class="ggg" runat="server" 
                        ErrorMessage="Password and Confirm Password does not match." 
                        ControlToCompare="TextBox3" ControlToValidate="TextBox4" ForeColor="Red" 
                        Display="Dynamic"></asp:CompareValidator>
                    <div class="clearfix"></div>
			        <h4><input type="checkbox" />I agree to the Terms of Service and Privacy Policy</h4>
				    <div class="clearfix"></div>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                    <div class="clearfix"></div>
                    <asp:Button ID="Button1" runat="server" Text="Register" 
                        onclick="Button1_Click" />
		        </form>
		        <p>Already Registered.<a href="Login.aspx">Login</a></p>
        </div>
    </div>
    <script src="src/js/bootstrap.js"></script>
    <script src="src/js/jquery.dcjqaccordion.2.7.js"></script>
    <script src="src/js/scripts.js"></script>
    <script src="src/js/jquery.slimscroll.js"></script>
    <script src="src/js/jquery.nicescroll.js"></script>
    <!--[if lte IE 8]><script language="javascript" type="text/javascript" src="src/js/flot-chart/excanvas.min.js"></script><![endif]-->
    <script src="src/js/jquery.scrollTo.js"></script>
</body>
</html>
