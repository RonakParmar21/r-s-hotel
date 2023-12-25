<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="otp.aspx.cs" Inherits="r_s_hotel.otp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container-xxl py-5">
            <div class="container">
                <div class="text-center wow fadeInUp" data-wow-delay="0.1s">
                    <!--<h6 class="section-title text-center text-primary text-uppercase">Register Now</h6>-->
                    <h1 class="mb-5"><span class="text-primary text-uppercase">OTP</span></h1>
                </div>
                <div class="text-center wow fadeInUp pb-2" data-wow-delay="0.1s">
                    <!--<h6 class="section-title text-center text-primary text-uppercae">personal details</h6>-->
                </div>
                <div class="row g-4" style="display: flex; justify-content:center">
                    <div class="col-md-6">
                        <div class="wow fadeInUp" data-wow-delay="0.2s">
                                <div class="row g-3">
                                    <div class="col-md-12">
                                        <div class="form-floating">
                                            <asp:TextBox ID="otp" runat="server" class="form-control" placeholder="Your OTP" pattern="[0-9]{6}"></asp:TextBox>
                                            <!--<input type="email" class="form-control" id="email" placeholder="Your Email">-->
                                            <asp:Label runat="server" for="otp" AssociatedControlID="otp">Enter Your OTP</asp:Label>
                                            <!--<label for="email">Your Email</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="otp" ErrorMessage="OTP must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-12" style="display:flex; justify-content:space-between">
                                        <div class="form-floating">
                                           <a href="#">Resend otp?</a>
                                        </div>
                                    </div>
                                    <div class="col-12">
                                        <asp:Button ID="Button1" runat="server" class="btn btn-primary w-100 py-3" Text="register" />
                                    </div>
                                </div>
                            
                            <br /><br/><br /><br/><br />
                        </div>
                    </div>
                </div>
            </div>
        </div> 
</asp:Content>
