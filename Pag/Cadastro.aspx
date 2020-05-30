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
                    <label>Nome fantasia *</label>
                    <asp:TextBox runat="server" ID="textNomeEmpresa" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>
                <div class="col-5">
                    <label>CNPJ *</label>
                    <asp:TextBox runat="server" ID="textCNPJ" required="required" CssClass="form-control"></asp:TextBox>
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
            <div class="col-4"></div>
            <div class="col-3">
                <label>Cep</label>
                <asp:TextBox runat="server" ID="textCep" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-1 mt-2">
                <label></label>
                <asp:Button runat="server" ID="BuscaCep" Text="Buscar" CssClass="btn btn-group-sm" ForeColor="Black" 
                    BorderColor="orange" BackColor="white" OnClick="BuscaCep_Click" />
            </div>
            <div class="col-4"></div>
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
                <asp:DropDownList runat="server" ID="rblEstado" CssClass="form-control">
                    <asp:ListItem Value="AC">Acre</asp:ListItem>
                    <asp:ListItem Value="AL">Alagoas</asp:ListItem>
                    <asp:ListItem Value="AP">Amapá</asp:ListItem>
                    <asp:ListItem Value="AM">Amazonas</asp:ListItem>
                    <asp:ListItem Value="BA">Bahia</asp:ListItem>
                    <asp:ListItem Value="CE">Ceará</asp:ListItem>
                    <asp:ListItem Value="DF">Distrito Federal</asp:ListItem>
                    <asp:ListItem Value="ES">Espírito Santo</asp:ListItem>
                    <asp:ListItem Value="GO">Goiás</asp:ListItem>
                    <asp:ListItem Value="MA">Maranhão</asp:ListItem>
                    <asp:ListItem Value="MT">Mato Grosso</asp:ListItem>
                    <asp:ListItem Value="MS">Mato Grosso do Sul</asp:ListItem>
                    <asp:ListItem Value="MG">Minas Gerais</asp:ListItem>
                    <asp:ListItem Value="PA">Pará</asp:ListItem>
                    <asp:ListItem Value="PB">Paraíba</asp:ListItem>
                    <asp:ListItem Value="PR">Paraná</asp:ListItem>
                    <asp:ListItem Value="PE">Pernambuco</asp:ListItem>
                    <asp:ListItem Value="PI">Piauí</asp:ListItem>
                    <asp:ListItem Value="RJ">Rio de Janeiro</asp:ListItem>
                    <asp:ListItem Value="RN">Rio Grande do Norte</asp:ListItem>
                    <asp:ListItem Value="RS">Rio Grande do Sul</asp:ListItem>
                    <asp:ListItem Value="RO">Rondônia</asp:ListItem>
                    <asp:ListItem Value="RR">Roraima</asp:ListItem>
                    <asp:ListItem Value="SC">Santa Catarina</asp:ListItem>
                    <asp:ListItem Value="SP">São Paulo</asp:ListItem>
                    <asp:ListItem Value="SE">Sergipe</asp:ListItem>
                    <asp:ListItem Value="TO">Tocantins</asp:ListItem>
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
</asp:Content>

