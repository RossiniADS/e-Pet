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
            DataSet ds = EmpresasDB.EmpresaUsuarioPerfil(Convert.ToInt32(ddl.SelectedValue));
            rptCard.DataSource = ds;
            rptCard.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }
}