<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loging.aspx.cs" Inherits="INVENTORY_SYSTEM.Loging" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>SCHOOL | Dashboard</title>

  <!-- Google Font: Source Sans Pro -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"/>
  <!-- Font Awesome -->
  <link rel="stylesheet" href="plugins/fontawesome-free/css/all.min.css"/>
  <!-- Ionicons -->
  <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"/>
  <!-- Tempusdominus Bootstrap 4 -->
  <link rel="stylesheet" href="plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css"/>
  <!-- iCheck -->
  <link rel="stylesheet" href="plugins/icheck-bootstrap/icheck-bootstrap.min.css"/>
  <!-- JQVMap -->
  <link rel="stylesheet" href="plugins/jqvmap/jqvmap.min.css"/>
  <!-- Theme style -->
  <link rel="stylesheet" href="dist/css/adminlte.min.css"/>
  <!-- overlayScrollbars -->
  <link rel="stylesheet" href="plugins/overlayScrollbars/css/OverlayScrollbars.min.css"/>
  <!-- Daterange picker -->
  <link rel="stylesheet" href="plugins/daterangepicker/daterangepicker.css"/>
  <!-- summernote -->
  <link rel="stylesheet" href="plugins/summernote/summernote-bs4.min.css"/>
</head>
<body class="hold-transition login-page">
    <form id="form1" runat="server">
       <div class="card-body login-card-body">
          <p class="login-box-msg">Loging form</p>

          <form action="../../index3.html" method="post">
              <div class="input-group mb-3">
                  <input type="email" class="form-control" placeholder="Email">
                  <div class="input-group-append">
                      <div class="input-group-text">
                          <span class="fas fa-envelope"></span>
                      </div>
                  </div>
              </div>
              <div class="input-group mb-3">
                  <input type="password" class="form-control" placeholder="Password">
                  <div class="input-group-append">
                      <div class="input-group-text" id="txtuser">
                          <span class="fas fa-lock"></span>
                      </div>
                  </div>
              </div>
              <div class="row">
                  <div class="col-8">
                      <div class="icheck-primary">
                          <input type="checkbox" id="remember">
                          <label for="remember">
                              Remember Me
                             
                 <asp:Button ID="btnloging" CssClass="btn btn-primary" runat="server" Text="Loging" />
                          </label>  
                      </div>
                  </div>
                 
              </div>
          </form>
  </div>
    </form>
</body>
</html>
