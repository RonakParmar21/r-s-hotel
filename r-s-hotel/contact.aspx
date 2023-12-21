<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="r_s_restaurent.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css" integrity="sha512-DTOQO9RWCH3ppGqcWaEA1BIZOC6xxalwEsw9c2QQeAIftl+Vegovlnee1c9QX4TctnWMn13TZye+giMm8e2LwA==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <div class="container-xxl bg-white p-0">
        <!-- Page Header Start -->
        <div class="container-fluid page-header mb-5 p-0" style="background-image: url(img/carousel-1.jpg);">
            <div class="container-fluid page-header-inner py-5">
                <div class="container text-center pb-5">
                    <h1 class="display-3 text-white mb-3 animated slideInDown">Contact</h1>
                    <nav aria-label="breadcrumb">
                        <ol class="breadcrumb justify-content-center text-uppercase">
                            <li class="breadcrumb-item"><a href="#">Home</a></li>
                            <li class="breadcrumb-item"><a href="#">Pages</a></li>
                            <li class="breadcrumb-item text-white active" aria-current="page">Contact</li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
        <!-- Page Header End -->


     


        <!-- Contact Start -->
        <div class="container-xxl py-5">
            <div class="container">
                <div class="text-center wow fadeInUp" data-wow-delay="0.1s">
                    <h6 class="section-title text-center text-primary text-uppercase">Contact Us</h6>
                    <h1 class="mb-5"><span class="text-primary text-uppercase">Contact</span> For Any Query</h1>
                </div>
                <div class="row g-4">
                    <div class="col-12">
                        <div class="row gy-4">
                            <div class="col-md-4">
                                <h6 class="section-title text-start text-primary text-uppercase">Ronak Parmar</h6>
                                <p><i class="fa fa-envelope-open text-primary me-2"></i><a style="color: black;" href="mailto:parmarronak21112003@gmail.com">parmarronak21112003@gmail.com</a></p>
                                <p><i class="fa-brands fa-linkedin-in text-primary me-2"></i><a style="color: black;" href="https://www.linkedin.com/in/parmar-ronak-4aa170219/">Ronak Parmar</a></p>
                                <p><i class="fa-solid fa-phone text-primary me-2"></i><a style="color: black;" href="">+91 99244 50208</a></p>
                            </div>
                            <div class="col-md-4">
                                <!--<h6 class="section-title text-start text-primary text-uppercase">General</h6>
                                <p><i class="fa fa-envelope-open text-primary me-2"></i>info@example.com</p>-->
                            </div>
                            <div class="col-md-4">
                                <h6 class="section-title text-start text-primary text-uppercase">Ronak Parmar</h6>
                                <p><i class="fa fa-envelope-open text-primary me-2"></i><a style="color: black;" href="mailto:parmarronak21112003@gmail.com">parmarronak21112003@gmail.com</a></p>
                                <p><i class="fa-brands fa-linkedin-in text-primary me-2"></i><a style="color: black;" href="https://www.linkedin.com/in/parmar-ronak-4aa170219/">Ronak Parmar</a></p>
                                <p><i class="fa-solid fa-phone text-primary me-2"></i><a style="color: black;" href="">+91 99244 50208</a></p>
                                <!--<h6 class="section-title text-start text-primary text-uppercase">Technical</h6>
                                <p><i class="fa fa-envelope-open text-primary me-2"></i><a href="malto:tech@example.com">tech@example.com</a></p>-->
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6 wow fadeIn" data-wow-delay="0.1s">
                        <iframe class="position-relative rounded w-100 h-100" 
                            src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d59378.35538835333!2d70.42256043540908!3d21.541098379148973!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x39580194f8317365%3A0xf2fce6f0cc4abcff!2sShree%20Swaminarayan%20Gurukul!5e0!3m2!1sen!2sin!4v1702887668902!5m2!1sen!2sin"                             
                            frameborder="0" style="min-height: 350px; border:0;" 
                            allowfullscreen="" aria-hidden="false"
                            tabindex="0"
                            referrerpolicy="no-referrer-when-downgrade"></iframe>
                       <!-- <iframe class="position-relative rounded w-100 h-100"
                            src="htt://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3001156.4288297426!2d-78.01371936852176!3d42.72876761954724!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4ccc4bf0f123a5a9%3A0xddcfc6c1de189567!2sNew%20York%2C%20USA!5e0!3m2!1sen!2sbd!4v1603794290143!5m2!1sen!2sbd"
                            src="ttps://maps.app.goo.gl/MpPvZTEbkWTVtMaz7"
                            frameborder="0" style="min-height: 350px; border:0;" allowfullscreen="" aria-hidden="false"
                            tabindex="0"></iframe>-->
                    </div>
                    <div class="col-md-6">
                        <div class="wow fadeInUp" data-wow-delay="0.2s">
                            <form>
                                <div class="row g-3">
                                    <div class="col-md-6">
                                        <div class="form-floating">
                                            <asp:TextBox ID="name" class="form-control" runat="server" placeholder="Enter Your Name"></asp:TextBox>
                                            <asp:Label runat="server" for="name" AssociatedControlID="name">Enter Your Name</asp:Label>
                                            <!--<input type="text" class="form-control" id="name" placeholder="Your Name">-->
                                            <!--<label for="name">Your Name</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" ErrorMessage="Name must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-floating">
                                            <asp:TextBox ID="email" class="form-control" runat="server" placeholder="Enter Your Email" TextMode="Email"></asp:TextBox>
                                            <asp:Label runat="server" for="email" AssociatedControlID="email">Enter Your Email</asp:Label>
                                            <!--<input type="email" class="form-control" id="email" placeholder="Your Email">
                                            <label for="email">Your Email</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email" ErrorMessage="Email must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-12">
                                        <div class="form-floating">
                                            <asp:TextBox ID="subject" class="form-control" runat="server" placeholder="Enter Your Subject"></asp:TextBox>
                                            <asp:Label runat="server" for="subject" AssociatedControlID="subject">Enter Your Subject</asp:Label>
                                            <!--<input type="text" class="form-control" id="subject" placeholder="Subject">
                                            <label for="subject">Subject</label>-->
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="subject" ErrorMessage="Subject must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-12">
                                        <div class="form-floating">
                                            <asp:TextBox ID="message" class="form-control" runat="server" placeholder="Enter Your Message" style="height: 150px;" TextMode="MultiLine" Rows="3" Columns="30"></asp:TextBox>
                                            <asp:Label runat="server" for="message" AssociatedControlID="message">Enter Your Message</asp:Label>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="message" ErrorMessage="Message must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                           <!-- <textarea class="form-control" placeholder="Leave a message here" id="message" style="height: 150px"></textarea>
                                            <label for="message">Message</label>-->
                                        </div>
                                    </div>
                                    <div class="col-12">
                                        <asp:Button ID="Button1" runat="server" Text="Send Message" class="btn btn-primary w-100 py-3" />
                                        <!--<button class="btn btn-primary w-100 py-3" type="submit">Send Message</button>-->
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Contact End -->
        <br /><br /><br /><br /><br />

        <!-- Newsletter Start -->
       <!-- <div class="container newsletter mt-5 wow fadeIn" data-wow-delay="0.1s">
            <div class="row justify-content-center">
                <div class="col-lg-10 border rounded p-1">
                    <div class="border rounded text-center p-1">
                        <div class="bg-white rounded text-center p-5">
                            <h4 class="mb-4">Subscribe Our <span class="text-primary text-uppercase">Newsletter</span></h4>
                            <div class="position-relative mx-auto" style="max-width: 400px;">
                                <input class="form-control w-100 py-3 ps-4 pe-5" type="text" placeholder="Enter your email">
                                <button type="button" class="btn btn-primary py-2 px-3 position-absolute top-0 end-0 mt-2 me-2">Submit</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>-->
        <!-- Newsletter Start -->
    </div>
</asp:Content>
