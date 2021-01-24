<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FloraSoft.Login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title> Please login</title>
    <link href= "includes/sitec.css" type="text/css" rel="stylesheet"/>
</head>
<body  >
    <form id="form1" method="post"  runat="server" defaultbutton="LoginBtn" defaultfocus="UserName">
            <br>
            <br>
			<br>
			<br>
			<br>
    <center>
     <table cellpadding="0" cellspacing="0" border="0"
            style="BACKGROUND-IMAGE: url(Images/ABCBankLogin.gif);" >
					<tr height="155">
						<td width="170"></td>
						<td width="130"></td>
						<td width="110"></td>
					</tr>
					<tr height="20">
						<td></td>
						<td><asp:TextBox id="UserName"  Text=""  CssClass="inputlt" Columns="9"  width="130"  runat="server" /></td>
						<td>
						    <asp:RequiredFieldValidator id="RequiredFieldValidator1" 
						    runat="server" ControlToValidate="UserName" 
						    CssClass="NormalRed" 
                            ErrorMessage="*" Display="dynamic">
                            </asp:RequiredFieldValidator>
                         </td>
					</tr>
					<tr height="20">
						<td></td>
						<td><asp:TextBox id="Pass" Text="" width="130" Columns="19"  CssClass="inputlt"  textmode="Password" runat="server" /></td>
						<td>
						    <asp:RequiredFieldValidator id="RequiredFieldValidator2" 
						    runat="server" ControlToValidate="Pass" 
						    CssClass="NormalRed"  
                            ErrorMessage="*" Display="dynamic">
                            </asp:RequiredFieldValidator>
                        </td>
					</tr>
					<tr height="33">
						<td></td>
						<td align ="right" valign="bottom"><asp:LinkButton ID="LoginBtn" CssClass="CommandButton" Runat="server" Text="Sign In " Width="80" OnClick="Login_Click" ></asp:LinkButton></td>
						<td></td>
					</tr>
					<tr height="30">
					    <td></td>
                        <td colspan="3"><asp:Label ID="MyMessage" ForeColor="Red" CssClass ="NormalRed" runat="server"></asp:Label></td>
                        <td></td>
                    </tr>
    </table>
    <asp:HiddenField ID="Tried" Value="" runat="server" />
    </center>
    </form>
</body>
</html>
