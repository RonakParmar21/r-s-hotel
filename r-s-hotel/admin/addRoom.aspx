<%@ Page Title="" Language="C#" MasterPageFile="~/admin/nav_footer.Master" AutoEventWireup="true" CodeBehind="addRoom.aspx.cs" Inherits="r_s_hotel.admin.addRoom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <head >
        <title>Add Room</title>
      <style>
        .mp {
          margin-top: 50px;
          padding: 20px;
        }

        .ml {
          margin: 10px 40% 10px 40%;

        }

        .fc {
          max-width: 500px;
        }

        .fg {
          margin: 20px;
          align-items: center;
        }
      </style>
    </head>

    <body>
        <div class="container bg-light mp">
            <div class="ml text-center">
                <h1>Add Room</h1>
            </div>
            <section class="panel panel-default" style="margin: 50px 0px 50px 80px;">

                <div class="panel-body">

                    <form class="form-horizontal" role="form">

                        <!-- Room No -->
                        <div class="form-group d-flex fg">
                            <label for="name" class="col-sm-3 control-label text-start h4">Room No</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="roomNo" CssClass="form-control fc" runat="server"
                                    placeholder="Enter Room No" MaxLength="15"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RoomValidator" runat="server" ControlToValidate="roomNo"
                                    ErrorMessage="Enter Room No" ForeColor="Red" Display="Dynamic" SetFocusOnError="True">
                                </asp:RequiredFieldValidator>
                            </div>
                        </div>


                        <!-- Room Description -->
                        <div class="form-group d-flex fg">
                            <label for="name" class="col-sm-3 control-label text-start h4">Room Description</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="roomDescription" CssClass="form-control fc" runat="server"
                                    placeholder="Enter Room Description" TextMode="MultiLine" Rows="4"></asp:TextBox>
                            </div>
                        </div>

                        <!-- Room Type -->
                        <div class="form-group d-flex fg">
                            <label for="name" class="col-sm-3 control-label text-start h4">Select Room Type</label>
                            <div class="col-sm-9 fc">
                                <asp:DropDownList ID="category" runat="server" Height="30px" Width="500px">
                                    <asp:ListItem Value="">Select Room Type</asp:ListItem>
                                    <asp:ListItem Value="acs">ac single</asp:ListItem>
                                    <asp:ListItem Value="acd">ac double</asp:ListItem>
                                    <asp:ListItem Value="dilux">dilux</asp:ListItem>
                                    <asp:ListItem Value="sdilux">super dilux</asp:ListItem>
                                    <asp:ListItem Value="nacs">non ac single</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="roomTypeValidator" runat="server" ControlToValidate="category"
                                    InitialValue="" ErrorMessage="Select Room Type" ForeColor="Red" Display="Dynamic"
                                    SetFocusOnError="True" />
                            </div>
                        </div>

                         <!-- Room capacity -->
                        <div class="form-group d-flex fg">
                            <label for="name" class="col-sm-3 control-label text-start h4">Room Capacity</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="TextBox1" CssClass="form-control fc" runat="server"
                                    placeholder="Enter Room Capacity" MaxLength="15"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="roomNo"
                                    ErrorMessage="Enter Room No" ForeColor="Red" Display="Dynamic" SetFocusOnError="True">
                                </asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <!-- Room Price-->
                        <div class="form-group d-flex fg">
                            <label for="name" class="col-sm-3 control-label text-start h4">Room Price</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="roomPrice" CssClass="form-control fc" runat="server"
                                    placeholder="Enter Room Price" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="roomPrice"
                                    ErrorMessage="Enter Room Price" ForeColor="Red" Display="Dynamic" SetFocusOnError="True">
                                </asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <!-- Room Service -->
                        <div class="form-group d-flex fg">
                            <label for="name" class="col-sm-3 control-label text-start h4">Room Service</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="roomService" CssClass="form-control fc" runat="server"
                                    placeholder="Enter Room Service" TextMode="MultiLine" Rows="4"></asp:TextBox>
                            </div>
                        </div>

                        <!-- Room Status-->
                        <div class="form-group d-flex fg">
                            <label for="name" class="col-sm-3 control-label text-start h4">Room Status</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="roomStatus" CssClass="form-control fc" runat="server"
                                    placeholder="Enter Room Status" MaxLength="15"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="roomStatus"
                                    ErrorMessage="Enter Room Status" ForeColor="Red" Display="Dynamic" SetFocusOnError="True">
                                </asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <!-- Room Image -->
                        <div class="form-group d-flex fg">
                            <label for="name" class="col-sm-3 control-label text-start h4">Room Image </label>

                            <div class="col-sm-3">
                                <asp:FileUpload ID="img1" runat="server" />
                                <asp:RequiredFieldValidator ID="imgValidator1" runat="server" ControlToValidate="img1"
                                    ErrorMessage="Select Image" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" />
                            </div>
                        </div>

                        <!-- Room total -->
                        <!-- Room Price-->
                        <div class="form-group d-flex fg">
                            <label for="name" class="col-sm-3 control-label text-start h4">Total Room</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="roomTotal" CssClass="form-control fc" runat="server"
                                    placeholder="Enter Total Room" TextMode="Number"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="roomTotal"
                                    ErrorMessage="Enter Total Room" ForeColor="Red" Display="Dynamic" SetFocusOnError="True">
                                </asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <!-- add Room Button -->
                        <div class="form-group fg">
                            <div class="" style="margin: 40px 280px">
                                <asp:Button ID="add" CssClass="btn btn-primary" runat="server" Text="Add Room" Width="500px"
                                    Font-Bold="True" Font-Size="25px" OnClick="add_Click" />
                            </div>
                        </div>
                    </form>
                </div>
            </section>
        </div>
    </body>
</asp:Content>
