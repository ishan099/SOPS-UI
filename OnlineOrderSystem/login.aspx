    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="OnlineOrderSystem.login" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Login</title>
    </head>
    <link rel="stylesheet" type="text/css" href="bower_components/bootstrap/dist/css/bootstrap.css" />
    <link href="bower_components/notie/dist/notie.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="assets/css/customer.css" />
    <link rel="stylesheet" type="text/css" href="assets/css/login.css" />
    <body>
        <form id="form1">
            <div class="col-lg-4 col-md-offset-4">
                <h1 class="login-header">Smart Order Placing System</h1>
                <div class="login-wrapper">

                    <form>
                        <div class="form-group">
                            <label for="exampleInputEmail1">User Name</label>
                            <input  type="text" class="form-control" id="userName" placeholder="User Name">
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Password</label>
                            <input type="password" class="form-control" id="password" placeholder="Password">
                        </div>

                        <div class="checkbox">
                            <label>
                                <input type="checkbox">
                                Remember me
                            </label>
                        </div>
                        <span id="loginBtn" class="btn btn-default login-btn">Login</span>
                    </form>
                </div>


            </div>
        </form>
    </body>

    <script type='text/javascript' src="bower_components/jquery/dist/jquery.js"></script>
    <script type='text/javascript' src="bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
    <script type='text/javascript' src="bower_components/notie/dist/notie.min.js"></script>
    <script type='text/javascript' src="assets/js/main.js"></script>
    <script type='text/javascript' src="assets/js/login.js"></script>
    </html>
