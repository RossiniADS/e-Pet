using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaginaCliente_MeusDadosaspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAtualizar_Click(object sender, EventArgs e)
    {

        Clientes cli = new Clientes();
        cli.Cli_nome = textNome.Text;
        cli.Cli_email = textEmail.Text;
        cli.Cli_senha = ClientesDB.PWD(textSenha.Text);
        cli.Cli_sexo = Convert.ToChar(rblSexo.SelectedValue);
        cli.Cli_data_nascimento = Convert.ToDateTime(textCalendario.Text);
        
        Clientes id = (Clientes)Session["cli_cliente"];
        cli.Cli_id = Convert.ToInt32( id.Cli_id );

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