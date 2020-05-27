using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Correios;
using System.Web.UI.WebControls;

public partial class Pag_Cadastro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            pnlFisica.Visible = true;
            pnlJuridica.Visible = false;
        }
    }

    protected void EscolhePessoa_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (EscolhePessoa.SelectedValue)
        {
            case "1":
                pnlFisica.Visible = true;
                pnlJuridica.Visible = false;
                break;
            case "2":
                pnlFisica.Visible = false;
                pnlJuridica.Visible = true;
                break;
        }
    }

    protected void btnConta_Click(object sender, EventArgs e)
    {
        ltl.Text = "<p class='text-success'>Cadastro efetuado com sucesso</p>";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);

    }

    protected void BuscaCep_Click(object sender, EventArgs e)
    {
        CorreiosApi correiosApi = new CorreiosApi();
        var address = correiosApi.consultaCEP(textCep.Text);

        textRua.Text = address.cidade;
        textBairro.Text = address.bairro;
        textCidade.Text = address.cidade;
        rblEstado.SelectedValue = address.uf;
    }
}