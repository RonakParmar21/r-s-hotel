<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="r_s_hotel.profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        @import url('https://fonts.googleapis.com/css2?family=Poppins:wght@400;500;600&display=swap');

        body {
            font-family: 'Poppins', sans-serif;
            margin: 0;
            padding: 0;
        }

        #algn {
            height: 92vh;
            min-height: 500px;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        #card {
            width: 370px;
            height: 435px;
            border: none;
            border-radius: 15px;
            overflow: hidden;
            box-shadow: 0 4px 8px 0 #E7E9EB, 0 6px 20px 0 #E7E9EB;
        }

        #upper-bg {
            width: 100%;
            height: 35%;
            /*background-color: #FFE400;*/
            display: flex;
            justify-content: center;
            position: relative;
        }

        .profile-pic {
            width: 35%;
            background-color: white;
            /*border: 3px solid #FFE400;*/
            border-radius: 50%;
            padding: 3px;
            position: absolute;
            top: 40px;
        }

        #lower-bg {
            width: 100%;
            height: 65%;
        }

        .text {
            text-align: center;
            padding-top: 35px;
        }

            .text .name {
                font-weight: 600;
                font-size: large;
                padding: 0;
                margin: 5px;
            }

            .text .title {
                padding: 0;
                margin: 0;
                font-size: 15px;
            }

        #icons {
            display: flex;
            justify-content: center;
            margin: 15px;
        }

            #icons img {
                width: 80%;
                height: 90%;
            }

        .ico {
            display: flex;
            justify-content: center;
            align-items: center;
        }

        #btn {
            display: flex;
            justify-content: center;
            margin: 15px;
        }

            #btn button {
                margin: 0 20px;
                padding: 10px 15px;
                background-color: #FFE400;
                border: none;
                border-radius: 50px;
                font-weight: 700;
            }

                #btn button:hover {
                    box-shadow: 0 4px 8px 0 #E7E9EB, 0 6px 20px 0 #E7E9EB;
                }

        #l-c-s {
            display: flex;
            flex-direction: row;
            justify-content: space-around;
            align-items: center;
            margin: 20px 10px;
        }

            #l-c-s .num {
                display: flex;
            }

            #l-c-s .dvr {
                width: 2px;
                height: 25px;
                background-color: gray;
            }

            #l-c-s img {
                width: 24px;
                height: 24px;
            }

        .license {
            font-size: 12px;
            text-align: center;
        }

            .license .ll {
                padding: 0 10px;
                display: inline;
            }
    </style>

    <div id="algn">
        <div id="card" style="margin-bottom: 200px; margin-top: 80px;">
            <div id="upper-bg">
                <img src="img/user.png" alt="profile-pic" class="profile-pic">
            </div>
            <div id="lower-bg">
                <asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand">
                    <ItemTemplate>

                        <div class="text">
                            <h1 style="text-transform: uppercase; font-size: 2rem;" class="name">
                                <%# Eval("user_name") %>
                            </h1>
                        </div>
                        <div id="btn" style="width: 90%; display: flex; flex-direction: column; gap: 10px;">
                            <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-sm btn-primary rounded py-2 px-4" CommandName="CBooking" CommandArgument='<%# Eval("user_id") %>'>Current Booking</asp:LinkButton>
                            <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-sm btn-primary rounded py-2 px-4" CommandName="HBooking" CommandArgument='<%# Eval("user_id") %>'>Booking History</asp:LinkButton>
                            <!--<button class="msg" style="width: 100%;"></button>-->
                        </div>
                        <button class="msg">Message</button>
                        <div id="l-c-s">
                        </div>

                    </ItemTemplate>
                </asp:DataList>

            </div>
        </div>
    </div>
    <!--<div class="license">
        <div class="ll"><a href="https://icons8.com/icon/P7UIlhbpWzZm/gmail">Gmail</a> icon by <a href="https://icons8.com">Icons8</a></div>
        <div class="ll"><a href="https://icons8.com/icon/AZOZNnY73haj/github">GitHub</a> icon by <a href="https://icons8.com">Icons8</a></div>
        <div class="ll"><a href="https://icons8.com/icon/13930/linkedin">LinkedIn</a> icon by <a href="https://icons8.com">Icons8</a></div>
        <div class="ll"><a href="https://icons8.com/icon/118497/facebook">Facebook</a> icon by <a href="https://icons8.com">Icons8</a></div>
        <div class="ll"><a href="https://icons8.com/icon/u8MTpAq972MG/like">Like</a> icon by <a href="https://icons8.com">Icons8</a></div>
        <div class="ll"><a href="https://icons8.com/icon/8h51YOzhBJmT/comment">Comment</a> icon by <a href="https://icons8.com">Icons8</a></div>
    </div>-->

</asp:Content>
