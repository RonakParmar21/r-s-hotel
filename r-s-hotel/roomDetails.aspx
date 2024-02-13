<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="roomDetails.aspx.cs" Inherits="r_s_hotel.roomDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        body {
            font-family: sans-serif;
        }

        header {
            height: 15vh;
            width: 100%;
            background: lightgray;
            margin-bottom: 50px;
        }

        #product-info {
            display: flex;
            width: 95%;
            margin: 0 auto
        }

        .item-image-parent {
            order: 1;
            width: 50%;
            display: flex;
        }

        .item-info-parent {
            order: 2;
            width: 50%;
        }

        .item-list-vertical {
            order: 1;
            width: 10%;
            overflow-y: auto;
            margin-top: 50px;
        }

        .item-image-main {
            order: 2;
            width: 90%;
            height: 100%;
        }

        /* sectioning completed */


        .thumb-box {
            width: 75%;
            margin: 10px auto;
            background: white;
            border: 1px solid gray;
        }

            .thumb-box img {
                width: 100%;
                height: 100%;
            }

        .item-image-main img {
            width: 100%;
            height: auto;
        }

        .thumb-box:hover {
            cursor: pointer;
            border-color: #e77600;
            ;
            box-shadow: 0px 1px 5px 1px #e77600;
        }

        /* Item Info */
        .main-info h4 {
            font-size: 21px;
            margin-bottom: 0;
            font-weight: 400
        }

        .star-rating {
            width: 70%;
            color: gray;
            font-size: 24px;
            border-bottom: 0.4px solid rgba(194, 194, 194, 0.829);
        }

            .star-rating span {
                color: gold;
            }

        .main-info p {
            font-size: 15px;
            color: gray;
            margin-bottom: 30px;
        }

        #price {
            color: rgb(168, 14, 14);
            font-size: 21px;
        }

        /* Select Items */

        .change-color {
            margin-bottom: 10px;
        }

            .change-color .thumb-box {
                margin: 10px 10px 10px 0;
                width: 40px;
                display: inline-block;
            }

        .change-size select {
            padding: 5px 10px;
            border-radius: 4px;
            border-color: rgb(189, 189, 189);
            margin-top: 10px;
        }

        .description ul {
            padding-left: 17px;
            font-size: 15px;
            line-height: 1.3rem;
        }

        li {
            list-style-type: none;
        }
    </style>

    <asp:DataList ID="dlRooms" OnItemCommand="dlRooms_ItemCommand" runat="server" RepeatColumns="3" CssClass="row" style="width:80%; margin-left: 10%; margin-right:10%; margin-top:3%; height: auto; margin-bottom:10%;">
        <ItemTemplate>

            <section id="product-info">

                <div class="item-image-parent">

                    <div class="item-image-main">
                        <asp:Image ID="Image33" runat="server" CssClass="img-fluid" ImageUrl='<%# Bind("room_img") %>' Width="900" />
                        <!--<img src="hps://i.ibb.co/xYpFY0T/item1.jpg" alt="default" />-->
                    </div>
                </div>

                <div class="item-info-parent">
                    <!-- main info -->
                    <div class="main-info">
                        <h4 style="font-size:1.5rem; font-weight: 900;">
                            <%# Eval("room_type") %>
                        </h4>
                        <!--<div class="star-rating">
                            <span>★★★★</span>★            
                        </div>-->
                        <p>Price: <span id="price">₹ <%# Eval("room_price") %>.00/per night</span></p>
                    </div>

                    <div class="description" style="margin-top:-5px;">
                        <%#Eval("room_description") %>
                    </div>

                    <!-- Choose -->
                    <div class="select-items">



                        <!--<div class="change-size">
                            <label><b>Size:</b></label><br>
                            <select>
                                <option>S</option>
                                <option>M</option>
                                <option>L</option>
                                <option>XL</option>
                                <option>2XL</option>
                            </select>
                        </div>-->

                        <div class="description">
                            <ul>
                                <li>
                                    <small class="border-end me-3 pe-3"><i class="fa fa-bed text-primary me-2"></i><%# Eval("room_capacity") %> Bed</small>
                                </li>
                                <li>
                                    <small class="border-end me-3 pe-3"><i class="fa fa-bath text-primary me-2"></i><%# Eval("room_capacity") %> Bath</small>
                                </li>
                                <li>
                                    <small><i class="fa fa-wifi text-primary me-2"></i>Wifi</small>
                                </li>
                            </ul>
                        </div>

                        <div style="display: flex;">
                            <h6>Room Status : </h6>
                            <!--<h6 style="color: darkred"><Eval("room_status") %></h6>-->
                            <%# Convert.ToInt32(Eval("room_total")) == 0 ? "Not Available" : "Available" %>
                        </div>
                    </div>
                    <!-- Description -->

                    <!-- button -->
                    
                    <div style="display: flex; gap: 5px;">
                        <div>
                        <asp:LinkButton ID="LinkButtonViewDetail" runat="server" Visible='<%# Convert.ToInt32(Eval("room_total")) != 0 %>' CssClass="btn btn-sm btn-primary rounded py-2 px-4" CommandName="BookNow" CommandArgument='<%# Eval("room_id") %>'>Book Now</asp:LinkButton>
                    </div>
                    <div>
                        <asp:LinkButton ID="LinkButton1" runat="server" Visible='<%# Convert.ToInt32(Eval("room_total")) != 0 %>' CssClass="btn btn-sm btn-primary rounded py-2 px-4" CommandName="MakeReview" CommandArgument='<%# Eval("room_id") %>'>Make Review</asp:LinkButton>
                    </div>
                    </div>

                </div>
            </section>

        </ItemTemplate>
    </asp:DataList>


    <asp:Image ID="Image1" runat="server" />

</asp:Content>
