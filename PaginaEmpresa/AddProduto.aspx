<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaEmpresa/EmpresaLogada.master" AutoEventWireup="true" CodeFile="AddProduto.aspx.cs" Inherits="PaginaEmpresa_AddProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container mt-5">
        <div class="row text-center">
            <div class="col-2"></div>
            <div class="col-2 ">
                <h4>Categoria: </h4>
            </div>
            <div class="col-6">
                <asp:RadioButtonList runat="server" ID="EscolheCategoria" RepeatDirection="Horizontal" AutoPostBack="True" CssClass="rbl"
                    OnSelectedIndexChanged="EscolheCategoria_SelectedIndexChanged">
                    <asp:ListItem Selected="True" Value="1">Produto</asp:ListItem>
                    <asp:ListItem Value="2">Serviço</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div class="col-2"></div>

            <div class="col-2"></div>
            <div class="col-2 mt-5">
                <h4>Fotos: </h4>
            </div>
            <div class="col-8"></div>
            <div class="col-12 mt-2">
                <label>Selecione uma foto que será vinculada ao evento (.png, .jpeg,.jpg):</label>
                <asp:FileUpload ID="FileUploadControl" runat="server" class="multi" AllowMultiple="True" />
<%--                <asp:Label runat="server" ID="StatusLabel"></asp:Label>--%>
                <%--<asp:Literal runat="server" ID="ltlUrl"></asp:Literal>--%>
            </div>

        </div>

        <asp:Panel runat="server" ID="pnlProduto">
            <div class="row">
                <div class="col-2"></div>
                <div class="col-8 mt-3">
                    <label>Nome: </label>
                    <asp:TextBox ID="ProNome" runat="server" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>

                <div class="col-2"></div>
                <div class="col-8">
                    <label>Descreva Seu Produto: </label>
                    <asp:TextBox runat="server" ID="ProDesc" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>

                <div class="col-2"></div>
                <div class="col-8">
                    <label>Caracteriscas: </label>
                    <asp:TextBox runat="server" ID="ProCarac" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>

                <div class="col-2"></div>
                <div class="col-6">
                    <label>Categoria: </label>
                    <asp:TextBox runat="server" ID="ProTipo" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2">
                    <label>Vencimento: </label>
                    <asp:TextBox runat="server" ID="ProVenc" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>

                <div class="col-2"></div>
                <div class="col-2">
                    <label>Quantidade: </label>
                    <asp:TextBox runat="server" ID="ProQtd" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-6">
                    <label>Valor: </label>
                    <asp:TextBox runat="server" ID="ProValor" required="required" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>
            </div>
        </asp:Panel>

        <asp:Panel runat="server" ID="pnlServico">
            <div class="row">
                <div class="col-2"></div>
                <div class="col-8 mt-3">
                    <label>Nome: </label>
                    <asp:TextBox runat="server" ID="ServNome" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>

                <div class="col-2"></div>
                <div class="col-8">
                    <label>Descreva Seu serviço: </label>
                    <asp:TextBox runat="server" ID="ServDesc" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>

                <div class="col-2"></div>
                <div class="col-8">
                    <label>Caracteriscas: </label>
                    <asp:TextBox runat="server" ID="ServCarac" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>

                <div class="col-2"></div>
                <div class="col-8">
                    <label>Valor: </label>
                    <asp:TextBox runat="server" ID="ServValor" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-2"></div>
            </div>
        </asp:Panel>

        <div class="row">
            <div class="col-8"></div>
            <div class="col-2 mt-5">
                <asp:Button runat="server" Text="Salvar" ID="Button1" CssClass="btn btn-block btn-primary"
                    OnClick="btnSalvar_Click" BorderWidth="5px" ForeColor="Black" BorderColor="orange" BackColor="white"></asp:Button>
            </div>
            <div class="col-2"></div>
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
                        <asp:Button runat="server" ID="fecharModal" Text="Fechar" type="button" CssClass="btn btn-secondary" data-dismiss="modal" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

