<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="Carrinho.aspx.cs" Inherits="Pag_Carrinho" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="row">
            <h1>Intens</h1>
            <hr />
            <div class="col-2 ">
                <img style="border-radius: 20px 20px 20px 20px" src="http://placehold.it/100x100">
            </div>
            <div class="col-4 mr-5">
                <h5>Nome do Produto X</h5>
                <h5>Descrição do produto</h5>
            </div>
            <div class="col-3">
                <asp:TextBox runat="server" ID="txtQuantidade" Width="90px" min="0" type="number"></asp:TextBox><br />
                <asp:Button runat="server" ID="btnExcluir" Text="Excluir" CssClass="btn btn-danger" />
            </div>
            <div class="col-2">
                <h3>R$50,00</h3>
            </div>
            <h1 class="mt-5">Entrega</h1>
            <hr />
            <div class="col-12">
                <asp:RadioButtonList runat="server" ID="escolhaEndereco" RepeatDirection="Horizontal" AutoPostBack="true" CssClass="rbl"
                    OnSelectedIndexChanged="escolhaEndereco_SelectedIndexChanged">
                    <asp:ListItem Selected="True" Value="1">Encereço Padrão</asp:ListItem>
                    <asp:ListItem Value="2">Cadastrar novo endereço</asp:ListItem>
                </asp:RadioButtonList>

            </div>

            <div class="col-6">
                <label>Numero *</label>
                <asp:TextBox runat="server" ID="textNumero" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-6">
                <label>Bairro *</label>
                <asp:TextBox runat="server" ID="textBairro" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-6">
                <label>Estado *</label>
                <asp:DropDownList runat="server" ID="rblEstado" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="col-6">
                <label>Cidade *</label>
                <asp:DropDownList runat="server" ID="rblCidade" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="col-9"></div>
            <div class="col-3 mt-4">
                <asp:Button ClientIDMode="Static" runat="server" Text="Adicionar Endereço" ID="btnSalvar" ForeColor="black"
                    BorderColor="orange" BorderWidth="5px" BackColor="white" CssClass="btn btn-primary btn-block" />
            </div>
            <div class="col-12 mt-4">
                <asp:RadioButtonList runat="server" ID="escolhaCartao" RepeatDirection="Horizontal" AutoPostBack="true" CssClass="rbl"
                    OnSelectedIndexChanged="escolhaEndereco_SelectedIndexChanged">
                    <asp:ListItem Selected="True" Value="1">Cartão Cadastrado</asp:ListItem>
                    <asp:ListItem Value="2">Novo Cartão</asp:ListItem>
                </asp:RadioButtonList>

            </div>
            <div class="col-6">
                <label>Numero do Cartão</label>
                <asp:TextBox runat="server" ID="txtNumeroCartao" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-6">
                <label>Nome do Cartão</label>
                <asp:TextBox runat="server" ID="TextBox1" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-3">
                <label>Numero do Cartão</label>
                <asp:TextBox runat="server" ID="txtVencimento" type="date" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-3"></div>
            <div class="col-3">
                <label>Cod. de Seguraça</label>
                <asp:TextBox runat="server" ID="TextBox2" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="">
            </div>
            <div class="col-9"></div>
            <div class="col-3 mt-4">
                <asp:Button ClientIDMode="Static" runat="server" Text="Adicionar Cartão" ID="btnCartao" ForeColor="black"
                    BorderColor="orange" BorderWidth="5px" BackColor="white" CssClass="btn btn-primary btn-block" />
            </div>
            <h1 class="mt-5">Total</h1>
            <hr />
            <div class="col-9"></div>
            <div class="col-3 mt-3"> 
                <h5>Total do Produto</h5>
                <asp:TextBox runat="server" ID="txtTotalProduto" ReadOnly="true" CssClass="form-control"></asp:TextBox>

                <h5>Frete</h5>
                <asp:TextBox runat="server" ID="txtFrete" ReadOnly="true" CssClass="form-control"></asp:TextBox>

                <h5>Total</h5>
                <asp:TextBox runat="server" ID="txtTotal" ReadOnly="true" CssClass="form-control"></asp:TextBox>

            </div>
            <div class="col-9"></div>
            <div class="col-3 mt-4">
                <asp:Button ClientIDMode="Static" runat="server" Text="Finalizar Compra" ID="btn" ForeColor="black"
                    BorderColor="orange" BorderWidth="5px" BackColor="white" CssClass="btn btn-primary btn-block" />
            </div>
        </div>
    </div>
</asp:Content>

