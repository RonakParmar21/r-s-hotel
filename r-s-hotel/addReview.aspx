<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="addReview.aspx.cs" Inherits="r_s_hotel.addReview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-xxl bg-white p-0">
        <!-- Page Header Start -->
        <div class="container-fluid page-header mb-5 p-0" style="background-image: url(img/carousel-1.jpg);">
            <div class="container-fluid page-header-inner py-5">
                <div class="container text-center pb-5">
                    <h1 class="display-3 text-white mb-3 animated slideInDown">Review</h1>
                    <nav aria-label="breadcrumb">
                        <ol class="breadcrumb justify-content-center text-uppercase">
                            <li class="breadcrumb-item"><a href="#">Home</a></li>
                            <li class="breadcrumb-item"><a href="#">Pages</a></li>
                            <li class="breadcrumb-item text-white active" aria-current="page">Review</li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
        <div class="container-xxl py-5">
            <div class="container">
                <div class="text-center wow fadeInUp" data-wow-delay="0.1s">
                    <h6 class="section-title text-center text-primary text-uppercase">Review</h6>
                    <h1 class="mb-5"><span class="text-primary text-uppercase">Review</span> For Feedback</h1>
                </div>
                <div class="row g-4">
                    <div class="col-md-6" style="width: 60%; margin-left: 20%;">
                        <div class="wow fadeInUp" data-wow-delay="0.2s">
                            <form>
                                <div class="row g-3">
                                    <div class="col-12">
                                        <div class="form-floating">
                                            <asp:TextBox ID="message" class="form-control" runat="server" placeholder="Enter Your Message" Style="height: 150px;" TextMode="MultiLine" Rows="3" Columns="30"></asp:TextBox>
                                            <asp:Label runat="server" for="message" AssociatedControlID="message">Enter Your Message</asp:Label>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="message" ErrorMessage="Message must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                            <!-- <textarea class="form-control" placeholder="Leave a message here" id="message" style="height: 150px"></textarea>
                                            <label for="message">Message</label>-->
                                        </div>
                                    </div>
                                    <div class="col-12" style="margin-top: 150px">
                                        <asp:Button ID="Button1" runat="server" Text="Send Message" class="btn btn-primary w-100 py-3" OnClick="Button1_Click" />
                                        <!--<button class="btn btn-primary w-100 py-3" type="submit">Send Message</button>-->
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div style="margin-bottom: 200px;">

    </div>
</asp:Content>
