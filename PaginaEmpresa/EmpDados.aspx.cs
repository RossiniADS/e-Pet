using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class PaginaEmpresa_EmpDados : System.Web.UI.Page
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
        Empresas id = (Empresas)Session["emp_nome_fantasia"];

        Empresas emp = new Empresas();

        DataSet ds = EmpresasDB.SelectAll(id.Emp_id);
        emp.Emp_id = Convert.ToInt32(ds.Tables[0].Rows[0]["emp_id"]);
        emp.Emp_nome_fantasia = Convert.ToString(ds.Tables[0].Rows[0]["emp_nome_fantasia"]);
        emp.Emp_senha = Convert.ToString(ds.Tables[0].Rows[0]["emp_senha"]);
        emp.Emp_email = Convert.ToString(ds.Tables[0].Rows[0]["emp_email"]);
        emp.Emp_razao_social = Convert.ToString(ds.Tables[0].Rows[0]["emp_razao_social"]);
        emp.Emp_cnpj = Convert.ToString(ds.Tables[0].Rows[0]["emp_cnpj"]);
        emp.Emp_foto_url = Convert.ToString(ds.Tables[0].Rows[0]["emp_foto_url"]);
        emp.Emp_numero_endereco = Convert.ToString(ds.Tables[0].Rows[0]["emp_numero_endereco"]);


        textNomeFantasia.Text = emp.Emp_nome_fantasia.ToString();
        textEmail2.Text = emp.Emp_email.ToString();
        textSocial.Text = emp.Emp_razao_social.ToString();
        textCNPJ.Text = emp.Emp_cnpj.ToString();
    }

    protected void btnAtualizar_Click(object sender, EventArgs e)
    {
        Empresas id = (Empresas)Session["emp_nome_fantasia"];

        Empresas emp = new Empresas();

        DataSet ds = EmpresasDB.SelectAll(id.Emp_id);
        emp.Emp_id = Convert.ToInt32(ds.Tables[0].Rows[0]["emp_id"]);
        emp.Emp_nome_fantasia = Convert.ToString(ds.Tables[0].Rows[0]["emp_nome_fantasia"]);
        emp.Emp_senha = Convert.ToString(ds.Tables[0].Rows[0]["emp_senha"]);
        emp.Emp_email = Convert.ToString(ds.Tables[0].Rows[0]["emp_email"]);
        emp.Emp_razao_social = Convert.ToString(ds.Tables[0].Rows[0]["emp_razao_social"]);
        emp.Emp_cnpj = Convert.ToString(ds.Tables[0].Rows[0]["emp_cnpj"]);
        emp.Emp_foto_url = Convert.ToString(ds.Tables[0].Rows[0]["emp_foto_url"]);
        emp.Emp_numero_endereco = Convert.ToString(ds.Tables[0].Rows[0]["emp_numero_endereco"]);


        emp.Emp_nome_fantasia = textNomeFantasia.Text;
        emp.Emp_email = textEmail2.Text;
        emp.Emp_razao_social = textSocial.Text;
        emp.Emp_cnpj = textCNPJ.Text;


        switch (EmpresasDB.Update(emp))
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