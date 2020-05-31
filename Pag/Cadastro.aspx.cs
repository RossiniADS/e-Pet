using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Correios;
using System.Web.UI.WebControls;
using System.ServiceModel.Description;

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
        Clientes cli = new Clientes();
        cli.Cli_nome = textNome.Text;
        cli.Cli_email = textEmail.Text;
        cli.Cli_senha = textSenha.Text;
        cli.Cli_sexo = Convert.ToChar(rblSexo.SelectedValue);
        cli.Cli_nascimento = Convert.ToDateTime(textCalendario.Text);

        switch (ClientesDB.Insert(cli))
        {
            case 0:
                ltl.Text = "<p class='text-success'>Cadastro efetuado com sucesso</p>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                break;
            case -2:
                ltl.Text = "<p class='text-success'>Erro no cadastro</p>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                break;
        }
    }

    protected void BuscaCep_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(textCep.Text))
        {
            CorreiosApi correiosApi = new CorreiosApi();
            var address = correiosApi.consultaCEP(textCep.Text);

            textRua.Text = address.cidade;
            textBairro.Text = address.bairro;
            textCidade.Text = address.cidade;
            rblEstado.SelectedValue = address.uf;
        }
    }
}