using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pag_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["cli_cliente"] == null)
        {
            PnlLogin.Visible = true;
            PnlLogado.Visible = false;
        }
        else
        {
            PnlLogin.Visible = false;
            PnlLogado.Visible = true;
            Clientes cli = (Clientes)Session["cli_cliente"];
            ltlNomeUsuario.Text = cli.Cli_nome;
        }
    }
    protected void BtnSair_Click(object sender, EventArgs e)
    {
        Session.Remove("cli_cliente");
        Response.Redirect("../Pag/telaInicial.aspx");
    }
}
