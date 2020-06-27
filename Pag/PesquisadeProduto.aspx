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
                            <div class="col-3">
                                <asp:DropDownList ID="ddl" CssClass="form-control" AutoPostBack="true"
                                    OnSelectedIndexChanged="ddl_SelectedIndexChanged" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="row mt-5">
                        <asp:Repeater runat="server" ID="rptCard">
                            <ItemTemplate>
                                <div class="col-lg-4 col-md-6 mb-4">
                                    <div class="card h-100">
                                        <%#Eval("img_url") %>
                                        <div class="card-body">
                                            <h2 class="card-title text-center">
                                                <%#Eval("pro_nome") %>  - <%#Eval("pro_valor") %>
                                            </h2>
                                            <h5></h5>
                                            <a href="#">
                                                <h5 class="text-center">Ver descrição </h5>
                                            </a>
                                            <p class="card-text"></p>
                                        </div>
                                        <div class="card-footer">
                                            <div class="row">
                                                <div class=" col-6">
                                                    <asp:ImageButton runat="server" ImageUrl="../Imagem/126510.png" Width="150px" Height="50px" CssClass="btn bt-primary btn-block"
                                                        BorderColor="black" BorderWidth="2px" BackColor="blue" ForeColor="black" />
                                                </div>
                                                <div class=" col-6">
                                                    <asp:Button Height="50px" Width="150px" runat="server" Text="COMPRAR" CssClass="btn bt-primary btn-block"
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



