<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaEmpresa/EmpresaLogada.master" AutoEventWireup="true" CodeFile="AddFrete.aspx.cs" Inherits="PaginaEmpresa_AddFrete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="row mt-5">
            <div class="col-4">
                <label>Cidade *</label>
                <asp:DropDownList runat="server" ID="rblCidade" CssClass="form-control form-control-chosen-required"></asp:DropDownList>
            </div>

            <div class="col-4">
                <label>Bairro *</label>
                <asp:DropDownList runat="server" ID="rblBairro" CssClass="form-control form-control-chosen-required"></asp:DropDownList>
            </div>
            <div class="col-4">
                <label>Frete *</label>
                <asp:TextBox runat="server" ID="txtFrete" type="number" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-6">
                <%--                <label>Estado *</label>
                <asp:DropDownList runat="server" ID="rblEstado" CssClass="form-control form-control-chosen-required"></asp:DropDownList>--%>
            </div>
            <div class="col-10"></div>
            <div class="col-2 mt-5">
                <asp:Button runat="server" Text="Salvar" ID="Salvar" CssClass="btn btn-block btn-primary"
                    OnClick="Salvar_Click" BorderWidth="5px" ForeColor="Black" BorderColor="orange" BackColor="white"></asp:Button>
            </div>
            <div class="col-2"></div>
        </div>

        <asp:GridView ID="grid" runat="server" CssClass="table table-hover text-center table-striped mt-5"
            OnRowCommand="grid_RowCommand"
            AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ent_id" />
                <asp:BoundField DataField="est_nome" HeaderText="Estado" />
                <asp:BoundField DataField="est_uf" HeaderText="UF" />
                <asp:BoundField DataField="cid_nome" HeaderText="Cidade" />
                <asp:BoundField DataField="bai_nome" HeaderText="Bairro" />
                <asp:BoundField DataField="ent_frete" HeaderText="Valor do frete" />

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


    <!-- INICIO DA MODAL EDITAR produto-->
    <div class="modal" tabindex="-1" role="dialog" id="myModalUpdate">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">Cadastro</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>

                <div class="modal-body">

                    <div class="row">
                        <asp:Literal ID="ltlUpdate" runat="server"></asp:Literal>

                        <asp:HiddenField runat="server" ID="hdUpdate" />

                        <div class="col-12">
                            <label>Estado:</label>
                            <asp:DropDownList runat="server" ID="DDLEstado" CssClass="form-control form-control-chosen-required"></asp:DropDownList>
                        </div>

                        <div class="col-12">
                            <label>Cidade:</label>
                            <asp:DropDownList runat="server" ID="DDLCidade" CssClass="form-control form-control-chosen-required"></asp:DropDownList>
                        </div>

                        <div class="col-12">
                            <label>Bairro:</label>
                            <asp:DropDownList runat="server" ID="DDLBairro" CssClass="form-control form-control-chosen-required"></asp:DropDownList>
                        </div>

                        <div class="col-12">
                            <label>Valor do Frete:</label>
                            <asp:TextBox runat="server" ID="textFrete" CssClass="form-control"></asp:TextBox>
                        </div>

                        <asp:TextBox runat="server" ID="txtEnt_id" CssClass="form-control" Style="display: none"></asp:TextBox>

                    </div>

                    <div class="modal-footer">
                        <asp:Button runat="server" Text="Salvar" CssClass="btn btn-info" ID="btn_Atualizar" OnClick="btn_Atualizar_Click" />
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- FIM DA MODAL -->

    <script>
        $('.form-control-chosen-required').chosen();
    </script>
</asp:Content>
