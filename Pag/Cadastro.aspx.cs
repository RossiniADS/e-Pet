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
            CarregaRBL();
        }
    }

    void CarregaRBL()
    {
        rblEstado.DataSource = EstadosDB.SelectAll();
        rblEstado.DataTextField = "est_uf";
        rblEstado.DataValueField = "est_id";
        rblEstado.DataBind();
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
        cli.Cli_data_nascimento = Convert.ToDateTime(textCalendario.Text);
        cli.Cli_id = ClientesDB.Insert(cli);

        Estados est = new Estados();

        Cidades cid = new Cidades();
        cid.Cid_nome = textCidade.Text;
        //FK
        est.Est_id = Convert.ToInt32(rblEstado.SelectedValue);
        cid.Est_id = est;
        cid.Cid_id = CidadesDB.Insert(cid);

        Bairros bai = new Bairros();
        bai.Bai_nome = textBairro.Text;
        //FK
        bai.Cid_id = cid;
        bai.Bai_id = BairrosDB.Insert(bai);

        Enderecos end = new Enderecos();
        end.End_cep = textCep.Text;
        end.End_tipo = textComplemento.Text;
        //FK
        end.Bai_id = bai;
        end.End_id = EnderecosDB.Insert(end);

        ClienteEndereco cle = new ClienteEndereco();
        cle.Cle_num = textNumero.Text;
        cle.Cle_principal = true;
        //FK
        cle.Cli_id = cli;
        cle.End_id = end;


        switch (ClienteEnderecoDB.Insert(cle))
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
            rblEstado.SelectedItem.Text = address.uf;
        }
    }
}