using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaginaEmpresa_AddProduto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            pnlProduto.Visible = true;
            pnlServico.Visible = false;
        }
    }



    protected void btnSalvar_Click(object sender, EventArgs e)
    {

    }

    protected void EscolheCategoria_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (EscolheCategoria.SelectedValue)
        {
            case "1":
                pnlProduto.Visible = true;
                pnlServico.Visible = false;
                break;
            case "2":
                pnlProduto.Visible = false;
                pnlServico.Visible = true;
                break;
        }
    }
}