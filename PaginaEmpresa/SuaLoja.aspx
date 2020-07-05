<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaEmpresa/EmpresaLogada.master" AutoEventWireup="true" CodeFile="SuaLoja.aspx.cs" Inherits="PaginaEmpresa_SuaLoja" %>

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
                                <%--DropdownList--%>
                            </div>
                        </div>
                    </div>
                    <div class="row mt-5">
                        <asp:Repeater runat="server" ID="rptCard">
                            <ItemTemplate>
                                <div class="col-lg-4 col-md-6 mb-4">
                                    <div class="card h-100">
                                        <image src="<%#Eval("img_url") %>" class="img-responsive img-thumbnail"></image>
                                        <div class="card-body">
                                            <h2 class="card-title text-center">
                                                <%#Eval("pro_nome") %>  - <%#Eval("pro_valor") %>
                                            </h2>
                                            <h5></h5>
                                            <a href="Produto.aspx">
                                                <h5 class="text-center">Ver descrição </h5>
                                            </a>
                                            <p class="card-text"></p>
                                        </div>
                                        <div class="card-footer">
                                            <div class="row">
                                                <div class=" col-6">
                                                    <asp:Button Height="50px" Width="150px" runat="server" Text="EDITAR" CssClass="btn bt-primary btn-block"
                                                        BorderColor="black" BorderWidth="2px" BackColor="Yellow" ForeColor="black" OnClick="Unnamed_Click1" />

                                                </div>
                                                <div class=" col-6">
                                                    <asp:Button Height="50px" Width="150px" runat="server" Text="EXCLUIR" CssClass="btn bt-primary btn-block"
                                                        BorderColor="black" BorderWidth="2px" BackColor="Red" ForeColor="black" OnClick="Unnamed_Click" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                        <!-- INICIO DA MODAL EDITAR-->
                        <div class="modal" tabindex="-1" role="dialog" id="myModal2">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title">Cadastro</h5>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <div class="row">
                                            <asp:HiddenField runat="server" ID="hdUpdate" />
                                            <div class="col-12">
                                                <label>Nome:</label>
                                                <asp:TextBox runat="server" ID="txtNome" CssClass="form-control"></asp:TextBox>

                                            </div>
                                            <div class="col-12">
                                                <label>Caracteristica:</label>
                                                <asp:TextBox runat="server" ID="txtCaracteristica" CssClass="form-control"></asp:TextBox>

                                            </div>
                                             <div class="col-12">
                                                <label>Vencimento:</label>
                                                <asp:TextBox runat="server" ID="txtVencimento" type="date" CssClass="form-control"></asp:TextBox>

                                            </div>
                                             <div class="col-12">
                                                <label>Quantidade:</label>
                                                <asp:TextBox runat="server" ID="txtQuantidade" type="number"  min="0" CssClass="form-control"></asp:TextBox>

                                            </div>

                                        </div>

                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal">Sair</button>
                                        <button type="button" class="btn btn-success" data-dismiss="modal">Editar</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- FIM DA MODAL -->

                        <!-- INICIO DA MODAL DELETE -->
                        <div class="modal" tabindex="-1" role="dialog" id="myModal">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title">Cadastro</h5>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <p>
                                            <asp:Literal ID="ltl" runat="server"></asp:Literal>
                                        </p>
                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal">Sim</button>
                                        <button type="button" class="btn btn-success" data-dismiss="modal">Não</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- FIM DA MODAL -->
                    </div>
                </div>
            </div>
        </div>
        <!-- /.container -->
        <script src="../Scripts/jquery.min.js"></script>
        <script src="../Scripts/bootstrap.bundle.min.js"></script>
    </main>
</asp:Content>


