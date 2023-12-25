<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="newUser.aspx.cs" Inherits="r_s_hotel.newUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-xxl py-5">
            <div class="container">
                <div class="text-center wow fadeInUp" data-wow-delay="0.1s">
                    <!--<h6 class="section-title text-center text-primary text-uppercase">Register Now</h6>-->
                    <h1 class="mb-5"><span class="text-primary text-uppercase">Registration</span></h1>
                </div>
                <div class="text-center wow fadeInUp pb-2" data-wow-delay="0.1s">
                    <h6 class="section-title text-center text-primary text-uppercase">personal details</h6>
                </div>
                <div class="row g-4" style="display: flex; justify-content:center">
                    <div class="col-md-6">
                        <div class="wow fadeInUp" data-wow-delay="0.2s">
                                <div class="row g-3">
                                    <div class="col-md-6">
                                        <div class="form-floating">
                                            <asp:TextBox ID="name" runat="server" class="form-control" placeholder="Your Name"></asp:TextBox>
                                            <!--<input type="email" class="form-control" id="email" placeholder="Your Email">-->
                                            <asp:Label runat="server" for="name" AssociatedControlID="name">Enter Your Name</asp:Label>
                                            <!--<label for="email">Your Email</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="name" ErrorMessage="name must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-floating">
                                            <asp:TextBox ID="email" runat="server" class="form-control" placeholder="Your Email" TextMode="Email"></asp:TextBox>
                                            <!--<input type="email" class="form-control" id="email" placeholder="Your Email">-->
                                            <asp:Label runat="server" for="email" AssociatedControlID="email">Enter Your Email</asp:Label>
                                            <!--<label for="email">Your Email</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="email" ErrorMessage="email must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-6">
                                        <div class="form-floating">
                                            <asp:TextBox ID="password" runat="server" class="form-control" placeholder="Your Password" TextMode="Password"></asp:TextBox>
                                            <asp:Label runat="server" for="password" AssociatedControlID="password">Enter Your Password</asp:Label>
                                           <!-- <input type="password" class="form-control" id="password" placeholder="Subject">
                                            <label for="password">Your Password</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="password" ErrorMessage="password must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-6">
                                        <div class="form-floating">
                                            <asp:TextBox ID="cpassword" runat="server" class="form-control" placeholder="Repeat Password" TextMode="Password"></asp:TextBox>
                                            <asp:Label runat="server" for="cpassword" AssociatedControlID="password">Repeat Password</asp:Label>
                                           <!-- <input type="password" class="form-control" id="password" placeholder="Subject">
                                            <label for="password">Your Password</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="cpassword" ErrorMessage="confirm password must be required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;</div>
                                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="password" ControlToValidate="cpassword" ErrorMessage="both password not matched" ForeColor="Red"></asp:CompareValidator>
                                    </div>
                                       
                                            <asp:CheckBox runat="server" ID="chkShowPassword" Text="Show Password" onchange="togglePassword();" />
                                    <div class="col-12">
                                        <div class="form-floating">
                                            <asp:TextBox ID="mobile" runat="server" class="form-control" placeholder="Enter Your Mobile No." TextMode="Number" ></asp:TextBox>
                                            <asp:Label runat="server" for="mobile" AssociatedControlID="mobile">Enter Your Mobile no.</asp:Label>
                                           <!-- <input type="password" class="form-control" id="password" placeholder="Subject">
                                            <label for="password">Your Password</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="mobile" ErrorMessage="mobile must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>

                                    <div class="col-md-12">
                                        <div class="form-floating">
                                            <asp:TextBox ID="dob" runat="server" class="form-control" TextMode="Date" placeholder="Your Date of Birth"></asp:TextBox>
                                            <!--<input type="email" class="form-control" id="email" placeholder="Your Email">-->
                                            <asp:Label runat="server" for="dob" AssociatedControlID="dob">Enter Your Date of Birth</asp:Label>
                                            <!--<label for="email">Your Email</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="dob" ErrorMessage="Date of birth must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-floating">
                                            <!--<asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="Your Email" TextMode="Email"></asp:TextBox>-->
                                            <!--<input type="email" class="form-control" id="email" placeholder="Your Email">-->
<!--                                            <asp:Label runat="server" for="email" AssociatedControlID="email">Enter Your Email</asp:Label>-->
                                            <!--<label for="email">Your Email</label>-->
                                            <!--<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="email" ErrorMessage="email must be required" ForeColor="Red"></asp:RequiredFieldValidator>-->
                                            <!--<asp:Label runat="server" for="gender" AssociatedControlID="gender">Select Your Gender</asp:Label>-->
                                            <p>Select Your Gender</p>
                                           
                                            
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-floating">
                                     <asp:RadioButtonList ID="gender" RepeatDirection="Horizontal" runat="server" AutoPostBack="false">
                                                <asp:ListItem Selected="True">Male</asp:ListItem>
                                                <asp:ListItem style="margin-left: 3vw;">Female</asp:ListItem>
                                            </asp:RadioButtonList>

                                            </div>
                                        </div>

                                    <div class="text-center wow fadeInUp" data-wow-delay="0.1s">
                                        <h6 class="section-title text-center text-primary text-uppercase">address details</h6>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-floating">
                                            <asp:TextBox ID="pincode" runat="server" class="form-control" placeholder="Your Pincode" pattern="[0-9]{6}"></asp:TextBox>
                                            <!--<input type="email" class="form-control" id="email" placeholder="Your Email">-->
                                            <asp:Label runat="server" for="pincode" AssociatedControlID="pincode">Enter Your Pincode</asp:Label>
                                            <!--<label for="email">Your Email</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="pincode" ErrorMessage="pincode must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                     <div class="col-md-6">
                                        <div class="form-floating">
                                            <asp:TextBox ID="state" runat="server" class="form-control" placeholder="Your State" disabled="true"></asp:TextBox>
                                            <!--<input type="email" class="form-control" id="email" placeholder="Your Email">-->
                                            <asp:Label runat="server" for="state" AssociatedControlID="state">Your State is : </asp:Label>
                                            <!--<label for="email">Your Email</label>-->
                                            <!--<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="pincode" ErrorMessage="pincode must be required" ForeColor="Red"></asp:RequiredFieldValidator>-->
                                        </div>
                                    </div>
                                     <div class="col-md-6">
                                        <div class="form-floating">
                                            <asp:TextBox ID="dist" runat="server" class="form-control" placeholder="Your District" disabled="true"></asp:TextBox>
                                            <!--<input type="email" class="form-control" id="email" placeholder="Your Email">-->
                                            <asp:Label runat="server" for="dist" AssociatedControlID="dist">Your District is : </asp:Label>
                                            <!--<label for="email">Your Email</label>-->
                                            <!--<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="pincode" ErrorMessage="pincode must be required" ForeColor="Red"></asp:RequiredFieldValidator>-->
                                        </div>
                                    </div>

                                     <div class="col-md-6">
                                        <div class="form-floating">
                                            <asp:DropDownList ID="city" class="form-control" runat="server" AutoPostBack="True">
                                                <asp:ListItem>first</asp:ListItem>
                                                <asp:ListItem>second</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:Label runat="server" for="city" AssociatedControlID="city">Select Your City</asp:Label>
                                        </div>
                                    </div>

                                    <div class="col-md-12">
                                        <div class="form-floating">
                                            <asp:TextBox ID="address" runat="server" class="form-control" placeholder="Your Address" TextMode="MultiLine" Rows="5" Height="150"></asp:TextBox>
                                            <!--<input type="email" class="form-control" id="email" placeholder="Your Email">-->
                                            <asp:Label runat="server" for="address" AssociatedControlID="address">Your Address</asp:Label>
                                            <!--<label for="email">Your Email</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="address" ErrorMessage="Address must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>


                                    <div class="col-12" style="display:flex; justify-content:space-between">
                                        <div class="form-floating">
                                           <a href="login.aspx">Already Registered?</a>
                                        </div>
                                    </div>
                                    <div class="col-12">
                                        <asp:Button ID="Button1" runat="server" class="btn btn-primary w-100 py-3" Text="GET OTP" OnClick="Button1_Click" />
                                    </div>
                                </div>
                            
                            <br /><br/><br /><br/><br />
                        </div>
                    </div>
                </div>
            </div>
        </div>    
        
    <script>
        function togglePassword() {
            var passwordField = document.getElementById('<%= password.ClientID %>');
            var passwordField1 = document.getElementById('<%= cpassword.ClientID %>');
                var checkBox = document.getElementById('<%= chkShowPassword.ClientID %>');

            // Change the type of the password field based on the checkbox state
            passwordField.type = checkBox.checked ? 'text' : 'password';
            passwordField1.type = checkBox.checked ? 'text' : 'password';
        }
    </script>
         
</asp:Content>
