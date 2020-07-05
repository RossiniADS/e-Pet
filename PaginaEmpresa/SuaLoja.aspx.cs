using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class PaginaEmpresa_SuaLoja : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            carregaGrid();
        }
    }

    protected void carregaGrid()
    {
        try
        {
            Empresas id = (Empresas)Session["emp_empresa"];
            DataSet ds = EmpresasDB.ProdutoImagem(Convert.ToInt32(id.Emp_id));
            rptCard.DataSource = ds;
            rptCard.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void Unnamed_Click(object sender, EventArgs e)
    {
        ltl.Text = "<p class='text-danger'>Deseja excluir esse produto?</p>";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);

    }

    protected void Unnamed_Click1(object sender, EventArgs e)
    {

        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal2').modal('show');</script>", false);

    }
}