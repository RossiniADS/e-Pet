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
                <asp:Button runat="server" Text="Salvar" ID="Salvar" CssClass="btn btn-block btn-primary"
                    OnClick="Salvar_Click" BorderWidth="5px" ForeColor="Black" BorderColor="orange" BackColor="white"></asp:Button>
            </div>
            <div class="col-2"></div>
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
                        <asp:Button runat="server" ID="fecharModal" Text="Fechar" type="button" CssClass="btn btn-secondary" data-dismiss="modal" />
                    </div>

                </div>
            </div>

        </div>
        <table class="table table-striped mt-5">
            <thead>
                <tr>
                    <th scope="col">NOME</th>
                    <th scope="col">CPF</th>
                    <th scope="col">NUMERO</th>
                    <th scope="col">DATA VENCIMENTO</th>
                    <th scope="col">CVC</th> 
                    <th>Editar</th>
                    <th>Excluir</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td scope="row">Gabriel Oliveira</td>
                    <td>123123-123</td>
                    <td>7777 7777 7777 7777</td>
                    <td>01/21</td>
                    <td>999</td> 
                    <td>
                        <asp:Button runat="server" Text="Editar" ID="Button1" CssClass="btn btn-block btn-primary"
                            BorderWidth="2px" ForeColor="white" BorderColor="green" BackColor="green"></asp:Button>
                    </td>
                    <td>
                        <asp:Button runat="server" Text="Excluir" ID="btnExcluir" CssClass="btn btn-block btn-primary"
                            BorderWidth="2px" ForeColor="white" BorderColor="red" BackColor="red"></asp:Button>

                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    <script type="text/javascript">
        jQuery(function ($) {
            $("#textCelular").mask("(99) 99999-9999");
            $("#textCep").mask("99999-999");
            $("#textCPF").mask("999.999.999-99");
            $("#textCNPJ").mask("99.999.999/9999-99");
        });
    </script>
</asp:Content>

