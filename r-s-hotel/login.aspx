<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="r_s_restaurent.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container-xxl py-5">
            <div class="container">
                <div class="text-center wow fadeInUp" data-wow-delay="0.1s">
                    <h6 class="section-title text-center text-primary text-uppercase">Login Now</h6>
                    <h1 class="mb-5"><span class="text-primary text-uppercase">Login</span></h1>
                </div>
                <div class="row g-4" style="display: flex; justify-content:center">
                    <div class="col-md-6">
                        <div class="wow fadeInUp" data-wow-delay="0.2s">
                            <!--<form>-->
                                <div class="row g-3">
                                    <div class="col-md-12">
                                        <div class="form-floating">
                                            <!--<input type="email" class="form-control" id="email" placeholder="Your Email">-->
                                            <asp:TextBox ID="email" runat="server" class="form-control" placeholder="Your Email" TextMode="Email"></asp:TextBox>
                                            <asp:Label runat="server" for="email" AssociatedControlID="email">Enter Your Email</asp:Label>
                                            <!--<label for="email">Your Email</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="email" ErrorMessage="email must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>

                                    <div class="col-12">
                                        <div class="form-floating">
                                            <!--<input type="password" class="form-control" id="password" placeholder="Subject">-->
                                            <asp:TextBox ID="password" class="form-control" placeholder="Your Password" runat="server" TextMode="Password"></asp:TextBox>
                                            <asp:Label runat="server" for="password" AssociatedControlID="password">Enter Your Password</asp:Label>
                                            <!--<label for="password">Your Password</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password" ErrorMessage="password must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <asp:CheckBox runat="server" ID="chkShowPassword" Text="Show Password" onchange="togglePassword();" />
                                    <div class="col-12" style="display:flex; justify-content:space-between">
                                        <div class="form-floating">
                                           <a href="newUser.aspx">New User?</a>
                                        </div>
                                        <div class="form-floating">
                                           <a href="#">forgot password</a>
                                        </div>
                                    </div>
                                    <div class="col-12">
                                        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="login_click" class="btn btn-primary w-100 py-3" />
                                    </div>
                                </div>
                           <!-- </form> -->
                            
                            <br /><br/><br /><br/><br />
                        </div>
                    </div>
                </div>
            </div>
        </div>

    <script>
            function togglePassword() {
                var passwordField = document.getElementById('<%= password.ClientID %>');
                var checkBox = document.getElementById('<%= chkShowPassword.ClientID %>');

                // Change the type of the password field based on the checkbox state
                passwordField.type = checkBox.checked ? 'text' : 'password';
            }
    </script>
        
</asp:Content>
