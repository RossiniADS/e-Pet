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
        Empresas id = (Empresas)Session["emp_empresa"];

        Telefones tel = new Telefones();
        DataSet dsTel = TelefonesDB.SelectTel(id.Emp_id);

        tel.Tel_ddd = Convert.ToString(dsTel.Tables[0].Rows[0]["tel_ddd"]);
        tel.Tel_num = Convert.ToString(dsTel.Tables[0].Rows[0]["tel_num"]);

        tel.Emp_id = new Empresas();
        tel.Emp_id.Emp_id = Convert.ToInt32(dsTel.Tables[0].Rows[0]["emp_id"]);


        DataSet ds = EmpresasDB.SelectID(id.Emp_id);
        tel.Emp_id.Emp_nome_fantasia = Convert.ToString(ds.Tables[0].Rows[0]["emp_nome_fantasia"]);
        tel.Emp_id.Emp_senha = Convert.ToString(ds.Tables[0].Rows[0]["emp_senha"]);
        tel.Emp_id.Emp_email = Convert.ToString(ds.Tables[0].Rows[0]["emp_email"]);
        tel.Emp_id.Emp_razao_social = Convert.ToString(ds.Tables[0].Rows[0]["emp_razao_social"]);
        tel.Emp_id.Emp_cnpj = Convert.ToString(ds.Tables[0].Rows[0]["emp_cnpj"]);
        tel.Emp_id.Emp_foto_url = Convert.ToString(ds.Tables[0].Rows[0]["emp_foto_url"]);
        tel.Emp_id.Emp_numero_endereco = Convert.ToString(ds.Tables[0].Rows[0]["emp_numero_endereco"]);


        textDDD.Text = tel.Tel_ddd.ToString();
        textTelefone.Text = tel.Tel_num.ToString();
        textNomeFantasia.Text = tel.Emp_id.Emp_nome_fantasia.ToString();
        textEmail2.Text = tel.Emp_id.Emp_email.ToString();
        textSocial.Text = tel.Emp_id.Emp_razao_social.ToString();
        textCNPJ.Text = tel.Emp_id.Emp_cnpj.ToString();
    }

    protected void btnAtualizar_Click(object sender, EventArgs e)
    {
        Empresas id = (Empresas)Session["emp_empresa"];

        Telefones tel = new Telefones();
        DataSet dsTel = TelefonesDB.SelectTel(id.Emp_id);

        tel.Tel_ddd = Convert.ToString(dsTel.Tables[0].Rows[0]["tel_ddd"]);
        tel.Tel_num = Convert.ToString(dsTel.Tables[0].Rows[0]["tel_num"]);

        tel.Emp_id = new Empresas();
        tel.Emp_id.Emp_id = Convert.ToInt32(dsTel.Tables[0].Rows[0]["emp_id"]);


        DataSet ds = EmpresasDB.SelectID(id.Emp_id);
        tel.Emp_id.Emp_nome_fantasia = Convert.ToString(ds.Tables[0].Rows[0]["emp_nome_fantasia"]);
        tel.Emp_id.Emp_senha = Convert.ToString(ds.Tables[0].Rows[0]["emp_senha"]);
        tel.Emp_id.Emp_email = Convert.ToString(ds.Tables[0].Rows[0]["emp_email"]);
        tel.Emp_id.Emp_razao_social = Convert.ToString(ds.Tables[0].Rows[0]["emp_razao_social"]);
        tel.Emp_id.Emp_cnpj = Convert.ToString(ds.Tables[0].Rows[0]["emp_cnpj"]);
        tel.Emp_id.Emp_foto_url = Convert.ToString(ds.Tables[0].Rows[0]["emp_foto_url"]);
        tel.Emp_id.Emp_numero_endereco = Convert.ToString(ds.Tables[0].Rows[0]["emp_numero_endereco"]);


        tel.Tel_ddd = textDDD.Text;
        tel.Tel_num = textTelefone.Text;
        tel.Emp_id.Emp_nome_fantasia = textNomeFantasia.Text;
        tel.Emp_id.Emp_email = textEmail2.Text;
        tel.Emp_id.Emp_razao_social = textSocial.Text;
        tel.Emp_id.Emp_cnpj = textCNPJ.Text;


        switch (EmpresasDB.Update(tel.Emp_id) & TelefonesDB.Update(tel))
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