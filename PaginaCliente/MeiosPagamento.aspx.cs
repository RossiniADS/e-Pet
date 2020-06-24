using Correios.CorreiosServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaginaCliente_Meios_de_pagamento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Salvar_Click(object sender, EventArgs e)
    {
        Clientes id = (Clientes)Session["cli_cliente"];
        Clientes cli = new Clientes();

        Cartao car = new Cartao();
        car.Car_cpf = textCPF.Text;
        car.Car_nome = textNome.Text;
        car.Car_num = textNumero.Text;
        car.Car_data_vencimento = Convert.ToDateTime(textData.Text);
        car.Car_cod_seguranca = textCVC.Text;
        car.Car_bandeira = "master card";

        //FK
        cli.Cli_id = Convert.ToInt32(id.Cli_id);
        car.Cli_id = cli;

        switch (CartaoDB.Insert(car))
        {
            case -2:
                ltl.Text = "<p class='text-success'>Erro no cadastro</p>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                break;

            default:
                ltl.Text = "<p class='text-success'>Cartão adicionado com sucesso</p>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                break;
        }
    }

}