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
            <div class="col-5">
                <label>Cidade *</label>
                <asp:DropDownList runat="server" ID="rblCidade" CssClass="form-control form-control-chosen-required"></asp:DropDownList>
            </div>

            <div class="col-2"></div>
            <div class="col-5">
                <label>Bairro *</label>
                <asp:TextBox runat="server" ID="textBairro" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-5">
                <label>Logradouro *</label>
                <asp:TextBox runat="server" ID="textRua" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <label>Complemento</label>
                <asp:TextBox runat="server" ID="textComplemento" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-5">
                <label>Numero *</label>
                <asp:TextBox runat="server" ID="textNumero" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <%--                <label>Estado *</label>
                <asp:DropDownList runat="server" ID="rblEstado" CssClass="form-control"></asp:DropDownList>--%>
            </div>


            <div class="col-6"></div>
            <div class="col-4 mt-5">
                <asp:ImageButton ImageUrl="~/Icons/add.png" runat="server" Text="Concluir" ID="btnAdd" CssClass=""
                    OnClick="btnAdd_Click"></asp:ImageButton>
            </div>

            <div class="col-4"></div>
            <div class="col-4 mt-5">
                <asp:Button runat="server" Text="Atualizar" ID="btnAtualizar" CssClass="btn btn-block btn-primary"
                    OnClick="btnAtualizar_Click" BorderWidth="5px" ForeColor="Black" BorderColor="orange" BackColor="white"></asp:Button>
            </div>
        </div>

        <asp:GridView ID="grid" runat="server" CssClass="table table-hover text-center table-striped mt-5"
            OnRowCommand="grid_RowCommand"
            AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="end_id" />
                <asp:BoundField DataField="end_cep" HeaderText="Cep" />
                <asp:BoundField DataField="est_nome" HeaderText="Estado" />
                <asp:BoundField DataField="est_uf" HeaderText="UF" />
                <asp:BoundField DataField="cid_nome" HeaderText="Cidade" />
                <asp:BoundField DataField="bai_nome" HeaderText="Bairro" />
                <asp:BoundField DataField="bai_rua" HeaderText="Logadouro" />
                <asp:BoundField DataField="end_tipo" HeaderText="Complemento" />
                <asp:BoundField DataField="cle_num" HeaderText="Numero" />

                <asp:ButtonField ButtonType="Image" ImageUrl="~/Icons/editar.jpg" HeaderText="Editar" CommandName="Editar">
                    <ControlStyle CssClass="btform" />
                </asp:ButtonField>
                <asp:ButtonField ButtonType="Image" ImageUrl="~/Icons/deleta.jpg" HeaderText="Deletar" CommandName="Deletar">
                    <ControlStyle CssClass="btform" />
                </asp:ButtonField>
            </Columns>
        </asp:GridView>

        <asp:Literal ID="ltl" runat="server"></asp:Literal>

    </div>


    <script type="text/javascript">
        jQuery(function ($) {
            $("#textCelular").mask("(99) 99999-9999");
            $("#textCep").mask("99999-999");
            $("#txtCPF").mask("999.999.999-99");
            $("#textCNPJ").mask("99.999.999/9999-99");
        });
    </script>
    <script>
        $('.form-control-chosen-required').chosen();
    </script>
</asp:Content>

