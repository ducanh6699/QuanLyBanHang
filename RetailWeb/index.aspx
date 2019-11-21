<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.index" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Trang chủ</title>

    <style type="text/css">
        body {
            font-family: 'Varela Round', sans-serif;
        }

        .form-control {
            box-shadow: none;
            font-weight: normal;
            font-size: 13px;
        }

            .form-control:focus {
                border-color: #33cabb;
                box-shadow: 0 0 8px rgba(0,0,0,0.1);
            }

        .navbar-header.col {
            padding: 0 !important;
        }

        .navbar {
            background: #fff;
            padding-left: 16px;
            padding-right: 16px;
            border-bottom: 1px solid #dfe3e8;
            border-radius: 0;
        }

        .nav-link img {
            border-radius: 50%;
            width: 36px;
            height: 36px;
            margin: -8px 0;
            float: left;
            margin-right: 10px;
        }

        .navbar .navbar-brand, .navbar .navbar-brand:hover, .navbar .navbar-brand:focus {
            padding-left: 0;
            font-size: 20px;
            padding-right: 50px;
        }

            .navbar .navbar-brand b {
                font-weight: bold;
                color: #33cabb;
            }

        .navbar .form-inline {
            display: inline-block;
        }

        .navbar .nav li {
            position: relative;
        }

            .navbar .nav li a {
                color: #888;
            }

        .search-box {
            position: relative;
        }

            .search-box input {
                padding-right: 35px;
                border-color: #dfe3e8;
                border-radius: 4px !important;
                box-shadow: none;
            }

            .search-box .input-group-addon {
                min-width: 35px;
                border: none;
                background: transparent;
                position: absolute;
                right: 0;
                z-index: 9;
                padding: 7px;
                height: 100%;
            }

            .search-box i {
                color: #a0a5b1;
                font-size: 19px;
            }

        .navbar .nav .btn-primary, .navbar .nav .btn-primary:active {
            color: #fff;
            background: #33cabb;
            padding-top: 8px;
            padding-bottom: 6px;
            vertical-align: middle;
            border: none;
        }

            .navbar .nav .btn-primary:hover, .navbar .nav .btn-primary:focus {
                color: #fff;
                outline: none;
                background: #31bfb1;
            }

        .navbar .navbar-right li:first-child a {
            padding-right: 30px;
        }

        .navbar .nav-item i {
            font-size: 18px;
        }

        .navbar .dropdown-item i {
            font-size: 16px;
            min-width: 22px;
        }

        .navbar ul.nav li.active a, .navbar ul.nav li.open > a {
            background: transparent !important;
        }

        .navbar .nav .get-started-btn {
            min-width: 120px;
            margin-top: 8px;
            margin-bottom: 8px;
        }

        .navbar ul.nav li.open > a.get-started-btn {
            color: #fff;
            background: #31bfb1 !important;
        }

        .navbar .dropdown-menu {
            border-radius: 1px;
            border-color: #e5e5e5;
            box-shadow: 0 2px 8px rgba(0,0,0,.05);
        }

        .navbar .nav .dropdown-menu li {
            color: #999;
            font-weight: normal;
        }

            .navbar .nav .dropdown-menu li a, .navbar .nav .dropdown-menu li a:hover, .navbar .nav .dropdown-menu li a:focus {
                padding: 8px 20px;
                line-height: normal;
            }

        .navbar .navbar-form {
            border: none;
        }

        .navbar .dropdown-menu.form-wrapper {
            width: 280px;
            padding: 20px;
            left: auto;
            right: 0;
            font-size: 14px;
        }

            .navbar .dropdown-menu.form-wrapper a {
                color: #33cabb;
                padding: 0 !important;
            }

                .navbar .dropdown-menu.form-wrapper a:hover {
                    text-decoration: underline;
                }

        .navbar .form-wrapper .hint-text {
            text-align: center;
            margin-bottom: 15px;
            font-size: 13px;
        }

        .navbar .form-wrapper .social-btn .btn, .navbar .form-wrapper .social-btn .btn:hover {
            color: #fff;
            margin: 0;
            padding: 0 !important;
            font-size: 13px;
            border: none;
            transition: all 0.4s;
            text-align: center;
            line-height: 34px;
            width: 47%;
            text-decoration: none;
        }

        .navbar .social-btn .btn-primary {
            background: #507cc0;
        }

            .navbar .social-btn .btn-primary:hover {
                background: #4676bd;
            }

        .navbar .social-btn .btn-info {
            background: #64ccf1;
        }

            .navbar .social-btn .btn-info:hover {
                background: #4ec7ef;
            }

        .navbar .social-btn .btn i {
            margin-right: 5px;
            font-size: 16px;
            position: relative;
            top: 2px;
        }

        .navbar .form-wrapper .form-footer {
            text-align: center;
            padding-top: 10px;
            font-size: 13px;
        }

            .navbar .form-wrapper .form-footer a:hover {
                text-decoration: underline;
            }

        .navbar .form-wrapper .checkbox-inline input {
            margin-top: 3px;
        }

        .or-seperator {
            margin-top: 32px;
            text-align: center;
            border-top: 1px solid #e0e0e0;
        }

            .or-seperator b {
                color: #666;
                padding: 0 8px;
                width: 30px;
                height: 30px;
                font-size: 13px;
                text-align: center;
                line-height: 26px;
                background: #fff;
                display: inline-block;
                border: 1px solid #e0e0e0;
                border-radius: 50%;
                position: relative;
                top: -15px;
                z-index: 1;
            }

        .navbar .checkbox-inline {
            font-size: 13px;
        }

        .navbar .navbar-right .dropdown-toggle::after {
            display: none;
        }

        @media (min-width: 1200px) {
            .form-inline .input-group {
                width: 300px;
                margin-left: 30px;
            }
        }

        @media (max-width: 768px) {
            .navbar .dropdown-menu.form-wrapper {
                width: 100%;
                padding: 10px 15px;
                background: transparent;
                border: none;
            }

            .navbar .form-inline {
                display: block;
            }

            .navbar .input-group {
                width: 100%;
            }

            .navbar .nav .btn-primary, .navbar .nav .btn-primary:active {
                display: block;
            }
        }
    </style>
    <script type="text/javascript">
        $(document).on("click", ".navbar-right .dropdown-menu", function (e) {
            e.stopPropagation();
        });
    </script>
    <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />

    <!-- Custom styles for this template -->
    <link href="css/shop-homepage.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
            <div class="container">
                <a class="navbar-brand" href="index.aspx">SHOP LÝ DO</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item active">
                        <a class="nav-link" href="index.aspx">Home
                                <span class="sr-only">(current)</span>
                        </a>
                    </li>

                    <li class="nav-item" id="thongke" visible="false" runat="server">
                        <a class="nav-link" href="Thongke.aspx">Thống kê</a>
                    </li>

                    <li class="nav-item" id="login" runat="server">
                        <a data-toggle="dropdown" class="nav-link dropdown-toggle" href="#">Đăng nhập</a>
                        <ul class="dropdown-menu form-wrapper">
                            <li>

                                <center><h1>Đăng nhập</h1></center>
                                <div class="form-group">
                                    <asp:TextBox ID="tendangnhap" class="form-control" placeholder="Tên đăng nhập" runat="server" ></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox TextMode="Password" ID="matkhau" class="form-control" placeholder="Mật khẩu" runat="server" ></asp:TextBox>
                                </div>
                                <asp:Button ID="dangnhap" class="btn btn-primary btn-block" runat="server" OnClick="dangnhap_Click" Text="Đăng nhập" />
                                <div class="form-footer">
                                </div>

                            </li>
                        </ul>
                    </li>

                    <li class="nav-item" id="logout" visible="false" runat="server">
                        <a class="nav-link" href="dangxuat.aspx">Đăng xuất</a>
                    </li>
                </ul>
            </div>
        </nav>

        <!-- Page Content -->
        <div class="container">

            <div class="row">

                <div class="col-md-3">

                    <h1 class="my-4">
                        <img src="img/Untitled.png"></h1>
                    <div class="card">
                        <article class="card-group-item">
                            <header class="card-header">
                                <h6 class="title">Tìm theo tên và giá </h6>
                            </header>
                            <div class="filter-content">
                                <div class="card-body">

                                    <asp:TextBox ID="ten" class="form-control" placeholder="Nhập tên sản phẩm" runat="server"></asp:TextBox>
                                    <hr />
                                    <div class="form-row">
                                        <div class="form-group col-md-6">
                                            <label>Từ</label>
                                            <asp:TextBox ID="giatu" CssClass="form-control" value="0" runat="server" ></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-6 text-right">
                                            <label>Đến</label>
                                            <asp:TextBox ID="giaden" CssClass="form-control" value="1000000" runat="server" ></asp:TextBox>
                                        </div>
                                        <asp:Button ID="tim" runat="server" CssClass="form-control btn btn-dark" Text="Tìm" OnClick="tim_Click" />
                                    </div>

                                </div>
                                <!-- card-body.// -->
                            </div>
                        </article>
                        <!-- card-group-item.// -->

                        <article class="card-group-item">
                            <header class="card-header">
                                <h6 class="title">Tìm theo loại </h6>
                            </header>
                            <div class="filter-content">
                                <div class="card-body">
                                    <asp:CheckBoxList ID="checkboxloaihang" runat="server" OnSelectedIndexChanged="checkboxloaihang_SelectedIndexChanged" AutoPostBack="true"></asp:CheckBoxList>
                                </div>
                            </div>
                        </article>
                    </div>
                </div>
                <!-- /.col-lg-3 -->

                <div class="col-lg-9">
                    <div id="carouselExampleIndicators" class="carousel slide my-4" data-ride="carousel">
                        <ol class="carousel-indicators">
                            <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                            <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                        </ol>
                        <div class="carousel-inner" role="listbox">
                            <div class="carousel-item active">
                                <img class="d-block img-fluid" src="img/banner1.jpg" alt="First slide" style="height: 350px; width: 900px;">
                            </div>
                            <div class="carousel-item">
                                <img class="d-block img-fluid" src="img/banner2.jpg" alt="Second slide" style="height: 350px; width: 900px;">
                            </div>
                            <div class="carousel-item">
                                <img class="d-block img-fluid" src="img/banner3.jpg" alt="Third slide" style="height: 350px; width: 900px;">
                            </div>
                        </div>
                        <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="sr-only">Previous</span>
                        </a>
                        <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="sr-only">Next</span>
                        </a>
                    </div>
                    <div class="row">
                        <asp:ListView ID="Listview1" OnPagePropertiesChanged="Listview1_PagePropertiesChanged" runat="server" OnItemDataBound="Listview1_ItemDataBound">
                            <ItemTemplate>
                                <div class="col-lg-4 col-md-6 mb-4" runat="server">
                                    <div class="card h-100">
                                        <a href="#">
                                            <img class="card-img-top img-responsive img-fluid" src="img/<%#Eval("anhminhhoa")%>" style="height: 175px; width: 260px;"></a>
                                        <div class="card-body">
                                            <h4 class="card-title" style="min-height:50px;">
                                                <a href="#"><%#Eval("tenmathang")%></a>
                                            </h4>
                                            <h5><%#Eval("dongia")%>VND</h5>
                                        </div>
                                        <div class="card-footer">
                                            <small class="text-muted float-left">Còn <%#Eval("soluongton")%> sản phẩm</small>
                                            <div runat="server" id="theDiv"><a href="suaxoa.aspx?id=<%#Eval("id")%>" class="text-muted float-right">Sửa/Xóa</a></div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>

                        <asp:DataPager ID="DataPager1" runat="server" PagedControlID="Listview1" class="col-md-12" PageSize="6">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ButtonCssClass="btn btn-dark" ShowFirstPageButton="True" ShowNextPageButton="true" ShowPreviousPageButton="False" />
                                <asp:NumericPagerField />
                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ButtonCssClass="btn btn-dark" ShowNextPageButton="true" ShowPreviousPageButton="False" />
                            </Fields>
                        </asp:DataPager>
                    </div>
                    <!-- /.row -->

                </div>
                <!-- /.col-lg-9 -->

            </div>
            <!-- /.row -->

        </div>
        <!-- /.container -->

        <!-- Footer -->
        <footer class="py-5 bg-dark">
            <div class="container">
                <p class="m-0 text-center text-white">Copyright &copy; Your Website 2019</p>
            </div>
            <!-- /.container -->
        </footer>


        <!-- Bootstrap core JavaScript -->
        <script src="vendor/jquery/jquery.min.js"></script>
        <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    </form>
</body>
</html>
