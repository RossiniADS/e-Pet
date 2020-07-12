<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="Historico.aspx.cs" Inherits="PaginaCliente_Historico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-6 mt-5">
                <div style="border-radius: 20px;" class="shadow-lg card h-100">
                    <img style="border-radius: 20px 20px 0 0" src="http://placehold.it/300x300">
                    <div class="card-body">
                        <h4 class="card-title">
                            <a href="PesquisadeProduto.aspx?id=<%#Eval("emp_id")%>&nome=<%#Eval("emp_nome_fantasia")%> ">
                                <%#Eval("emp_nome_fantasia")%>
                            </a>
                        </h4>
                        <h5>Nome: Pé do Zé</h5>
                        <h5>Quantidade/Nome: 2x Ração Pedigree </h5>
                        <h5>Status: Entregue</h5>
                        <p class="card-text"></p>
                    </div> 
                </div>
            </div>

        </div>

        <!--  
            <div class="col-5 mt-5 borderPedido" style="border: 1px solid">
                <div class="row">
                    <div class="col-4 mt-3">
                        <img style="border-radius: 20px 20px 20px 20px" src="http://placehold.it/150x100">
                    </div>
                    <div class="col-lg-6 col-sm-12 mt-3">
                        <div class="row">

                            <div class="col-lg-12 col-sm-12">
                                <h4>Pet-Shop do Zé</h4>
                                <h4>2x Ração Pedigree</h4>
                            </div>
                        </div>
                    </div>
                    <div class="col-2"></div>
                    <div class="col-8 mt-3">
                        <h4>Status: Entregue</h4>
                    </div>
                    <div class="col-4">
                        <asp:Button ClientIDMode="Static" runat="server" Text="Avaliar" ID="btnSalvar" ForeColor="black"
                            BorderColor="orange" BorderWidth="5px" BackColor="white" CssClass="btn btn-primary btn-block" />
                   
                    </div>
                </div>
            </div>
            <div class="col-2"></div>
 -->

    </div>
    </div>
</asp:Content>

