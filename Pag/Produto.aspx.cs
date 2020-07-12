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
        int id = Convert.ToInt32(Request.QueryString["id"]);
        string nome = Convert.ToString(Request.QueryString["nome"]);
        if (nome == "ser")
        {
            carregaGridServico(id);
        }
        else
        {
            carregaGrid(id);
        }
    }
    protected void carregaGrid(int id)
    {
        try
        {

            DataSet ds = EmpresasDB.ProdutoID(id);
            rpt.DataSource = ds;
            rpt.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }
    protected void carregaGridServico(int id)
    {
        try
        {

            DataSet ds = EmpresasDB.ServicoID(id);
            rptServico.DataSource = ds;
            rptServico.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

}