<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="Produto.aspx.cs" Inherits="Pag_Produto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main>
        <div class="container">
            <div class="row">
                <asp:Repeater runat="server" ID="rpt">
                    <ItemTemplate>
                        <div class="row col-4 mt-5 mr-2">
                            <image src="<%#Eval("img_url") %>" class="img-responsive img-thumbnail"></image>
                        </div>
                        <div class="col-7 mt-5">
                            <h4 class="font-weight-bolder"><%#Eval("pro_nome") %><br />
                            </h4>
                            <div>
                                <h5>
                                    <span>&#9733; &#9733; &#9733; &#9733; &#9734; </span>
                                </h5>
                                <br />
                                <h4 class="font-weight-bolder">Descrição:</h4>
                                <%#Eval("pro_descricao") %>
                            </div>
                        </div>

                        <div class="col-12 mt-5">
                            <h4 class="font-weight-bolder">Caracteristicas:</h4>
                            <hr />

                        </div>
                        <div class="col-12 ml-4 mt-5">

                            <%#Eval("pro_caracteristica") %>
                        </div>
                        <div class="col-10"></div>
                        <div class="col-2 mt-5">
                            <asp:Button ClientIDMode="Static" runat="server" Text="Adicionar ao Carrinho" ID="btn" ForeColor="black"
                                BorderColor="orange" BorderWidth="4px" BackColor="white" CssClass="btn btn-primary shadow" />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>


            <div class="row">
                <asp:Repeater runat="server" ID="rptServico">
                    <ItemTemplate>
                        <div class="row col-4 mt-5 mr-2">
                            <image src="<%#Eval("img_url") %>" class="img-responsive img-thumbnail"></image>
                        </div>
                        <div class="col-7 mt-5">
                            <h4 class="font-weight-bolder"><%#Eval("ser_nome") %>
                            </h4>
                            <div>
                                <h5>
                                    <span>&#9733; &#9733; &#9733; &#9733; &#9734; </span>
                                </h5>
                                <br />
                                <h4 class="font-weight-bolder">Descrição:</h4>
                                <%#Eval("ser_descricao") %>
                            </div>
                        </div>

                        <div class="col-12 mt-5">
                            <h4 class="font-weight-bolder">Caracteristicas:</h4>
                            <hr />

                        </div>
                        <div class="col-12 ml-4 mt-5">
                            <%#Eval("ser_caracteristica") %>
                        </div>
                        <div class="col-10"></div>
                        <div class="col-2 mt-5">
                            <asp:Button runat="server" Text="Adicionar ao Carrinho" ID="btn" ForeColor="black"
                                BorderColor="orange" BorderWidth="4px" BackColor="white" CssClass="btn btn-primary shadow" OnClick="btn_Click" />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>

        </div>
    </main>
</asp:Content>