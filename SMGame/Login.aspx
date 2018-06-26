<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SMGame.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   

    <link href="~/Content/cHin-Grid/cHiN-GRID.css" type="text/css" rel="stylesheet" />
    <link href="Content/AdminLTE/AdminLTE.css" rel="stylesheet" />
    <link href="Content/AdminLTE/skin-green.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style>
        .sideBackground {
            background: url('../Content/images/green-style-vector.jpg');
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: 100% auto;
        }
       

        /*.layer {
            background-color: rgba(0, 128, 132, 0.53);
            /*position: absolute;
            top: 0;
            left: 0;*
            width: 100%;
            height: 100%;
        }*/
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                <h2>login</h2>
                <div class="row">
                    <div class="col-lg-10 col-md-10">
                        <div class="input-group">
                            <span class="input-group-addon" id="basic-addon1">User Name</span>
                            <asp:TextBox runat="server" id="txtLgUserName" class="form-control" placeholder="UserName" aria-describedby="basic-addon1"/>
                        </div>
                        <br />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-10 col-md-10">
                        <div class="input-group">
                            <span class="input-group-addon" id="basic-addon1">Password</span>
                            <asp:TextBox runat="server" type="password" id="txtLgPassword" class="form-control" placeholder="Password" aria-describedby="basic-addon1"/>
                        </div>
                        <br />
                    </div>
                </div>
                    <span runat="server" id="lblError" class="input-group-addon" style="display:none" ></span>
                <div class="row">
                    <div class="col-lg-3 col-md-3">
                          <asp:Button runat="server" ID="btnLogin" Text="Login" CssClass="btn btn-success" style="width: 90%" OnClick="btnLogin_Click" />
                     <%--   <input type="button" id="btnLogin" value="Login" class="btn btn-success" style="width: 90%" />--%>
                    </div>
                    <div class="col-lg-3 col-md-3">
                          <asp:Button runat="server" ID="btnClear" Text="Clear" CssClass="btn btn-success" style="width: 90%" OnClick="btnClear_Click"  />
                       <%-- <input type="button" id="btnClear" value="Clear" class="btn btn-success" style="width: 90%" />--%>
                    </div>
                </div>
            </div>
           
            <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                <h2>SingUp</h2>
                <div class="row">
                    <div class="col-lg-10 col-md-10">
                        <div class="input-group">
                            <span class="input-group-addon" id="basic-addon1">User Name</span>
                             <asp:TextBox runat="server" id="txtRgUserName" class="form-control" placeholder="User Name" aria-describedby="basic-addon1"/>
                        </div>
                        <br />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-10 col-md-10">
                        <div class="input-group">
                            <span class="input-group-addon" id="basic-addon1">Email</span>
                             <asp:TextBox runat="server" id="txtRgEmail" class="form-control" placeholder="Email" aria-describedby="basic-addon1"/>
                        </div>
                        <br />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-10 col-md-10">
                        <div class="input-group">
                            <span class="input-group-addon" id="basic-addon1">Password</span>
                             <asp:TextBox runat="server" type="password" id="txtRgPassword" class="form-control" placeholder="Password" aria-describedby="basic-addon1"/>
                        </div>
                        <br />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-10 col-md-10">
                        <div class="input-group">
                            <span class="input-group-addon" id="basic-addon1">Confirm Password</span>
                             <asp:TextBox runat="server" type="password"  id="txtRgCmPassword" class="form-control" placeholder="Confirm Password" aria-describedby="basic-addon1"/>
                        </div>
                        <br />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-10 col-md-10">
                        <div class="input-group">
                            <span class="input-group-addon" id="basic-addon1">Bank Name</span>
                             <asp:TextBox runat="server" id="txtBankName" class="form-control" placeholder="Bank Name" aria-describedby="basic-addon1"/>
                        </div>
                        <br />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-10 col-md-10">
                        <div class="input-group">
                            <span class="input-group-addon" id="basic-addon1">Account Number</span>
                             <asp:TextBox runat="server" id="txtAccountNo" class="form-control" placeholder="Account Number" aria-describedby="basic-addon1" />
                        </div>
                        <br />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-3 col-md-3">
                        <asp:Button runat="server" ID="btnRegister" Text="Register" CssClass="btn btn-success" style="width: 90%" OnClick="btnRegister_Click"  />
                       <%-- <input type="button" id="btnRegister" value="Register" class="btn btn-success" style="width: 90%" />--%>
                    </div>
                    <div class="col-lg-3 col-md-3">
                        <asp:Button runat="server" ID="btnCancel" Text="Cancel" CssClass="btn btn-success" style="width: 90%" OnClick="btnCancel_Click"  />
                        <%--<input type="button" id="btnCancel" value="Cancel" class="btn btn-success" style="width: 90%" />--%>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>