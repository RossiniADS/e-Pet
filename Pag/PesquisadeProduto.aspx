<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="PesquisadeProduto.aspx.cs" Inherits="Pag_Loja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main>
        <!-- Page Content -->
        <div class="container">
            <div class="row">
                <!-- /.col-lg-3 -->
                <div class="col-lg-12">
                    <div id="carouselExampleIndicators" class="carousel slide my-4" data-ride="carousel">
                        <ol class="carousel-indicators">
                            <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                            <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                        </ol>
                        <div class="carousel-inner" role="listbox">
                            <div class="carousel-item active">
                                <img class="d-block img-fluid" src="http://placehold.it/900x350" alt="First slide">
                            </div>
                            <div class="carousel-item">
                                <img class="d-block img-fluid" src="http://placehold.it/900x350" alt="Second slide">
                            </div>
                            <div class="carousel-item">
                                <img class="d-block img-fluid" src="http://placehold.it/900x350" alt="Third slide">
                            </div>
                        </div>
                        <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="sr-only">Previous</span>
                        </a>
                        <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="sr-only">Next</span>
                        </a>
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
                                    <div style="border-radius:20px;" class="shadow-lg card h-100">
                                        <image src="<%#Eval("img_url") %>" style="border-radius:20px 20px 0 0" class="card-img-top img-responsive img-thumbnail"></image>
                                        <div class="card-body text-center">
                                            <h5 class="card-title">
                                                <asp:Label runat="server"><%#Eval("pro_nome") %><br />R$ <%#Eval("pro_valor") %></asp:Label>
                                            </h5>
                                            <h5></h5>
                                            <a href="Produto.aspx?id=<%#Eval("pro_id") %>">Ver descrição</a>
                                            <p class="card-text"></p>
                                        </div>
                                        <div class="card-footer">
                                            <div class="row">
                                                <div class=" col-md-12">
                                                    <asp:Button runat="server" Width="49%" Text="Carrinho" CssClass="btn bt-primary"
                                                        BorderColor="black" BorderWidth="2px" BackColor="blue" ForeColor="black" />

                                                    <asp:Button runat="server" Width="49%" Text="Comprar" CssClass="btn bt-primary"
                                                        BorderColor="black" BorderWidth="2px" BackColor="green" ForeColor="black" />
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



