<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaClinicaWebForms.Login" %>

<!DOCTYPE html>

<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Acesso ao sistema da clínica</title>
    <link href="//maxcdn.bootstrapcdn.com7bootstrap/3.2.0/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="//cdnjs.clouflare.com/ajax/libs/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="css/AdminLTE.css" rel="stylesheet" type="text/css" />
</head>
<body class="bg-black">
    <div class="form-box" id="login-box">
        <div class="header">Iniciar sessão</div>
        <form id="form1" runat="server">
            <div class="body bg-gray">
                <div class="form-group" style="height: 28px">
                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Usuário" Width="306px" Height="27px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Senha" Width="306px" Height="28px"></asp:TextBox>
                </div>
            </div>
            <div class="footer" style="height: 32px" >
                <asp:Button ID="btnEntrar" runat="server" Text="Iniciar sessão" CssClass="btn bg-olive btn-block" Width="136px" Height="31px" style="margin-left: 91px" />
            </div>
        </form>
    </div>
    <script src="//ajax.googleapis.com/ajax/libs/jquery.min.js"></script>
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js" type="text/javascript"></script>
</body>
</html>
