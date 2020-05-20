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
                    <asp:TextBox runat="server" ID="textEmail" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-1">
                    <label>DDD</label>
                    <asp:TextBox runat="server" ID="textDDD" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-4">
                    <label>Celular *</label>
                    <asp:TextBox runat="server" ID="textCelular" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>
                <div class="col-1">
                    <label>DDD</label>
                    <asp:TextBox runat="server" ID="textDDDt" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-4">
                    <label>Telefone </label>
                    <asp:TextBox runat="server" ID="textTelefone" CssClass="form-control"></asp:TextBox>
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
                    <asp:TextBox runat="server" ID="textSenha" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>
                <div class="col-5">
                    <label>Confirmar senha *</label>
                    <asp:TextBox runat="server" ID="textConfirmar" required="required" CssClass="form-control"></asp:TextBox>
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
                    <asp:TextBox runat="server" ID="textEmail2" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-1">
                    <label>DDD</label>
                    <asp:TextBox runat="server" ID="textDDD2" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-4">
                    <label>Celular *</label>
                    <asp:TextBox runat="server" ID="textCelular2" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>
                <div class="col-1">
                    <label>DDD</label>
                    <asp:TextBox runat="server" ID="textDDDt2" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-4">
                    <label>Telefone </label>
                    <asp:TextBox runat="server" ID="textTelefone2" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="col-5">
                    <label>Nome da empresa *</label>
                    <asp:TextBox runat="server" ID="textNomeEmpresa" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>
                <div class="col-5">
                    <label>CNPJ *</label>
                    <asp:TextBox runat="server" ID="textCNPJ" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-5">
                    <label>Senha *</label>
                    <asp:TextBox runat="server" ID="textSenha2" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>
                <div class="col-5">
                    <label>Confirmar senha *</label>
                    <asp:TextBox runat="server" ID="textConfirmar2" required="required" CssClass="form-control"></asp:TextBox>
                </div>
            </div>


        </asp:Panel>

        <div class="mt-4 ml-4">
            <h5>Endereço</h5>
        </div>
        <hr />
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4">
                <label>Cep</label>
                <asp:TextBox runat="server" ID="textCep" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-4"></div>
            <div class="col-5">
                <label>Bairro *</label>
                <asp:TextBox runat="server" ID="textBairro" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <label>Rua *</label>
                <asp:TextBox runat="server" ID="textRua" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-5">
                <label>Estado *</label>
                <asp:DropDownList runat="server" ID="rblEstado" CssClass="form-control">
                    <asp:ListItem Value="SP">São Paulo</asp:ListItem>
                    <asp:ListItem Value="RJ">Rio de Janeiro</asp:ListItem>
                    <asp:ListItem Value="MG">Minas Gerais</asp:ListItem>
                    <asp:ListItem Value="ES">Espiro Santo</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <label>Cidade *</label>
                <asp:TextBox runat="server" ID="textCidade" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-8"></div>
            <div class="col-4 mt-5">
                <asp:Button runat="server" Text="Concluir" ID="btnConta" CssClass="btn btn-block btn-primary"
                    OnClick="btnConta_Click" BorderWidth="5px" ForeColor="Black" BorderColor="orange" BackColor="white"></asp:Button>
            </div>
        </div>
    </div>
</asp:Content>

