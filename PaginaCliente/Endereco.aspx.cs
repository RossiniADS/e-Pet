using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Correios;
using System.Web.UI.WebControls;
using System.ServiceModel.Description;


public partial class PaginaCliente_Endereco : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CarregaRBL();
    }

    void CarregaRBL()
    {
        rblEstado.DataSource = EstadosDB.SelectAll();
        rblEstado.DataTextField = "est_uf";
        rblEstado.DataValueField = "est_id";
        rblEstado.DataBind();
        rblCidade.DataSource = CidadesDB.SelectAll();
        rblCidade.DataTextField = "cid_nome";
        rblCidade.DataValueField = "cid_id";
        rblCidade.DataBind();
    }

    protected void btnAtualizar_Click(object sender, EventArgs e)
    {

    }

    protected void BuscaCep_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(textCep.Text))
        {
            CorreiosApi correiosApi = new CorreiosApi();
            var address = correiosApi.consultaCEP(textCep.Text);

            textRua.Text = address.end;
            textBairro.Text = address.bairro;
            rblCidade.SelectedItem.Text = address.cidade;
            rblEstado.SelectedItem.Text = address.uf;
        }
    }
}