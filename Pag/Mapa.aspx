<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="Mapa.aspx.cs" Inherits="Pag_Mapa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <main class="container">
        <div class="row">

            <div class="col-3"></div>
            <div class="col-6 mt-5 ">
                <h4>Quer saber os lugares perto de você?É só digitar</h4>
                <h4>sua cidade que nós encotramos para você!</h4>
            </div>
            <div class="col-3"></div>
            <div class="col-3"></div>
            <div class="col-6 mt-3">
                <asp:Button ClientIDMode="Static" runat="server" Text="Cidade/CEP" ID="btn" ForeColor="white"
                    BorderColor="orange" BorderWidth="5px" BackColor="orange" CssClass="btn btn-primary btn-block" />
            </div>
             <div class="col-3"></div>
            <div class="col-3"></div>
            <div class="col-6 mt-3 mr-1">
                 <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d14718.320267013223!2d-45.12139255!3d-22.74384465!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1spt-BR!2sbr!4v1594320199430!5m2!1spt-BR!2sbr" width="600" height="450" frameborder="0" style="border:0;" allowfullscreen="" aria-hidden="false" tabindex="0"></iframe>
            </div>
        </div>

    </main>
</asp:Content>

