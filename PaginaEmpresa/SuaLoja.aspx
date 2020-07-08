<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaEmpresa/EmpresaLogada.master" AutoEventWireup="true" CodeFile="SuaLoja.aspx.cs" Inherits="PaginaEmpresa_SuaLoja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <style>
        #LogoEmpresa.container-fluid {
            position: relative;
            text-align: center;
            color: white;
            font-size: 50px;
        }

        .centered {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
        }
        #LogoEmpresa img{
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

                            <h3>Produtos</h3>

                            <hr />
                            <div class="col-3">
                                <%--DropdownList--%>
                            </div>
                        </div>
                    </div>

                    <div class="row mt-5">
                        <asp:Repeater runat="server" ID="rptCardProduto">
                            <ItemTemplate>
                                <div class="col-lg-4 col-md-6 mb-4">
                                    <div style="border-radius: 20px;" class="shadow-lg card h-100">
                                        <image src="<%#Eval("img_url") %>" class="img-responsive img-thumbnail" style="border-radius: 20px 20px 0 0"></image>
                                        <div class="card-body text-center">
                                            <h5 class="card-title">
                                                <asp:Label runat="server"><%#Eval("pro_nome") %><br />R$ <%#Eval("pro_valor") %></asp:Label>
                                            </h5>
                                            <h5></h5>
                                            <a href="#">
                                                <h5>Ver descrição </h5>
                                            </a>
                                            <p class="card-text"></p>
                                        </div>
                                        <div class="card-footer">
                                            <div class="row">
                                                <div class=" col-md-12">
                                                    <asp:Button Width="49%" ID="btnUpdate" runat="server" Text="EDITAR" CssClass="btn bt-primary"
                                                        BorderColor="black" BorderWidth="2px" BackColor="Yellow" ForeColor="black" OnClick="btnUpdate_Click"
                                                        CommandArgument='<%#Eval("pro_nome")+"|"+ Eval("pro_tipo")+"|"+Eval("pro_vencimento")+"|"
                                                            + Eval("pro_quantidade") +"|"+Eval("pro_valor") +"|"+ Eval("pro_id")+"|"+ Eval("pro_caracteristica")+"|"
                                                            + Eval("pro_descricao") %>' />

                                                    <asp:Button Width="49%" ID="btnDelete" runat="server" Text="EXCLUIR" CssClass="btn bt-primary"
                                                        BorderColor="black" BorderWidth="2px" BackColor="Red" ForeColor="black" OnClick="btnDelete_Click"
                                                        CommandArgument='<%#Eval("pro_nome")+"|"+ Eval("pro_id") %>' />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>

                    <!-- LISTA DE SERVIÇOS-->
                    <div class="col-12">
                        <h3>Serviço</h3>
                        <hr />
                    </div>
                    <!-- INICIAL REPEATER SERVIÇO-->
                    <div class="row mt-5">
                        <asp:Repeater runat="server" ID="rptCardServico">
                            <ItemTemplate>
                                <div class="col-lg-4 col-md-6 mb-4">
                                    <div style="border-radius: 20px;" class="shadow-lg card h-100">
                                        <image src="<%#Eval("img_url") %>" class="img-responsive img-thumbnail" style="border-radius: 20px 20px 0 0"></image>
                                        <div class="card-body text-center">
                                            <h5 class="card-title ">
                                                <asp:Label runat="server">  <%#Eval("ser_nome") %><br />R$ <%#Eval("ser_valor") %></asp:Label>
                                            </h5>
                                            <h5></h5>
                                            <a href="Produto.aspx">
                                                <h5>Ver descrição </h5>
                                            </a>
                                            <p class="card-text"></p>
                                        </div>
                                        <div class="card-footer">
                                            <div class="row">
                                                <div class=" col-md-12">
                                                    <asp:Button Width="49%" ID="btnUpdateServico" runat="server" Text="EDITAR" CssClass="btn bt-primary"
                                                        BorderColor="black" BorderWidth="2px" BackColor="Yellow" ForeColor="black" OnClick="btnUpdateServico_Click"
                                                        CommandArgument='<%#Eval("ser_nome")+"|"+ Eval("ser_descricao")+"|"+Eval("ser_caracteristica")+"|"+ Eval("ser_valor") +"|"+ Eval("ser_id")%>' />

                                                    <asp:Button Width="49%" ID="btnDeleteServico" runat="server" Text="EXCLUIR" CssClass="btn bt-primary"
                                                        BorderColor="black" BorderWidth="2px" BackColor="Red" ForeColor="black" OnClick="btnDeleteServico_Click"
                                                        CommandArgument='<%#Eval("ser_nome")+"|"+ Eval("ser_id") %>' />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <!--Final Repeater-->

                    <!-- INICIO DA MODAL DELETE SERVICO -->
                    <div class="modal" tabindex="-1" role="dialog" id="myModalDeleteServico1">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title">Delete</h5>
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                </div>
                                <div class="modal-body">
                                    <p>
                                        <asp:Literal ID="ltlDeleteServico" runat="server"></asp:Literal>
                                    </p>
                                </div>
                                <div class="modal-footer">
                                    <div class="col-12">
                                        <asp:TextBox runat="server" ID="txtNomeServicoDelete" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                                    </div>

                                    <asp:Button ID="btnExcluirServico" runat="server" Text="Sim" CssClass="alert-danger btn" OnClick="btnExcluirServico_Click" />

                                    <button type="button" class="btn btn-success" data-dismiss="modal">Não</button>

                                    <asp:TextBox runat="server" ID="txtDeleteID" value="Atualizar" CssClass="form-control" Style="display: none"></asp:TextBox>

                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- FIM DA MODAL -->


                    <!-- MODAL SERVIÇO UPDATE INICIO -->
                    <div class="modal" tabindex="-1" role="dialog" id="myModalUpdateServico">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title">Update</h5>
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                </div>

                                <div class="modal-body">

                                    <div class="row">
                                        <asp:Literal ID="ltlUpdateServico" runat="server"></asp:Literal>

                                        <asp:HiddenField runat="server" ID="hdUpdateServico" />

                                        <div class="col-12">
                                            <label>Nome:</label>
                                            <asp:TextBox runat="server" ID="txtNomeUpateServico" CssClass="form-control"></asp:TextBox>
                                        </div>

                                        <div class="col-12">
                                            <label>Descrição:</label>
                                            <asp:TextBox runat="server" ID="txtDescricaoUpdateServico" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                        </div>

                                        <div class="col-12">
                                            <label>Caracteristica:</label>
                                            <asp:TextBox runat="server" ID="txtCaracteristicaUpdateServico" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                        </div>


                                        <div class="col-12">
                                            <label>Valor:</label>
                                            <asp:TextBox runat="server" ID="txtValorUpdateServico" CssClass="form-control"></asp:TextBox>
                                        </div>

                                        <asp:TextBox runat="server" ID="txtServicoID" CssClass="form-control" Style="display: none"></asp:TextBox>

                                    </div>

                                </div>
                                <div class="modal-footer">
                                    <asp:Button runat="server" Text="Salvar" CssClass="btn btn-info" ID="Button1" OnClick="btnUpdateServico_Click1" />
                                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- MODAL SERVIÇO UPDATE FINAL -->


                    <!-- INICIO DA MODAL EDITAR produto-->
                    <div class="modal" tabindex="-1" role="dialog" id="myModalUpdate">
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
                                        <asp:Literal ID="ltlUpdate" runat="server"></asp:Literal>

                                        <asp:HiddenField runat="server" ID="hdUpdate" />

                                        <div class="col-12">
                                            <label>Nome:</label>
                                            <asp:TextBox runat="server" ID="txtNome" CssClass="form-control"></asp:TextBox>
                                        </div>

                                        <div class="col-12">
                                            <label>Descrição:</label>
                                            <asp:TextBox runat="server" ID="txtDescricao" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                        </div>

                                        <div class="col-12">
                                            <label>Caracteristica:</label>
                                            <asp:TextBox runat="server" ID="txtCaracteristica" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                        </div>

                                        <div class="col-12">
                                            <label>Categoria:</label>
                                            <asp:TextBox runat="server" ID="txtTipo" CssClass="form-control"></asp:TextBox>

                                        </div>

                                        <div class="col-12">
                                            <label>Vencimento:</label>
                                            <asp:TextBox runat="server" ID="txtVencimento" CssClass="form-control"></asp:TextBox>
                                        </div>

                                        <div class="col-12">
                                            <label>Quantidade:</label>
                                            <asp:TextBox runat="server" ID="txtQuantidade" type="number" min="0" CssClass="form-control"></asp:TextBox>
                                        </div>

                                        <div class="col-12">
                                            <label>Valor:</label>
                                            <asp:TextBox runat="server" ID="txtValor" CssClass="form-control"></asp:TextBox>
                                        </div>

                                        <asp:TextBox runat="server" ID="txtPro_id" CssClass="form-control" Style="display: none"></asp:TextBox>

                                    </div>

                                </div>
                                <div class="modal-footer">
                                    <asp:Button runat="server" Text="Salvar" CssClass="btn btn-info" ID="btn_Salvar" OnClick="btn_Salvar_Click" />
                                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- FIM DA MODAL -->

                    <!-- INICIO DA MODAL DELETE -->
                    <div class="modal" tabindex="-1" role="dialog" id="myModalDelete">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title">Delete</h5>
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                </div>
                                <div class="modal-body">
                                    <p>
                                        <asp:Literal ID="ltlDelete" runat="server"></asp:Literal>
                                    </p>
                                </div>
                                <div class="modal-footer">
                                    <div class="col-12">
                                        <asp:TextBox runat="server" ID="txtNomeProduto" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                                    </div>

                                    <asp:Button ID="btnExcluir" runat="server" Text="Sim" CssClass="alert-danger btn" OnClick="btnExcluir_Click" />

                                    <button type="button" class="btn btn-success" data-dismiss="modal">Não</button>

                                    <asp:TextBox runat="server" ID="txtPro_id2" value="Atualizar" CssClass="form-control" Style="display: none"></asp:TextBox>

                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- FIM DA MODAL -->
                </div>
            </div>
        </div>
        <!-- /.container -->
        <script src="../Scripts/jquery.min.js"></script>
        <script src="../Scripts/bootstrap.bundle.min.js"></script>
    </main>
</asp:Content>
