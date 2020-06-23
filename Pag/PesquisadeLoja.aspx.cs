using System;
using System.Collections.Generic;
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
    }
}