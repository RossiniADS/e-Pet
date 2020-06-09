using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Data;
using MySql.Data.MySqlClient.Memcached;

public partial class Pag_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        DataSet ds = ClientesDB.SelectLogin(txtUsuario.Text, ClientesDB.PWD(txtSenha.Text));
        int qtd = ds.Tables[0].Rows.Count;

        if (qtd == 1)
        {
            Clientes cli = new Clientes();
            cli.Cli_nome = ds.Tables[0].Rows[0]["cli_nome"].ToString();
            cli.Cli_email = ds.Tables[0].Rows[0]["cli_email"].ToString();
            cli.Cli_data_nascimento = Convert.ToDateTime(ds.Tables[0].Rows[0]["cli_data_nascimento"].ToString());

            cli.Cli_id = Convert.ToInt32(ds.Tables[0].Rows[0]["cli_id"]);

            Session["cli_cliente"] = cli;

            Response.Redirect("../PaginaCliente/MeusDados.aspx");
        }
        else
        {
            ltl.Text = "<p class='text-success'>Erro no Login</p>";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);

        }
    }
}