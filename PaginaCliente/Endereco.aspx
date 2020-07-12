<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="Endereco.aspx.cs" Inherits="PaginaCliente_Endereco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container">
        <div class="mt-4 ml-4">
            <h5>Endereço</h5>
        </div>
        <hr />
        <div class="row">
            <div class="col-4 ">
                <label>Cep</label>
                <asp:TextBox runat="server" ID="textCep" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
            </div>
            <div class="col-1 mt-2 pl-1">
                <label></label>
                <label></label>
                <asp:Button runat="server" ID="BuscaCep" Text="Buscar" CssClass="btn btn-group-sm" ForeColor="Black"
                    BorderColor="orange" BackColor="white" OnClick="BuscaCep_Click" />
            </div>
            <div class="col-3"></div>
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
                <asp:DropDownList runat="server" ID="rblEstado" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <label>Cidade *</label>
                <asp:DropDownList runat="server" ID="rblCidade" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="col-8"></div>
            <div class="col-4 mt-5">
                <asp:Button runat="server" Text="Concluir" ID="btnAtualizar" CssClass="btn btn-block btn-primary"
                    OnClick="btnAtualizar_Click" BorderWidth="5px" ForeColor="Black" BorderColor="orange" BackColor="white"></asp:Button>
            </div>

        </div><table class="table table-striped mt-5">
            <thead>
                <tr>
                    <th scope="col">CEP</th>
                    <th scope="col">LOGRADOURO</th>
                    <th scope="col">NUMERO</th>
                    <th scope="col">BAIRRO</th>
                    <th scope="col">COMPLEMENTO</th>
                    <th scope="col">ESTADO</th>
                    <th scope="col">CIDADE</th>
                    <th scope="col">Editar</th>
                    <th scope="col">Excluir</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope="row">123123-159</th>
                    <td>SP</td>
                    <td>Lorena</td>
                    <td>Vila Hepacare</td>
                    <td>Perto do Predio</td>

                    <td>São Paulo</td>
                    <td>Lorena</td>
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

    <script type="text/javascript">
        jQuery(function ($) {
            $("#textCelular").mask("(99) 99999-9999");
            $("#textCep").mask("99999-999");
            $("#txtCPF").mask("999.999.999-99");
            $("#textCNPJ").mask("99.999.999/9999-99");
        });
    </script>
</asp:Content>

