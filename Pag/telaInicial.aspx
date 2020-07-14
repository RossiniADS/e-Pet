<%@ Page Title="" Language="C#" MasterPageFile="~/Pag/MasterPage.master" AutoEventWireup="true" CodeFile="telaInicial.aspx.cs" Inherits="telaInicial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container-fluid">
        <div id="CarouselExampleControls" class="carousel slide" data-ride="carousel">
            <ol class="carousel-indicators">
                <li data-target="#CarouselExampleControls" data-slide-to="0" class="active"></li>
                <li data-target="#CarouselExampleControls" data-slide-to="1"></li>
                <li data-target="#CarouselExampleControls" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img class="first-slide w-100" src="../Imagem/inicial1.jpg" alt="First slide">
                    <div class="container">
                        <div class="carousel-caption text-left">
                            <h1>e-Pet</h1>
                            <p>Bem vindo ao e-Pet. Aqui você encontrará os mais variados acessórios e alimentos para seu pet</p>
                            <p><a class="btn btn-lg btn-primary" href="Cadastro.aspx" role="button">Cadastre-se agora</a></p>
                        </div>
                    </div>
                </div>
                <div class="carousel-item">
                    <img class="second-slide w-100" src="../Imagem/inicial2.jpg" alt="Second slide">
                    <div class="container">
                        <div class="carousel-caption">
                            <h1>Pet Shop Mania Animal</h1>
                            <p>Venha conhecer uma grande parceira nossa, tudo que seu pet precisar você encontra aqui na Mania Animal!</p>
                            <p><a class="btn btn-lg btn-primary" href="#" role="button">Saiba mais</a></p>
                        </div>
                    </div>
                </div>
                <div class="carousel-item">
                    <img class="third-slide w-100" src="../Imagem/inicial3.jpg" alt="Third slide">
                    <div class="container">
                        <div class="carousel-caption text-right">
                            <h1>Pet Shop Marcio</h1>
                            <p>Seu pet precisa de um acessório novo? vem conferir no pet shop do marcio.</p>
                            <p><a class="btn btn-lg btn-primary" href="#" role="button">Saiba mais</a></p>
                        </div>
                    </div>
                </div>
            </div>
            <a class="carousel-control-prev" href="#CarouselExampleControls" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Voltar</span>
            </a>
            <a class="carousel-control-next" href="#CarouselExampleControls" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Avançar</span>
            </a>
        </div>
        <div class="row mt-5">
            <div class="col-4"></div>
            <div class="col-4 text-center">
                <h4>Quer saber as lojas perto de você? Digite sua cidade!</h4>
                <asp:TextBox runat="server" ID="textBuscaInicial" placeholder="Cep/Cidade" CssClass="form-control-md" Style="border-radius: 15px;" BorderWidth="5px" BorderColor="Orange"></asp:TextBox>
                <asp:Button runat="server" ID="Buscar" Style="display: none;" PostBackUrl="~/Pag/PesquisadeLoja.aspx" />
            </div>
            <div class="col-4"></div>

            <div class="col-2"></div>
            <div class="col-8 text-center mt-5">
                <h4>Como faço para pedir um acessório ou ração?</h4>
                <img class="img-responsive" src="../Icons/pc.png" />
            </div>
            <div class="col-2"></div>
        </div>
        <div class="row mt-5">
            <div class="col-2"></div>
            <div class="col-8 text-center">
                <h4>Pesquise pelo produto ou loja. Assim que achar o que deseja é só adicionar ao carrinho!</h4>
                <img class="img-responsive" src="../Icons/Caminhão.png" />
            </div>
            <div class="col-2"></div>
            <div class="col-12 text-center mt-3">
                <h4>As entregas serão feitas assim que a compra for finalizada!</h4>
            </div>
        </div>
    </div>
</asp:Content>
