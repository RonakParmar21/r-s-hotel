<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="r_s_hotel.admin.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
  font-family: "Comic Sans MS", cursive;
  margin: 0;
  display: flex;
  align-items: center;
  justify-content: center;
  min-height: 100vh;
  background: #fafafa; /* Warna latar belakang abu-abu muda */
  color: #333;
}

.container {
  width: 100%;
  max-width: 400px;
}

.card {
  width: 100%;
  background-color: #f8f8f8; /* Warna card */
  padding: 20px;
  border-radius: 12px; /* Border radius card */
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}

h2 {
  text-align: center;
  color: #333;
}

form {
  display: flex;
  flex-direction: column;
}

input {
  padding: 10px;
  margin-bottom: 12px;
  border: 2px solid #ddd; /* Border color input */
  border-radius: 8px; /* Border radius input */
  transition: border-color 0.3s ease-in-out;
  outline: none;
  color: #333;
  background-color: #f4f4f4; /* Warna input */
}

input:focus {
  border-color: #ff9900; /* Warna input saat focus */
}

button {
  background-color: #ff9900; /* Warna button */
  color: #fff;
  padding: 10px;
  border: none;
  border-radius: 8px; /* Border radius button */
  cursor: pointer;
  transition: background-color 0.3s ease-in-out;
}

button:hover {
  background-color: #ff6600; /* Warna button saat hover */
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="container">
  <div class="card">
    <h2>Login</h2>

      <asp:TextBox ID="email" runat="server" class="form-control" placeholder="Your Email" TextMode="Email"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="email" ErrorMessage="email must be required" ForeColor="Red"></asp:RequiredFieldValidator>

      <asp:TextBox ID="password" class="form-control" placeholder="Your Password" runat="server" TextMode="Password"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password" ErrorMessage="password must be required" ForeColor="Red"></asp:RequiredFieldValidator>
 
      <asp:Button ID="Button1" runat="server" Text="Login" class="btn btn-primary w-100 py-3" OnClick="Button1_Click" />
     <!-- <input type="text" id="username" name="username" placeholder="Username" required>
      <input type="password" id="password" name="password" placeholder="Password" required>
      <button type="submit">Login</button>-->
 
  </div>
</div>
        </div>
    </form>
</body>
</html>
