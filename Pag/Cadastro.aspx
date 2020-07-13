<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="Pag_Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container mt-5">
        <div class="row text-center">
            <div class="col-2">
                <h4>Cadastro</h4>
            </div>
            <div class="col-1"></div>
            <div class="col-6">
                <asp:RadioButtonList runat="server" ID="EscolhePessoa" RepeatDirection="Horizontal" AutoPostBack="True" CssClass="rbl"
                    OnSelectedIndexChanged="EscolhePessoa_SelectedIndexChanged">
                    <asp:ListItem Selected="True" Value="1">Pessoa Fisica</asp:ListItem>
                    <asp:ListItem Value="2">Pessoa Juridica</asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div class="col-2">
            </div>
            <hr />
        </div>

        <asp:Panel runat="server" ID="pnlFisica">
            <div class="mt-4 ml-4">
                <h5>Dados Pessoais</h5>
            </div>
            <hr />

            <div class="row">
                <div class="col-12">
                    <label>Nome completo *</label>
                    <asp:TextBox runat="server" ID="textNome" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-12">
                    <label>E-mail *</label>
                    <asp:TextBox runat="server" ID="textEmail" type="email" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-5">
                    <label>DDD + Celular *</label>
                    <asp:TextBox runat="server" ID="textCelular" required="required" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                </div>
                <div class="col-2"></div>
                <div class="col-1">
                </div>
                <div class="col-4">
                </div>

                <div class="col-5">
                    <label>Sexo *</label>
                    <asp:DropDownList runat="server" ID="rblSexo" required="required" CssClass="form-control" RepeatDirection="Horizontal">
                        <asp:ListItem Value="M" Selected="True">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-2"></div>
                <div class="col-5">
                    <label>Data de Nascimento *</label>
                    <asp:TextBox runat="server" ID="textCalendario" required="required" type="Date" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-5">
                    <label>Senha *</label>
                    <asp:TextBox runat="server" ID="textSenha" required="required" CssClass="form-control" type="password"></asp:TextBox>
                </div>
                <div class="col-2"></div>
                <div class="col-5">
                    <label>Confirmar senha *</label>
                    <asp:TextBox runat="server" ID="textConfirmar" required="required" CssClass="form-control" type="password"></asp:TextBox>
                </div>
            </div>
        </asp:Panel>

        <asp:Panel runat="server" ID="pnlJuridica">
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
                    <asp:TextBox runat="server" ID="textDDD" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-4">
                    <label>telefone *</label>
                    <asp:TextBox runat="server" ID="textTelefone" required="required" CssClass="form-control"></asp:TextBox>
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
                    <asp:TextBox runat="server" ID="textSenha2" required="required" CssClass="form-control" type="password"></asp:TextBox>
                </div>
                <div class="col-2"></div>
                <div class="col-5">
                    <label>Confirmar senha *</label>
                    <asp:TextBox runat="server" ID="textConfirmar2" required="required" CssClass="form-control" type="password"></asp:TextBox>
                </div>
            </div>
        </asp:Panel>


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
            <div class="col-3"></div>
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
                <label>Bairro *</label>
                <asp:TextBox runat="server" ID="textBairro" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-5">
                <label>Estado *</label>
                <asp:DropDownList runat="server" ID="rblEstado" CssClass="form-control form-control-chosen-required"></asp:DropDownList>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <label>Cidade *</label>
                <asp:DropDownList runat="server" ID="rblCidade" CssClass="form-control form-control-chosen-required"></asp:DropDownList>
            </div>
            <div class="col-8"></div>
            <div class="col-4 mt-5">
                <asp:Button runat="server" Text="Concluir" ID="btnConta" CssClass="btn btn-block btn-primary"
                    OnClick="btnConta_Click" BorderWidth="5px" ForeColor="Black" BorderColor="orange" BackColor="white" />
            </div>
        </div>

        <!-- INICIO DA MODAL -->
        <div class="modal fade" id="modalUpdate" data-backdrop="static" tabindex="-1" role="dialog" aria-labelledby="staticBackdropLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="staticBackdropLabel">Update</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <asp:Literal runat="server" ID="ltl"></asp:Literal>
                    </div>
                    <div class="modal-footer">
                        <asp:Button runat="server" ID="fechar" Text="Fechar" type="button" class="btn btn-secondary" data-dismiss="modal" />
                        <%--<button type="button" class="btn btn-primary">Understood</button>--%>
                    </div>
                </div>
            </div>
        </div>
        <!-- FIM DA MODAL -->
    </div>

    <script type="text/javascript">
        jQuery(function ($) {
            $("#textCelular").mask("(99) 99999-9999");
            $("#textCep").mask("99999-999");
            $("#textCNPJ").mask("99.999.999/9999-99");
        });
    </script>

    <script>
        $('.form-control-chosen-required').chosen();
    </script>

</asp:Content>

