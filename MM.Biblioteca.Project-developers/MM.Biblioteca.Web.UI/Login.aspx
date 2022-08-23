<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MM.Biblioteca.Web.UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />

    <title>BIBLIOTECA - Login</title>

    <!-- Custom fonts for this template-->
    <link href="../Theme/vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css" />
    <link
        href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"
        rel="stylesheet" />

    <!-- Custom styles for this template-->
    <link href="../Theme/css/sb-admin-2.min.css" rel="stylesheet" />

    <link rel="apple-touch-icon" sizes="180x180" href="../Theme/img/favicon/apple-touch-icon.png" />
    <link rel="icon" type="image/png" sizes="32x32" href="../Theme/img/favicon/favicon-32x32.png" />
    <link rel="icon" type="image/png" sizes="16x16" href="../Theme/img/favicon/favicon-16x16.png" />
    <link rel="manifest" href="../Theme/img/favicon/site.webmanifest" />


    <style>
        .area-login {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            justify-content: center;
            align-items: center;
        }

        .login {
            display: flex;
            flex-direction: column;
            align-items: center;
            background-color: #FFFFFF;
            width: auto;
            height: auto;
            padding: 35px;
            border-radius: 10px;
        }

            .login div {
                display: flex;
                width: 100%;
                flex-direction: column;
            }

            .login input {
                margin-top: 10px;
                background-color: #E8E8E8;
                color: #000000;
                padding-left: 10px;
                border: none;
                height: 45px;
                outline: none;
                border-radius: 8px;
                margin-bottom: 2%;
            }

        .Button {
            margin-top: 10px;
            background-color: #E8E8E8;
            color: #000000;
            padding-left: 10px;
            border: none;
            height: 45px;
            outline: none;
            border-radius: 8px;
        }

        .login img {
            width: auto;
            height: auto;
        }



        div [type="submit"] {
            display: block;
            background-color: #4E73DF;
            font-size: 20px;
            color: #FFFFFF;
            text-transform: uppercase;
            font-weight: bold;
            cursor: pointer;
            margin-top: 3%;
        }


       
    </style>

</head>
<body class="bg-gradient-primary">
    <form id="form1" runat="server">

        <section class="area-login">

            <div class="login">

                <div class="alert">
                    <img src="Theme/img/Design_sem_nome__1_-removebg-preview.png" />

                </div>



                <div method="POST">


                    
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="input label" TextMode="Email"  placeholder="Email..." required="true"></asp:TextBox>
                    
                    <asp:TextBox ID="txtSenha" runat="server" CssClass="input label" TextMode="Password"  placeholder="Senha..." required="true"></asp:TextBox>

                    

                    <div class="buttonn">
                        <asp:Button type="submit" runat="server" Text="Entrar" ID="btnSalvar" OnClick="btnSalvar_Click" />
                    </div>

                </div>
            </div>
        </section>
        <!-- Footer -->
        <footer class="bg-gradient-primary">
            <div class=" ">
                <div class="text-center" style="color: white">
                    <span>Copyright &copy; Alfredo Neto<span id="ano">2021</span></span>
                </div>
            </div>
        </footer>
        <!-- End of Footer -->
    </form>
</body>
<script>

    const ano = document.getElementById("ano");
    const anoAtual = new Date();
    ano.innerHTML = anoAtual.getFullYear();

</script>

</html>
