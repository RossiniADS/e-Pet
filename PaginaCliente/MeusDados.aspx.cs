using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class PaginaCliente_MeusDadosaspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            carregaDados();
        }
    }

    protected void carregaDados()
    {
        Clientes id = (Clientes)Session["cli_cliente"];

        Clientes cli = new Clientes();

        DataSet ds = ClientesDB.SelectAll(id.Cli_id);
        cli.Cli_id = Convert.ToInt32(ds.Tables[0].Rows[0]["cli_id"]);
        cli.Cli_nome = Convert.ToString(ds.Tables[0].Rows[0]["cli_nome"]);
        cli.Cli_senha = Convert.ToString(ds.Tables[0].Rows[0]["cli_senha"]);
        cli.Cli_email = Convert.ToString(ds.Tables[0].Rows[0]["cli_email"]);
        cli.Cli_celular = Convert.ToString(ds.Tables[0].Rows[0]["cli_celular"]);
        cli.Cli_sexo = Convert.ToChar(ds.Tables[0].Rows[0]["cli_sexo"]);
        cli.Cli_data_nascimento = Convert.ToDateTime(ds.Tables[0].Rows[0]["cli_data_nascimento"]);
        cli.Cli_foto_url = Convert.ToString(ds.Tables[0].Rows[0]["cli_foto_url"]);

        textCalendario.Text = cli.Cli_data_nascimento.ToString("yyyy-MM-dd");
        textCelular.Text = cli.Cli_celular.ToString();
        textEmail.Text = cli.Cli_email.ToString();
        textNome.Text = cli.Cli_nome.ToString();
        rblSexo.SelectedValue = cli.Cli_sexo.ToString();
    }

    protected void btnAtualizar_Click(object sender, EventArgs e)
    {

        Clientes id = (Clientes)Session["cli_cliente"];

        Clientes cli = new Clientes();

        DataSet ds = ClientesDB.SelectAll(id.Cli_id);
        cli.Cli_id = Convert.ToInt32(ds.Tables[0].Rows[0]["cli_id"]);
        cli.Cli_nome = Convert.ToString(ds.Tables[0].Rows[0]["cli_nome"]);
        cli.Cli_senha = Convert.ToString(ds.Tables[0].Rows[0]["cli_senha"]);
        cli.Cli_email = Convert.ToString(ds.Tables[0].Rows[0]["cli_email"]);
        cli.Cli_celular = Convert.ToString(ds.Tables[0].Rows[0]["cli_celular"]);
        cli.Cli_sexo = Convert.ToChar(ds.Tables[0].Rows[0]["cli_sexo"]);
        cli.Cli_data_nascimento = Convert.ToDateTime(ds.Tables[0].Rows[0]["cli_data_nascimento"]);
        cli.Cli_foto_url = Convert.ToString(ds.Tables[0].Rows[0]["cli_foto_url"]);

        cli.Cli_data_nascimento = Convert.ToDateTime(textCalendario.Text);
        cli.Cli_celular = textCelular.Text;
        cli.Cli_email = textEmail.Text;
        cli.Cli_nome = textNome.Text;
        cli.Cli_sexo = Convert.ToChar(rblSexo.SelectedValue);

        switch (ClientesDB.Update(cli))
        {
            case 0:
                ltl.Text = "<p class='text-success'>atualizado com sucesso </p>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);

                break;
            case -2:
                ltl.Text = "<p class='text-success'>Erro no cadastro</p>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                break;
        }
    }

}