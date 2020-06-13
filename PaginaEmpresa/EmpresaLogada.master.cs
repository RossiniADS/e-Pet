using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaginaEmpresa_EmpresaLogada : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Empresas emp = (Empresas)Session["emp_nome_fantasia"];
        ltlNomeUsuario.Text = emp.Emp_nome_fantasia;
        if (Session["emp_nome_fantasia"] == null)
        {
            Response.Redirect("../Pag/Login.aspx");
        }

    }
    protected void btnSair_Click(object sender, EventArgs e)
    {
        Session.Remove("emp_nome");
        Response.Redirect("../Pag/telaInicial.aspx");
    }
}
