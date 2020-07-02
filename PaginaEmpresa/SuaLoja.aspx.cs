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
            CarregarDDl();
        }
    }

    private void CarregarDDl()
    {
        DataSet ds = EmpresasDB.SelectAll();
        ddl.DataSource = ds;
        ddl.DataTextField = "emp_nome_fantasia";
        ddl.DataValueField = "emp_id";
        ddl.DataBind();
        ddl.Items.Insert(0, "Selecione um PetShop");
    }

    protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DataSet ds = EmpresasDB.ProdutoImagem(Convert.ToInt32(ddl.SelectedValue));
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