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

        .inline {
            display: inline-block;
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


                    <div class="row text-center mt-5">

                        <div class="col-1"></div>
                        <div class="col-3">
                            <div class="input-group">
                                <input class="form-control" placeholder="pesquisa de produtos" type="text" id="search" />
                                <div class="input-group-append">
                                    <div class="input-group-text" style="background-color: #FFF"><i class="fas fa-search"></i></div>
                                </div>
                            </div>
                        </div>

                        <div class="col-3"></div>
                        <div class="col-5">
                            <p id="ord" class="inline"><b>Ordenar por: </b></p>
                            <button id="btn" class="btn-sm btn-light inline" onclick="return false;">Ordenar A-Z</button>
                            <button id="btn2" class="btn-sm btn-light inline" onclick="return false;">Ordenar Z-A</button>
                        </div>
                    </div>

                    <div class="mt-5 mb-3">
                        <div class="row">
                            <h1>Produtos</h1>
                            <hr />
                        </div>
                    </div>

                    <div id="ordenar" class="row mt-5">
                        <asp:Repeater runat="server" ID="rptCard">
                            <ItemTemplate>

                                <div data-nome="<%#Eval("pro_nome") %>" class="produto content col-lg-3 col-md-6 mb-4">

                                    <div style="border-radius: 20px;" class="shadow-lg card h-100">
                                        <image src="<%#Eval("img_url") %>" style="border-radius: 20px 20px 0 0" class="card-img-top img-responsive img-thumbnail"></image>
                                        <div class="card-body text-center nome">
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
                                <div class="col-lg-3 col-md-6 mb-4">
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


        <script>
            $(document).ready(function () {
                $('#search').keyup(function () {

                    // Search text
                    var text = $(this).val();
                    // Hide all content class element
                    $('.content').hide();
                    // Search 
                    $('.content .nome:contains("' + text + '")').closest('.content').show();
                });
            });
            $.expr[":"].contains = $.expr.createPseudo(function (arg) {
                return function (elem) {
                    return $(elem).text().toUpperCase().indexOf(arg.toUpperCase()) >= 0;
                };
            });
        </script>

        <script>
            $('#btn').on('click', function () {
                $('.produto').sort(function (a, b) {
                    if (a.dataset.nome < b.dataset.nome) {
                        return -1;
                    } else {
                        return 1;
                    }
                }).appendTo('#ordenar');
            });

            $('#btn2').on('click', function () {
                $('.produto').sort(function (a, b) {
                    if (a.dataset.nome > b.dataset.nome) {
                        return -1;
                    } else {
                        return 1;
                    }
                }).appendTo('#ordenar');
            });
        </script>
    </main>
</asp:Content>



