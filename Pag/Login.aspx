<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pag_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="container mt-5">
        <div class="row">
            <div class="col-5">
                <h3 class="text-center">Login</h3>
                <hr />
                <div class="row">
                    <div class="col-2"></div>
                    <div class="col-10 mt-2">
                        <h4 class="text-center">Usuario ou Email</h4>
                    </div>
                </div>
                <div class="row">
                    <div class="col-2">
                        <img src="../Icons/iconeUsuario.png" />
                    </div>
                    <div class="col-10">
                        <asp:TextBox runat="server" ClientIDMode="Static" required="required" type="email"
                            ID="txtUsuario" placeholder="exemplo@email.com" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-2 "></div>
                    <div class="col-10 mt-3">
                        <h4 class="text-center">Senha</h4>
                    </div>
                </div>
                <div class="row">
                    <div class="col-2">
                        <img src="../Icons/password.png" />
                    </div>
                    <div class="col-10">
                        <table>
                            <asp:TextBox runat="server" ClientIDMode="Static" required="required" type="password"
                                ID="txtSenha" placeholder="******" CssClass="form-control"></asp:TextBox>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-2"></div>
                    <div class="col-10"><a href="#">Esqueci minha senha</a></div>
                </div>

                <div class="row">
                    <div class="col-2"></div>
                    <div class="col-10 mt-4">
                        <asp:Button ClientIDMode="Static" runat="server" Text="Entrar" ID="btnSalvar" ForeColor="black"
                            BorderColor="orange" BorderWidth="5px" BackColor="white" CssClass="btn btn-primary btn-block" OnClick="btnSalvar_Click"/>
                    </div>
                </div>


            </div>

            <div class="col-2">
                <div class="box">
                </div>
                <div class="box linha-vertical">
                </div>
            </div>

            <div class="col-5">
                <h2 class="text-center">Novo por aqui?
                </h2>

                <hr />
                <div class="row">
                    <div class="col-2 "></div>
                    <div class="col-8 mt-4">
                        <asp:Button ClientIDMode="Static" runat="server" Text="Cadastrar" ID="btnCadastrar"
                            CssClass="btn btn-primary btn-block" BorderWidth="5px" ForeColor="Black" BorderColor="orange"
                            BackColor="white" OnClientClick="javascript:window.location.href='Cadastro.aspx'; return false;" />
                    </div>
                </div>


            </div>
        </div>
    </section>

</asp:Content>

