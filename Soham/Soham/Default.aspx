<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Soham.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-6 contact-form">
						<h4 class="white-w3ls">Contact <span>Form</span></h4>
						<div>
							<div class="styled-input agile-styled-input-top">
								<asp:TextBox ID="txtname" runat="server"></asp:TextBox>
								
								<label>Name</label>
								<span></span>
							</div>
							<div class="styled-input">
								<asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
								
								<label>Email</label>
								<span></span>
							</div> 
							<div class="styled-input">
								<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
								
								<label>phone</label>
								<span></span>
							</div>

							<%--<div class="styled-input">
								<asp:TextBox ID="TextMobile" runat="server"></asp:TextBox>
								<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"  
ControlToValidate="TextMobile" ErrorMessage="RegularExpressionValidator"  
ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator> 
								<label>Mobile</label>
								<span></span>
							</div>--%>
							
							<asp:Button ID="BtnContact" runat="server" Text="SEND" OnClick="BtnContact_Click"/>
							
						</div>
					</div>
    </form>
</body>
</html>
