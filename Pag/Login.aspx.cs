using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Data;
using MySql.Data.MySqlClient.Memcached;

public partial class Pag_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        DataSet dsCliente = ClientesDB.SelectLogin(TextUsuario.Text, ClientesDB.PWD(TextSenha.Text));
        int qtdCli = dsCliente.Tables[0].Rows.Count;

        DataSet dsEmpresa = EmpresasDB.SelectLogin(TextUsuario.Text, EmpresasDB.PWD(TextSenha.Text));
        int qtdEmp = dsEmpresa.Tables[0].Rows.Count;


        if (qtdCli == 1 && qtdEmp == 0)
        {
            Clientes cli = new Clientes();
            cli.Cli_nome = dsCliente.Tables[0].Rows[0]["cli_nome"].ToString();
            cli.Cli_email = dsCliente.Tables[0].Rows[0]["cli_email"].ToString();
            cli.Cli_data_nascimento = Convert.ToDateTime(dsCliente.Tables[0].Rows[0]["cli_data_nascimento"].ToString());

            cli.Cli_id = Convert.ToInt32(dsCliente.Tables[0].Rows[0]["cli_id"]);

            Session["cli_cliente"] = cli;

            Response.Redirect("../PaginaCliente/MeusDados.aspx");
        }
        else if (qtdCli == 0 && qtdEmp == 1)
        {
            Empresas emp = new Empresas();
            emp.Emp_id = Convert.ToInt32(dsEmpresa.Tables[0].Rows[0]["emp_id"]);
            emp.Emp_razao_social = dsEmpresa.Tables[0].Rows[0]["emp_razao_social"].ToString();
            emp.Emp_nome_fantasia = dsEmpresa.Tables[0].Rows[0]["emp_nome_fantasia"].ToString();
            emp.Emp_cnpj = dsEmpresa.Tables[0].Rows[0]["emp_cnpj"].ToString();
            emp.Emp_email = dsEmpresa.Tables[0].Rows[0]["emp_email"].ToString();
            emp.Emp_senha = dsEmpresa.Tables[0].Rows[0]["emp_senha"].ToString();
            emp.Emp_numero_endereco = dsEmpresa.Tables[0].Rows[0]["emp_numero_endereco"].ToString();

            Session["emp_empresa"] = emp;
            Response.Redirect("../PaginaEmpresa/EmpDados.aspx");
        }
        else
        {
            ltl.Text = "<p class='text-success'>Erro no Login</p>";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
        }
    }
}