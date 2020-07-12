<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaEmpresa/EmpresaLogada.master" AutoEventWireup="true" CodeFile="HistoricoFaturamento.aspx.cs" Inherits="PaginaEmpresa_HistoricoFaturamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid"> 
            <!-- INICIO REPEATER -->
        <table class="table table-striped">
            <thead>
                <tr>
                    <th scope="col">Nº da compra</th>
                    <th scope="col">Produto</th>
                    <th scope="col">Cliente</th>
                    <th scope="col">Data Compra</th>
                    <th scope="col">Valor</th>
                    <th scope="col">Quantidade</th> 
                    <th scope="col">Status</th>
                    <th scope="col">Total</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope="row">1</th>
                    <td>Pedigree</td>
                    <td>Gabriel</td>
                    <td>12/01/2020</td> 
                    <td>R$10,00</td>
                    <td>2</td>
                    <td>Produto Entregue</td>
                    <td>R$20,00</td>
                </tr>  
            </tbody>
        </table>
        
            <!-- FINAL REPEATER -->
    </div>
</asp:Content>

