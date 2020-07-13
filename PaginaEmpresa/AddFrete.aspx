<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaEmpresa/EmpresaLogada.master" AutoEventWireup="true" CodeFile="AddFrete.aspx.cs" Inherits="PaginaEmpresa_AddFrete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="row mt-5">
            <div class="col-6">
                <label>Cidade *</label>
                <asp:DropDownList runat="server" ID="rblCidade" CssClass="form-control"></asp:DropDownList>
            </div>

            <div class="col-6">
                <label>Bairro *</label>
                <asp:DropDownList runat="server" ID="rblBairro" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="col-6">
                <label>Estado *</label>
                <asp:DropDownList runat="server" ID="rblEstado" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="col-6">
                <label>Frete *</label>
                <asp:TextBox runat="server" ID="txtFrete" type="number" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-10"></div>
            <div class="col-2 mt-5">
                <asp:Button runat="server" Text="Salvar" ID="Salvar" CssClass="btn btn-block btn-primary"
                    OnClick="Salvar_Click" BorderWidth="5px" ForeColor="Black" BorderColor="orange" BackColor="white"></asp:Button>
            </div>
            <div class="col-2"></div>
        </div>
        <table class="table table-striped mt-5">
            <thead>
                <tr>
                    <th scope="col">Cidade</th>
                    <th scope="col">Bairro</th>
                    <th scope="col">Estado</th>
                    <th scope="col">Frete</th>
                    <th scope="col">EDITAR</th>
                    <th scope="col">EXCLUIR</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope="row">Lorena</th>
                    <td>Vila Hepacare</td>
                    <td>São Paulo</td>
                    <td>10,00</td>
                    <td>
                        <asp:Button runat="server" Text="Editar" ID="Button1" CssClass="btn btn-block btn-primary"
                            BorderWidth="2px" ForeColor="white" BorderColor="green" BackColor="green"></asp:Button>
                    </td>
                    <td>
                        <asp:Button runat="server" Text="Excluir" ID="btnExcluir" CssClass="btn btn-block btn-primary"
                            BorderWidth="2px" ForeColor="white" BorderColor="red" BackColor="red"></asp:Button>

                    </td>
                </tr>
            </tbody>

        </table>
    </div>
</asp:Content>
