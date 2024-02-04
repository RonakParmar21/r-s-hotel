<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="booking.aspx.cs" Inherits="r_s_restaurent.booking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-xxl bg-white p-0">
        
        <!-- Page Header Start -->
        <div class="container-fluid page-header mb-5 p-0" style="background-image: url(img/carousel-1.jpg);">
            <div class="container-fluid page-header-inner py-5">
                <div class="container text-center pb-5">
                    <h1 class="display-3 text-white mb-3 animated slideInDown">Booking</h1>
                    <nav aria-label="breadcrumb">
                        <ol class="breadcrumb justify-content-center text-uppercase">
                            <li class="breadcrumb-item"><a href="#">Home</a></li>
                            <li class="breadcrumb-item"><a href="#">Pages</a></li>
                            <li class="breadcrumb-item text-white active" aria-current="page">Booking</li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
        <!-- Page Header End -->


       

        <!-- Booking Start -->
        <div class="container-xxl py-5">
            <div class="container">
                <div class="text-center wow fadeInUp" data-wow-delay="0.1s">
                    <h6 class="section-title text-center text-primary text-uppercase">Room Booking</h6>
                    <h1 class="mb-5">Book A <span class="text-primary text-uppercase">Luxury Room</span></h1>
                </div>
                <div class="row g-5">
                    <div class="col-lg-6">
                        <div class="row g-3">
                            <div class="col-6 text-end">
                                <img class="img-fluid rounded w-75 wow zoomIn" data-wow-delay="0.1s" src="img/about-1.jpg" style="margin-top: 25%;">
                            </div>
                            <div class="col-6 text-start">
                                <img class="img-fluid rounded w-100 wow zoomIn" data-wow-delay="0.3s" src="img/about-2.jpg">
                            </div>
                            <div class="col-6 text-end">
                                <img class="img-fluid rounded w-50 wow zoomIn" data-wow-delay="0.5s" src="img/about-3.jpg">
                            </div>
                            <div class="col-6 text-start">
                                <img class="img-fluid rounded w-75 wow zoomIn" data-wow-delay="0.7s" src="img/about-4.jpg">
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="wow fadeInUp" data-wow-delay="0.2s">
                            <form>
                                <center><p style="color:red;">Your name and email is only valid that give at the time of registration</p></center>
                                <div class="row g-3">
                                    <div class="col-md-6">
                                        <div class="form-floating">
                                            <asp:TextBox ID="name" runat="server" class="form-control" placeholder="Your Name"></asp:TextBox>
                                            <asp:Label runat="server" for="name" AssociatedControlID="name">Enter Your Name</asp:Label>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" ErrorMessage="Name must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-floating">
                                            <asp:TextBox ID="email" runat="server" class="form-control" placeholder="Your Email"></asp:TextBox>
                                            <asp:Label runat="server" for="email" AssociatedControlID="email">Enter Your Email</asp:Label>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email" ErrorMessage="Email must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-md-12">
                                        <div class="form-floating">
                                            <asp:TextBox ID="mobile" pattern="[0-9]{10}" runat="server" class="form-control" placeholder="Your Mobile"></asp:TextBox>
                                            <asp:Label runat="server" for="mobile" AssociatedControlID="mobile">Enter Your Mobile No</asp:Label>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="mobile" ErrorMessage="Mobile no must be required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                        <div class="form-floating">
                                            <asp:DropDownList ID="select1" class="form-select" runat="server">
                                                <asp:ListItem Value="">Select Room Type</asp:ListItem>
                                                <asp:ListItem Value="acs">AC Single</asp:ListItem>
                                                <asp:ListItem Value="acd">AC Double</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="categoryValidator" runat="server" ControlToValidate="select1"
                                                InitialValue="" ErrorMessage="Select Room Type" ForeColor="Red" Display="Dynamic"
                                                SetFocusOnError="True" />
                                            <asp:Label runat="server" for="select1" AssociatedControlID="select1">Enter Room Type</asp:Label>
                                          </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-floating">
                                            <asp:TextBox ID="roomqty" CssClass="form-select" runat="server"
                                                placeholder="Enter Room Quantity" TextMode="Number" min="0"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="roomValidator" runat="server" ControlToValidate="roomqty"
                                                InitialValue="" ErrorMessage="Room Quantity" ForeColor="Red" Display="Dynamic"
                                                SetFocusOnError="True" />
                                            <asp:Label runat="server" for="roomqty" AssociatedControlID="roomqty">Enter Room Qty</asp:Label>
                                          </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-floating date" id="date1">
                                            <asp:TextBox ID="TextBox1" CssClass="form-control datetimepicker-input" placeholder="Check In" runat="server" TextMode="Date"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox1"
                                                InitialValue="" ErrorMessage="Room Checkin Date" ForeColor="Red" Display="Dynamic"
                                                SetFocusOnError="True" />
                                            <asp:Label runat="server" for="TextBox1" AssociatedControlID="TextBox1">Enter Checkin Date</asp:Label>
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                        <div class="form-floating date" id="date2">
                                            <asp:TextBox ID="checkout" CssClass="form-control datetimepicker-input" placeholder="Check Out" runat="server" TextMode="Date"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="checkout"
                                                InitialValue="" ErrorMessage="Room Checkout Date" ForeColor="Red" Display="Dynamic"
                                                SetFocusOnError="True" />
                                            <asp:Label runat="server" for="checkout" AssociatedControlID="checkout">Enter Checkout Date</asp:Label>
                                        </div>
                                    </div>

<!--                                    <div class="col-md-6">
                                        <div class="form-floating date" id="date4" data-target-input="nearest">
                                            <input type="text" class="form-control datetimepicker-input" id="checkout" placeholder="Check Out" data-target="#date4" data-toggle="datetimepicker" />
                                            <label for="checkout">Check Out</label>
                                        </div>
                                    </div>-->
                                    <!--<div class="col-md-6">
                                        <div class="form-floating">
                                            <select class="form-select" id="select1">
                                              <option value="1">Adult 1</option>
                                              <option value="2">Adult 2</option>
                                              <option value="3">Adult 3</option>
                                            </select>
                                            <label for="select1">Select Adult</label>
                                          </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-floating">

                                            <select class="form-select" id="select2">
                                              <option value="1">Child 1</option>
                                              <option value="2">Child 2</option>
                                              <option value="3">Child 3</option>
                                            </select>
                                            <label for="select2">Select Child</label>
                                          </div>
                                    </div>-->
                                    <div class="col-6">
                                        <div class="form-floating">
                                             <asp:TextBox ID="totalPerson" CssClass="form-select" runat="server"
                                                placeholder="Enter Total Person" TextMode="Number" min="0"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="totalPerson"
                                                InitialValue="" ErrorMessage="Total Person" ForeColor="Red" Display="Dynamic"
                                                SetFocusOnError="True" />
                                            <asp:Label runat="server" for="totalPerson" AssociatedControlID="totalPerson">Enter Total Person</asp:Label>
                                          </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-floating">
                                            <asp:DropDownList ID="payment" class="form-select" runat="server">
                                                <asp:ListItem Value="">Choose Payment Option</asp:ListItem>
                                                <asp:ListItem Value="gPay">GPay</asp:ListItem>
                                                <asp:ListItem Value="cod">Cash On Reach Hotel</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="payment"
                                                InitialValue="" ErrorMessage="Select Payment Method" ForeColor="Red" Display="Dynamic"
                                                SetFocusOnError="True" />
                                            <asp:Label runat="server" for="payment" AssociatedControlID="payment">Enter Payment Method</asp:Label>
                                          </div>
                                    </div>
                                    <div class="col-12">
                                        <div class="form-floating">

                                            <asp:TextBox ID="request" runat="server" class="form-control" Rows="5" placeholder="Your Special Request" TextMode="MultiLine" style="height: 100px;"></asp:TextBox>
                                            <asp:Label runat="server" for="request" AssociatedControlID="request">Enter Your Special Request</asp:Label>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="request" ErrorMessage="Special Request must be required" ForeColor="Red"></asp:RequiredFieldValidator>

                                    <!--        <textarea class="form-control" placeholder="Special Request" id="message" style="height: 100px"></textarea>
                                            <label for="message">Special Request</label>

                                        -->
                                        </div>
                                    </div>
                                    <div class="col-12">
                                        <button class="btn btn-primary w-100 py-3" type="submit">Book Now</button>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Booking End -->


        <!-- Newsletter Start -->
        <!--<div class="container newsletter mt-5 wow fadeIn" data-wow-delay="0.1s">
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

    <br /><br />
    <br /><br />

</asp:Content>
