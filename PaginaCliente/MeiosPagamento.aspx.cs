using Correios.CorreiosServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class PaginaCliente_Meios_de_pagamento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregarGrid();
        }
    }
    private void CarregarGrid()
    {

        Clientes id = (Clientes)Session["cli_cliente"];

        DataSet ds = CartaoDB.SelectPorCliente(id.Cli_id);

        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            grid.DataSource = ds.Tables[0].DefaultView;
            grid.DataBind();
            grid.Visible = true;
        }
        else
        {
            grid.Visible = false;
        }
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
                Response.Redirect("MeiosPagamento.aspx");
                break;
        }
    }


    protected void grid_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Editar")
        {

            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = grid.Rows[index];
            int id = Convert.ToInt32(row.Cells[0].Text);

            Cartao car = new Cartao();
            DataSet ds = CartaoDB.SelectCartao(id); 
             

            txtEnt_id.Text = id.ToString();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModalUpdate').modal('show');</script>", false);



        }

        if (e.CommandName == "Deletar")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = grid.Rows[index];
            int id = Convert.ToInt32(row.Cells[0].Text);

            int retorno;
            retorno = CartaoDB.Delete(id);
            if (retorno == 0)
            {
                CarregarGrid();
            }

        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

    }
}