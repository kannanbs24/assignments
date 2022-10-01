<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="producs.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
         <asp:Label ID="lblProductid" runat="server" Text="Enter Product ID" BackColor="White"></asp:Label>
        <asp:TextBox ID="txtprodid" runat="server" BorderColor="#CC9900"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtprodid" ErrorMessage="enter product id" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblProdname" runat="server" Text="Enter Product Name"></asp:Label>
        <asp:TextBox ID="txtprodname" runat="server" BorderColor="#CC9900"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtprodname" ErrorMessage="enter product name" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblprice" runat="server" Text="Enter Price"></asp:Label>
        <asp:TextBox ID="txtprice" runat="server" BorderColor="#CCCC00"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtprice" ErrorMessage="enter price" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Cookies" />
       
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="insert" />
        <asp:Label ID="lbl" runat="server" Text="status"></asp:Label>
       
        <br />
        <asp:Label ID="Label1" runat="server" Text="add cookies in the list" BackColor="Yellow" BorderColor="#CC0000"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" BackColor="#66CCFF" Height="430px" Width="397px"></asp:ListBox>



    </form>
</body>
</html>
