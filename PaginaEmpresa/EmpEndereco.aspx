﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaEmpresa/EmpresaLogada.master" AutoEventWireup="true" CodeFile="EmpEndereco.aspx.cs" Inherits="PaginaEmpresa_EmpEndereco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container">
        <div class="mt-4 ml-4">
            <h5>Endereço</h5>
        </div>
        <hr />
        <div class="row">
            <div class="col-4 ">
                <label>Cep</label>
                <asp:TextBox runat="server" ID="textCep" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
            </div>
            <div class="col-1 mt-2 pl-1">
                <label></label>
                <label></label>
                <asp:Button runat="server" ID="BuscaCep" Text="Buscar" CssClass="btn btn-group-sm" ForeColor="Black"
                    BorderColor="orange" BackColor="white" OnClick="BuscaCep_Click" />
            </div>
            <div class="col-5">
                <label>Cidade *</label>
                <asp:DropDownList runat="server" ID="rblCidade" CssClass="form-control form-control-chosen-required"></asp:DropDownList>
            </div>

            <div class="col-2"></div>
            <div class="col-5">
                <label>Bairro *</label>
                <asp:TextBox runat="server" ID="textBairro" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-5">
                <label>Logradouro *</label>
                <asp:TextBox runat="server" ID="textRua" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <label>Numero *</label>
                <asp:TextBox runat="server" ID="textNumero" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-5">
                <label>Complemento</label>
                <asp:TextBox runat="server" ID="textComplemento" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <%--                <label>Estado *</label>
                <asp:DropDownList runat="server" ID="rblEstado" CssClass="form-control"></asp:DropDownList>--%>
            </div>
            <div class="col-8"></div>
            <div class="col-4 mt-5">
                <asp:Button runat="server" Text="Concluir" ID="btnAtualizar" CssClass="btn btn-block btn-primary"
                    OnClick="btnAtualizar_Click" BorderWidth="5px" ForeColor="Black" BorderColor="orange" BackColor="white"></asp:Button>
            </div>
        </div>


        <asp:GridView ID="grid" runat="server" CssClass="table table-hover text-center table-striped mt-5"
            OnRowCommand="grid_RowCommand"
            AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="end_id" />
                <asp:BoundField DataField="end_cep" HeaderText="Cep" />
                <asp:BoundField DataField="est_nome" HeaderText="Estado" />
                <asp:BoundField DataField="est_uf" HeaderText="UF" />
                <asp:BoundField DataField="cid_nome" HeaderText="Cidade" />
                <asp:BoundField DataField="bai_nome" HeaderText="Bairro" />
                <asp:BoundField DataField="bai_rua" HeaderText="Logadouro" />
                <asp:BoundField DataField="end_tipo" HeaderText="Complemento" />
                <asp:BoundField DataField="cle_num" HeaderText="Numero" />

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
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Fechar</button>
                </div>
            </div>

        </div>
    </div>
    <!-- FIM DA MODAL -->

    <script type="text/javascript">
        jQuery(function ($) {
            $("#textCep").mask("99999-999");
        });
    </script>

    <script>
        $('.form-control-chosen-required').chosen();
    </script>
</asp:Content>

