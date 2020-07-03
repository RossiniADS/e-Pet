<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="MeusDados.aspx.cs" Inherits="PaginaCliente_MeusDadosaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container">

        <div class="mt-5 ml-4">
            <h5>Meus Dados</h5>
        </div>
        <hr />
        <div class="row">
            <div class="col-4 mt-4">
                <asp:FileUpload ID="FileUpload" runat="server" />
            </div>

            <div class="col-8">
                <label>Nome completo *</label>
                <asp:TextBox runat="server" ID="textNome" required="required" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-5">
                <label>E-mail *</label>
                <asp:TextBox runat="server" ID="textEmail" type="email" required="required" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <label>DDD + Celular *</label>
                <asp:TextBox runat="server" ID="textCelular" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
            </div>

            <div class="col-5">
                <label>Sexo *</label>
                <asp:DropDownList runat="server" ID="rblSexo" CssClass="form-control" RepeatDirection="Horizontal">
                    <asp:ListItem Value="M" Selected="True">Masculino</asp:ListItem>
                    <asp:ListItem Value="F">Feminino</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <label>Data de Nascimento *</label>
                <asp:TextBox runat="server" ID="textCalendario" type="Date" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-5">
                <label>Senha *</label>
                <asp:TextBox runat="server" ID="textSenha" CssClass="form-control" type="password"></asp:TextBox>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <label>Confirmar senha *</label>
                <asp:TextBox runat="server" ID="textConfirmar" CssClass="form-control" type="password"></asp:TextBox>
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
            $("#textCelular").mask("(99) 99999-9999");
            $("#textCep").mask("99999-999");
            $("#txtCPF").mask("999.999.999-99");
            $("#textCNPJ").mask("99.999.999/9999-99");
        });
    </script>
</asp:Content>

