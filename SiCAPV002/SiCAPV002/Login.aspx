<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SiCAPV002.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <title>Sing In</title>


    <link href="bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet"/>

    <link href="bower_components/metisMenu/dist/metisMenu.min.css" rel="stylesheet"/>
        
       
    <link href="css/login.css" rel="stylesheet" />
    <link href="bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css"/>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    </head>
    <body>
    <div>
    <nav class="navbar navbar-default navbar-static-top" role="navigation" style="margin-bottom: 0"/>
  </div>
         <br />
    <br />
     <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <div class="login-panel panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">Iniciar Sesión
                            
                        </h3>
                    </div>
                    <div class="panel-body">
                        <form id="form1" runat="server">
                            <fieldset>
                                <div class="form-group">
                                    <asp:TextBox ID="Email" runat="server" CssClass="textbox1" ></asp:TextBox>
                                </div>
                                <div class="form-group">
                     
                                   <asp:TextBox ID="Password" runat="server" CssClass="textbox1" TextMode="Password"></asp:TextBox>
                                
                                        </div>
                                <div class="checkbox">
                                    <center><label>
                                        <input name="remember" type="checkbox" value="Remember Me"/>Remember Me 
                                    </label></center>
                                    <br />
                                </div>
                                <!-- Change this to a button or input when using this as a form -->
                               <center> <asp:Label ID="LblLogin" runat="server" Text=""></asp:Label></center>
                            </fieldset>
                           <center><input type="button"  id="btnLogi" runat="server" value="ingresar" class="btn btn-success" /></center></form>
                    </div>
                </div>
            </div
        </div>
    </div>
     
    <!-- jQuery -->
    <script src="../bower_components/jquery/dist/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="../bower_components/bootstrap/dist/js/bootstrap.min.js"></script>

    <!-- Metis Menu Plugin JavaScript -->
    <script src="../bower_components/metisMenu/dist/metisMenu.min.js"></script>

    <!-- Custom Theme JavaScript -->
    <script src="../dist/js/sb-admin-2.js"></script>

</body>
</html>
