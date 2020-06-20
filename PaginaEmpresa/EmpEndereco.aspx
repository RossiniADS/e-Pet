<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaEmpresa/EmpresaLogada.master" AutoEventWireup="true" CodeFile="EmpEndereco.aspx.cs" Inherits="PaginaEmpresa_EmpEndereco" %>

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
                <asp:TextBox runat="server" ID="textCep" CssClass="form-control"></asp:TextBox>
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

