using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pag_PesquisadeLoja : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (PreviousPage != null)
        {
            ContentPlaceHolder cp = PreviousPage.Master.FindControl("ContentPlaceHolder1") as ContentPlaceHolder;
            if (cp != null)
            {
                TextBox tb = cp.FindControl("textBuscaInicial") as TextBox;
                if (tb != null)
                    textBusca.Text = tb.Text;
            }
        }

        DataSet ds = EmpresasDB.SelectPorCidade(textBusca.Text);
        int qtd = ds.Tables[0].Rows.Count;
        
        if (qtd > 0)
        {
            rptCard.DataSource = ds;
            rptCard.DataBind();
        }
        else
        {
            Response.Redirect("telaInicial.aspx");
            //ltl.Text = "<p class='text-info'>Não encontramos registros referente ao perfil selecionado !</p>";
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
        }
    }
}