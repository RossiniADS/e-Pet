<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaEmpresa/EmpresaLogada.master" AutoEventWireup="true" CodeFile="EmpDados.aspx.cs" Inherits="PaginaEmpresa_EmpDados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="mt-4 ml-4">
            <h5>Dados Empresariais</h5>
        </div>
        <hr />

        <div class="row">
            <div class="col-12">
                <label>Razão Social *</label>
                <asp:TextBox runat="server" ID="textSocial" required="required" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-12">
                <label>E-mail *</label>
                <asp:TextBox runat="server" ID="textEmail2" AutoCompleteType="Email" required="required" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-1">
                <label>DDD</label>
                <asp:TextBox runat="server" ID="textDDD" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-4">
                <label>Telefone *</label>
                <asp:TextBox runat="server" ID="textTelefone" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
            </div>
            <div class="col-2"></div>
            <div class="col-1">
            </div>
            <div class="col-4">
            </div>

            <div class="col-5">
                <label>Nome fantasia *</label>
                <asp:TextBox runat="server" ID="textNomeFantasia" required="required" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <label>CNPJ *</label>
                <asp:TextBox runat="server" ID="textCNPJ" required="required" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
            </div>
            <div class="col-5">
                <label>Senha *</label>
                <asp:TextBox runat="server" ID="textSenha2" CssClass="form-control" type="password"></asp:TextBox>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <label>Confirmar senha *</label>
                <asp:TextBox runat="server" ID="textConfirmar2" CssClass="form-control" type="password"></asp:TextBox>
            </div>

            <div class="col-8"></div>
            <div class="col-4 mt-5">
                <asp:Button runat="server" Text="Salvar" ID="btnAtualizar" CssClass="btn btn-block btn-primary"
                    OnClick="btnAtualizar_Click" BorderWidth="5px" ForeColor="Black" BorderColor="orange" BackColor="white"></asp:Button>
            </div>

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
    </div>

    <script type="text/javascript">
        jQuery(function ($) {
            $("#textTelefone").mask("9999-9999");
            $("#textCNPJ").mask("99.999.999/9999-99");
        });
    </script>
</asp:Content>

