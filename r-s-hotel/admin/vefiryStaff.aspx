<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vefiryStaff.aspx.cs" Inherits="r_s_hotel.admin.vefiryStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     
    <style>
        body {
            background-color: #f0f0f0;
        }
        
        #form1 {
            font-family: Arial, sans-serif;
            margin: 0 auto;
            width: 300px;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            background-color: white;
            border-radius: 10px;
            margin-top: 150px;
        }

        #TextBox1 {
            width: 100%;
            padding: 8px;
            margin-bottom: 20px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        #Button1 {
            width: 100%;
            padding: 10px;
            background-color: #007bff;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        #Button1:hover {
            background-color: #0056b3;
        }

        #Label1 {
            display: block;
            margin-top: 20px;
            font-size: 16px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          
            <h1 style="display:flex; align-self:center; justify-content:center;">Enter OTP</h1>
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        
        </div>
    </form>
</body>
</html>
