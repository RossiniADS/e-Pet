<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="MeiosPagamento.aspx.cs" Inherits="PaginaCliente_Meios_de_pagamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container">
        <div class="row">
            <div class="mt-5 ml-4">
                <h5>Pagamentos</h5>
            </div>
            <hr />

            <div class="col-2"></div>
            <div class="col-8">
                <label>Nome impresso no cartão</label>
                <asp:TextBox runat="server" ID="textNome" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2"></div>

            <div class="col-2"></div>
            <div class="col-8">
                <label>CPF do titular do cartão</label>
                <asp:TextBox runat="server" ID="textCPF" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
            </div>
            <div class="col-2"></div>


            <div class="col-2"></div>
            <div class="col-8">
                <label>Numero do cartão</label>
                <asp:TextBox runat="server" ID="textNumero" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2"></div>

            <div class="col-2"></div>
            <div class="col-8">
                <label>Data de vencimento</label>
                <asp:TextBox runat="server" ID="textData" type="Date" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2"></div>

            <div class="col-2"></div>
            <div class="col-8">
                <label>CVC</label>
                <asp:TextBox runat="server" ID="textCVC" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2"></div>


            <div class="col-8"></div>
            <div class="col-2 mt-5">
                <asp:Button runat="server" Text="Adicionar" ID="Salvar" CssClass="btn btn-block btn-primary"
                    OnClick="Salvar_Click" BorderWidth="5px" ForeColor="Black" BorderColor="orange" BackColor="white"></asp:Button>
            </div>
            <div class="col-2"></div>
        </div>


        <asp:GridView ID="grid" runat="server" CssClass="table table-hover text-center table-striped mt-5"
            OnRowCommand="grid_RowCommand"
            AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="car_id" />
                <asp:BoundField DataField="car_nome" HeaderText="Nome" />
                <asp:BoundField DataField="car_cpf" HeaderText="CPF" />
                <asp:BoundField DataField="car_num" HeaderText="NUMERO" />
                <asp:BoundField DataField="car_data_vencimento" HeaderText="DATA VENCIMENTO" />
                <asp:BoundField DataField="car_cod_seguranca" HeaderText="CVC" />
                <asp:ButtonField ButtonType="Image" ImageUrl="~/Icons/editar.jpg" HeaderText="Editar" CommandName="Editar">
                    <ControlStyle CssClass="btform" />
                </asp:ButtonField>
                <asp:ButtonField ButtonType="Image" ImageUrl="~/Icons/deleta.jpg" HeaderText="Deletar" CommandName="Deletar">
                    <ControlStyle CssClass="btform" />
                </asp:ButtonField>
            </Columns>
        </asp:GridView>

        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </div>
    <!-- INICIO DA MODAL ADD-->
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
                        <div class="col-12">
                            <label>Nome impresso no cartão:</label>
                            <asp:TextBox runat="server" type="number" ID="txtNomeUpdate" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-12 mt-2">
                            <label>CPF:</label>
                            <asp:TextBox runat="server" ID="txtCpfUpdate" CssClass="form-control"></asp:TextBox>
                        </div>


                        <div class="col-12">
                            <label>Numero do Cartão:</label>
                            <asp:TextBox runat="server" ID="txtNumeroADD" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="col-12">
                            <label>Data vencimento:</label>
                            <asp:TextBox runat="server" ID="txtDataADD" type="date" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:TextBox runat="server" ID="txtEnt_id" CssClass="form-control" Style="display: none"></asp:TextBox>

                        <div class="col-12">
                            <label>CVV:</label>
                            <asp:TextBox runat="server" ID="txtCvvADD" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">

                    <asp:Button runat="server" ID="btnAdd" Text="Atualizar" CssClass="btn btn-secondary" OnClick="btnAdd_Click" />
                    <asp:Button runat="server" ID="btnFecharAdd" Text="Fechar" CssClass="btn btn-secondary btn-danger" />
                </div>
            </div>

        </div>
    </div>
    <!-- FIM DA MODAL -->

    <!-- INICIO DA MODAL -->
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
                    <asp:Button runat="server" ID="fecharModal" Text="Fechar" type="button" CssClass="btn btn-secondary" data-dismiss="modal" />
                </div>

            </div>
        </div>
    </div>


    <script type="text/javascript">
        jQuery(function ($) {
            $("#textCPF").mask("999.999.999-99");
        });
    </script>
</asp:Content>

