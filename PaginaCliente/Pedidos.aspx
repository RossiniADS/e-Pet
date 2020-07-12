<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="Pedidos.aspx.cs" Inherits="PaginaCliente_Pedidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--
    <div style="border-radius: 20px;" class="shadow-lg card h-100">
                <img style="border-radius: 20px 20px 0 0" src="http://placehold.it/200x250">
                <div class="card-body">
                    <h4 class="card-title">
                        <a href="PesquisadeProduto.aspx?id=<%#Eval("emp_id")%>&nome=<%#Eval("emp_nome_fantasia")%> ">
                            <%#Eval("emp_nome_fantasia")%>
                        </a>
                    </h4>
                    <h5>Entrega: R$ 10.00</h5>
                    <h5>Distancia: 8,2 km </h5>
                    <h5>Tempo de Entregua: 10 - 20 min</h5>
                    <p class="card-text"></p>
                </div>
                <div class="card-footer">
                    <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                </div>
            </div>-->
    <main class="container">
        <div class="row">
            
            <!-- INICIO REPEATER -->
            <div class="col-12 mt-5 shadow-lg card h-100"  >
                <div class="row">
                    <div class="col-3 mt-3">
                        <img style="border-radius: 20px 20px 20px 20px" src="http://placehold.it/200x200">
                    </div>
                    <div class="col-lg-8 col-sm-12 mt-3  shadow-lg card h-100" style="border: 1px solid"  >
                        <div class="row">

                            <div class="col-lg-6 col-sm-12">
                                <h4>Pet-Shop do Zé</h4>
                                <h4>2x Ração Pedigree</h4>
                            </div>
                            <div class="col-lg-6 col-sm-12">
                                <h4>Taxa Entregua: R$ 3.00</h4>
                                <h4>Valor do Produto: R$ 20.00</h4>
                                <h4>Total: R$ 23.00</h4>
                            </div>

                        </div> 
                    </div>
                    <div class="col-4 mt-3 shadow-lg card h-100 alert-success" style="border: 1px solid black">
                        <h3>Agurdando Confirmação</h3>
                    </div>
                    <div class="col-4 mt-3 shadow-lg card h-100 alert-success" style="border: 1px solid black">

                        <h3 >Enviando Produto</h3>
                    </div>
                    <div class="col-4 mt-3 shadow-lg card h-100 alert-danger" style="border: 1px solid black">
                        <h3  >Produto Entregue</h3>
                    </div>

                </div>
            </div>
            
            <!-- FINAL REPEATER -->
        </div>

    </main>
</asp:Content>

