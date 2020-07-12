<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="PesquisadeProduto.aspx.cs" Inherits="Pag_Loja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <style>
        #LogoEmpresa.container-fluid {
            position: relative;
            text-align: center;
            color: white;
            font-size: 50px;
            font-family: 'Libre Baskerville', serif;
        }

        .centered {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
        }

        #LogoEmpresa img {
            filter: brightness( 30% );
        }
    </style>

    <main>
        <!-- Page Content -->
        <div class="container">
            <div class="row">
                <!-- Imagem da Fachada -->
                <div class="col-lg-12 mt-2">
                    <div id="LogoEmpresa" class="container-fluid">
                        <img src="../Imagem/4.jpg" alt="Snow" style="width: 100%;">
                        <asp:Label runat="server" ID="LogoNome" CssClass="centered"></asp:Label>
                    </div>

                    <div class="mt-5 mb-3">
                        <div class="row">
                            <h1>Produtos</h1>
                            <hr />
                        </div>
                    </div>
                    <div class="row mt-5">
                        <asp:Repeater runat="server" ID="rptCard">
                            <ItemTemplate>
                                <div class="col-lg-4 col-md-6 mb-4">
                                    <div style="border-radius: 20px;" class="shadow-lg card h-100">
                                        <image src="<%#Eval("img_url") %>" style="border-radius: 20px 20px 0 0" class="card-img-top img-responsive img-thumbnail"></image>
                                        <div class="card-body text-center">
                                            <p class="card-title">
                                                <asp:Label runat="server"><%#Eval("pro_nome") %><br /></asp:Label>
                                            </p>
                                            <h5>
                                                <asp:Label runat="server">R$ <%#Eval("pro_valor") %></asp:Label>
                                            </h5>
                                            <a href="Produto.aspx?id=<%#Eval("pro_id") %>&nome=pro">Ver descrição</a>
                                            <p class="card-text"></p>
                                        </div>
                                        <div class="card-footer">
                                            <div class="row">
                                                <div class=" col-md-12">
                                                    <asp:Button runat="server" Width="49%" Text="Carrinho" CssClass="btn bt-primary"
                                                        BorderColor="black" BorderWidth="2px" BackColor="blue" ForeColor="black" />

                                                    <asp:Button runat="server" Width="49%" Text="Comprar" ID="btnComprar" CssClass="btn bt-primary"
                                                        BorderColor="black" BorderWidth="2px" BackColor="green" ForeColor="black" OnClick="btnComprar_Click" />

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>



                    <div class="mt-5 mb-3">
                        <div class="row">
                            <h1>Serviços</h1>
                            <hr />
                        </div>
                    </div>
                    <div class="row mt-5">
                        <asp:Repeater runat="server" ID="rptCardServico">
                            <ItemTemplate>
                                <div class="col-lg-4 col-md-6 mb-4">
                                    <div style="border-radius: 20px;" class="shadow-lg card h-100">
                                        <image src="<%#Eval("img_url") %>" style="border-radius: 20px 20px 0 0" class="card-img-top img-responsive img-thumbnail"></image>
                                        <div class="card-body text-center">
                                            <p class="card-title">
                                                <asp:Label runat="server"> <%#Eval("ser_nome")%></asp:Label>
                                            </p>
                                            <h5>
                                                <asp:Label runat="server">R$ <%#Eval("ser_valor")%> </asp:Label>
                                            </h5>
                                            <a href="Produto.aspx?id=<%#Eval("ser_id") %>&nome=ser">Ver descrição</a>
                                            <p class="card-text"></p>
                                        </div>
                                        <div class="card-footer">
                                            <div class="row">
                                                <div class=" col-md-12">
                                                    <asp:Button runat="server" Width="49%" Text="Carrinho" CssClass="btn bt-primary"
                                                        BorderColor="black" BorderWidth="2px" BackColor="blue" ForeColor="black" />

                                                    <asp:Button runat="server" Width="49%" Text="Comprar" ID="btnComprar" CssClass="btn bt-primary"
                                                        BorderColor="black" BorderWidth="2px" BackColor="green" ForeColor="black" OnClick="btnComprar_Click" />

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
        <!-- /.container -->
        <script src="../Scripts/jquery.min.js"></script>
        <script src="../Scripts/bootstrap.bundle.min.js"></script>
    </main>
</asp:Content>



