<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="fpassword.aspx.cs" Inherits="r_s_hotel.fpassword" %>
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
                                           <asp:TextBox ID="password" class="form-control" placeholder="Your Password" runat="server" TextMode="Password"></asp:TextBox>
                                            <asp:Label runat="server" for="password" AssociatedControlID="password">Enter Your Password</asp:Label>
                                            <!--<label for="password">Your Password</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="password" ErrorMessage="password must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>

                                    <div class="col-12">
                                        <div class="form-floating">
                                            <!--<input type="password" class="form-control" id="password" placeholder="Subject">-->
                                            <asp:TextBox ID="cpassword" class="form-control" placeholder="Your Password" runat="server" TextMode="Password"></asp:TextBox>
                                            <asp:Label runat="server" for="cpassword" AssociatedControlID="cpassword">Enter Your Password</asp:Label>
                                            <!--<label for="password">Your Password</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="cpassword" ErrorMessage="password must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <asp:CheckBox runat="server" ID="chkShowPassword" Text="Show Password" onchange="togglePassword();" />
                                  
                                    <div class="col-12">
                                        <asp:Button ID="Button1" runat="server" Text="Login"  class="btn btn-primary w-100 py-3" OnClick="Button1_Click" />
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
