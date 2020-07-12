<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaEmpresa/EmpresaLogada.master" AutoEventWireup="true" CodeFile="Resumo.aspx.cs" Inherits="PaginaEmpresa_Resumo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <main class="container">
        <div class="row">
            <div class="col-5">
                <table class="table table-striped mt-5">
                    <thead>
                        <tr>
                            <th scope="col">Indice de vendas</th>
                            <th scope="col">diario</th>
                        </tr>

                    </thead>
                    <tbody>
                        <tr>
                            <th scope="row">Hoje</th>
                            <td>0</td>
                        </tr>
                    </tbody>
                    <tbody>
                        <tr>
                            <th scope="row">Ontem</th>
                            <td>0</td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <table class="table table-striped mt-5 text-center">
                    <thead>
                        <tr>
                            <th scope="col">Pedidos para responder</th> 
                        </tr>

                    </thead>
                    <tbody>
                        <tr>
                            <th scope="row">Você não tem pedidos</th> 
                        </tr>
                    </tbody>
                     
                </table>
            </div>

            <div class="col-5">
                <table class="table table-striped mt-5 text-center">
                    <thead>
                        <tr>
                            <th scope="col">Reputação</th>
                        </tr>

                    </thead>

                    <tbody>
                        <tr>
                            <th>&#9733; &#9733; &#9733; &#9733; &#9734; </th> 
                        </tr>
                    </tbody>
                </table>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <table class="table table-striped mt-5">
                    <thead>
                        <tr>
                            <th scope="col" class="text-center"> </th> 
                            <th>Saldo no e-Pe</th>
                            <th> </th>
                        </tr>

                    </thead>
                    <tbody>
                        <tr>
                            <th scope="row">Lucros do mes</th>
                            <td> </td>
                            <td>R$ 0,00</td>
                        </tr>
                    </tbody>
                     
                </table>
            </div>
        </div>
    </main>
</asp:Content>

