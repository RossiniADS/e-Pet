using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Pag_Produto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataSet ds = EmpresasDB.EmpresaUsuarioPerfil(1);
            rpt.DataSource = ds;
            rpt.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }
}