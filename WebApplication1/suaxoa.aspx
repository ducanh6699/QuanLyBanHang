<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="suaxoa.aspx.cs" Inherits="WebApplication1.suaxoa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />

    <!-- Custom styles for this template -->
    <link href="css/shop-homepage.css" rel="stylesheet" />
    <title>Sửa/xóa</title>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
            <div class="container">
                <a class="navbar-brand" href="#">SHOP LÝ DO</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item active">
                        <a class="nav-link" href="#">Home
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
                                    <asp:TextBox ID="tendangnhap" class="form-control" placeholder="Tên đăng nhập" runat="server" required="true"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox TextMode="Password" ID="matkhau" class="form-control" placeholder="Mật khẩu" runat="server" required="true"></asp:TextBox>
                                </div>
                                <asp:Button ID="dangnhap" class="btn btn-primary btn-block" runat="server" Text="Đăng nhập" />
                                <div class="form-footer">
                                </div>
                            </li>
                        </ul>
                    </li>

                    <li class="nav-item" id="logout" visible="false" runat="server">
                        <a class="nav-link" href="#">Đăng xuất</a>
                    </li>
                </ul>
            </div>
        </nav>

        <div class="container">
            <div class="row" style="padding-top: 15px;">

                <div class="col-md-6 col-sm-12">
                    <div class="form-group row">
                        <label for="mavach" class="col-md-4 col-form-label">Mã vạch</label>
                        <div class="col-md-8">
                            <asp:TextBox ID="mavach" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="col-md-6 col-sm-12">
                    <div class="form-group row">
                        <label for="tenmathang" class="col-md-4 col-form-label">Tên mặt hàng</label>
                        <div class="col-md-8">
                            <asp:TextBox ID="tenmathang" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="col-md-6 col-sm-12">
                    <div class="form-group row">
                        <label for="loaihang" class="col-md-4 col-form-label">Loại hàng</label>
                        <div class="col-md-8">
                            <asp:DropDownList ID="loaihang" CssClass="form-control" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                </div>

                <div class="col-md-6 col-sm-12">
                    <div class="form-group row">
                        <label for="soluongton" class="col-md-4 col-form-label">Số lượng tồn</label>
                        <div class="col-md-8">
                            <asp:TextBox ID="soluongton" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="col-md-6 col-sm-12">
                    <div class="form-group row">
                        <label for="dongia" class="col-md-4 col-form-label">Đơn giá</label>
                        <div class="col-md-8">
                            <asp:TextBox ID="dongia" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="col-md-6 col-sm-12">
                    <div class="form-group row">
                        <label for="dongia" class="col-md-4 col-form-label">Ảnh minh hoa</label>
                        <div class="col-md-8">
                            <div class="input-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text">Upload</span>
                                </div>
                                <div class="custom-file">
                                    <asp:FileUpload onchange="this.form.submit()" ID="fileUpload" CssClass="custom-file-input" runat="server" />
                                    <asp:TextBox ID="anhminhhoa1" class="custom-file-label" for="inputGroupFile01" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group-append">
                                    <span class="input-group-text">Upload</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col-md-6 col-sm-12 offset-md-2">
                    <asp:Button ID="sua" class="btn btn-info form-control col-md-4" runat="server" Text="Sửa" />
                    <asp:Button ID="xoa" class="btn btn-danger form-control col-md-4" runat="server" Text="Xóa" />
                </div>


                <div style="padding-bottom: 400px;">
                </div>


            </div>
        </div>

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
