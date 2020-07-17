﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="PesquisadeLoja.aspx.cs" Inherits="Pag_PesquisadeLoja" %>

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
                            <div class="col-3">
                            </div>
                            <div class="col-7"></div>
                            <div class="col-1">
<%--                                <asp:TextBox runat="server" ID="textBusca"></asp:TextBox>--%>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <asp:Repeater runat="server" ID="rptCard">
                            <ItemTemplate>
                                <div class="col-lg-4 col-md-6 mb-4">
                                    <div style="border-radius: 20px;" class="shadow-lg card h-100">
                                        <img style="border-radius: 20px 20px 0 0" src="http://placehold.it/200x250">
                                        <div class="card-body">
                                            <h4 class="card-title">
                                                <a href="PesquisadeProduto.aspx?id=<%#Eval("emp_id")%>&nome=<%#Eval("emp_nome_fantasia")%> ">
                                                    <%#Eval("emp_nome_fantasia")%>
                                                </a>
                                            </h4>
                                            <h5>Entrega: R$ 10.00</h5>
                                            <h5>Distancia: 8,2 km </h5>
                                            <h5>Tempo de Entregua: 10 - 20 min</h5>
                                            <p class="card-text"></p>
                                        </div>
                                        <div class="card-footer">
                                            <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
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

        <!-- Bootstrap core JavaScript -->
        <script src="../Scripts/jquery.min.js"></script>
        <script src="../Scripts/bootstrap.bundle.min.js"></script>
    </main>
</asp:Content>

