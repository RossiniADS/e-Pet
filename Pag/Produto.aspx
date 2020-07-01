<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="Produto.aspx.cs" Inherits="Pag_Produto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main>
        <div class="container">
            <div class="row">
                <asp:Repeater runat="server" ID="rpt">
                    <ItemTemplate>
                        <div class="col-3 mt-5">
                            <img src="http://placehold.it/210x250" runat="server" />
                        </div>
                        <div class="col-9 mt-5">
                            <h4 class="font-weight-bolder">Ração Golden Special Sabor Frkango e Carne para Cães Adultos</h4>
                            <div>
                                <h2>
                                    <span>&#9733; &#9733; &#9733; &#9733; &#9734; </span>
                                </h2>
                                <br />
                                <h4 class="font-weight-bolder text-center mt-5">Descricão do produto:</h4>
                            </div>
                        </div>

                        <div class="col-12 mt-5">
                            <h4 class="font-weight-bolder">Caracteristica:</h4>
                            <hr />

                        </div>

                        <div class="col-12 ml-4 mt-5">
                            <h3>Empresa: <small class="ml-5">Lorem Ipsum is simply dummy text of the printing and typesetting</small></h3>
                            <h3>Caracteristica: <small class="ml-5">Lorem Ipsum is simply dummy text of the printing and typesetting</small></h3>
                            <h3>Valor: <small class="ml-5">Lorem Ipsum is simply dummy text of the printing and typesetting</small></h3>
                            <h3>Vencimento: <small class="ml-5">Lorem Ipsum is simply dummy text of the printing and typesetting</small></h3>
                            <h3>Sabor: <small class="ml-5">Lorem Ipsum is simply dummy text of the printing and typesetting</small></h3>
                            <h3>Quantidade: <small class="ml-5">Lorem Ipsum is simply dummy text of the printing and typesetting</small></h3>
                            <h3>Tipo: <small class="ml-5">Lorem Ipsum is simply dummy text of the printing and typesetting</small></h3>
                        </div>
                        <div class="col-10"></div>
                        <div class="col-2 mt-5">
                            <asp:Button ClientIDMode="Static" runat="server" Text="Adicionar ao Carrinho" ID="btn" ForeColor="black"
                                BorderColor="orange" BorderWidth="4px" BackColor="white" CssClass="btn btn-primary shadow" />

                        </div>


                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>
    </main>
</asp:Content>

