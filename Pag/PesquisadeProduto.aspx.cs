using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pag_Loja : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            LogoNome.Text = Convert.ToString(Request.QueryString["nome"]);
            CarregaGrid(id);
            CarregarGridServiço(id);
        }
    }
    protected void CarregaGrid(int id)
    {
        try
        {
            DataSet ds = EmpresasDB.ProdutoImagem(id);
            rptCard.DataSource = ds;
            rptCard.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void CarregarGridServiço(int id)
    {
        try
        {
            DataSet ds = EmpresasDB.ServicoImagem(id);
            rptCardServico.DataSource = ds;
            rptCardServico.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void btnComprar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Carrinho.aspx");

    }
}