using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Correios;


public partial class PaginaEmpresa_EmpEndereco : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregaRBL();
            carregaDados();
        }
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

    protected void carregaDados()
    {
        Empresas emp = (Empresas)Session["emp_nome_fantasia"];

        Empresas emp2 = new Empresas();
        DataSet dsEmp = EmpresasDB.SelectAll(emp.Emp_id);
        emp2.Emp_numero_endereco = Convert.ToString(dsEmp.Tables[0].Rows[0]["emp_numero_endereco"]);

        emp2.End_id = new Enderecos();
        emp2.End_id.End_id = Convert.ToInt32(dsEmp.Tables[0].Rows[0]["end_id"]);

        DataSet ds = EnderecosDB.SelectEndereco(emp.Emp_id);
        emp2.End_id.End_tipo = Convert.ToString(ds.Tables[0].Rows[0]["End_tipo"]);
        emp2.End_id.End_cep = Convert.ToString(ds.Tables[0].Rows[0]["End_cep"]);

        emp2.End_id.Bai_id = new Bairros();
        emp2.End_id.Bai_id.Bai_id = Convert.ToInt32(ds.Tables[0].Rows[0]["Bai_id"]);


        DataSet dsBai = BairrosDB.SelectBairro(emp2.End_id.Bai_id.Bai_id);
        emp2.End_id.Bai_id.Bai_nome = Convert.ToString(dsBai.Tables[0].Rows[0]["bai_nome"]);
        emp2.End_id.Bai_id.Bai_rua = Convert.ToString(dsBai.Tables[0].Rows[0]["bai_rua"]);

        emp2.End_id.Bai_id.Cid_id = new Cidades();
        emp2.End_id.Bai_id.Cid_id.Cid_id = Convert.ToInt32(dsBai.Tables[0].Rows[0]["cid_id"]);

        DataSet dsCid = CidadesDB.SelectCid(emp2.End_id.Bai_id.Cid_id.Cid_id);
        emp2.End_id.Bai_id.Cid_id.Cid_nome = Convert.ToString(dsCid.Tables[0].Rows[0]["cid_nome"]);

        emp2.End_id.Bai_id.Cid_id.Est_id = new Estados();
        emp2.End_id.Bai_id.Cid_id.Est_id.Est_id = Convert.ToInt32(dsCid.Tables[0].Rows[0]["est_id"]);
        emp2.End_id.Bai_id.Cid_id.Est_id.Est_nome = Convert.ToString(dsCid.Tables[0].Rows[0]["est_nome"]);
        emp2.End_id.Bai_id.Cid_id.Est_id.Est_uf = Convert.ToString(dsCid.Tables[0].Rows[0]["est_uf"]);

        emp2.End_id.Bai_id.Cid_id.Cid_nome = Convert.ToString(dsCid.Tables[0].Rows[0]["cid_nome"]);
        emp2.End_id.Bai_id.Cid_id.Est_id = new Estados();
        emp2.End_id.Bai_id.Cid_id.Est_id.Est_id = Convert.ToInt32(dsCid.Tables[0].Rows[0]["est_id"]);
        emp2.End_id.Bai_id.Cid_id.Est_id.Est_nome = Convert.ToString(dsCid.Tables[0].Rows[0]["est_nome"]);
        emp2.End_id.Bai_id.Cid_id.Est_id.Est_uf = Convert.ToString(dsCid.Tables[0].Rows[0]["est_uf"]);

        textBairro.Text = emp2.End_id.Bai_id.Bai_nome;
        textCep.Text = emp2.End_id.End_cep;
        textNumero.Text = emp2.Emp_numero_endereco;
        textRua.Text = emp2.End_id.Bai_id.Bai_rua;
        textComplemento.Text = emp2.End_id.End_tipo;
        rblCidade.SelectedValue = emp2.End_id.Bai_id.Cid_id.Cid_id.ToString();
        rblEstado.SelectedValue = emp2.End_id.Bai_id.Cid_id.Est_id.Est_id.ToString();
    }
    protected void btnAtualizar_Click(object sender, EventArgs e)
    {
        Empresas emp = (Empresas)Session["emp_nome_fantasia"];

        Empresas emp2 = new Empresas();
        DataSet dsEmp = EmpresasDB.SelectAll(emp.Emp_id);
        emp2.Emp_numero_endereco = Convert.ToString(dsEmp.Tables[0].Rows[0]["emp_numero_endereco"]);
        emp2.Emp_id = Convert.ToInt32(dsEmp.Tables[0].Rows[0]["emp_id"]);
        emp2.Emp_nome_fantasia = Convert.ToString(dsEmp.Tables[0].Rows[0]["emp_nome_fantasia"]);
        emp2.Emp_senha = Convert.ToString(dsEmp.Tables[0].Rows[0]["emp_senha"]);
        emp2.Emp_email = Convert.ToString(dsEmp.Tables[0].Rows[0]["emp_email"]);
        emp2.Emp_razao_social = Convert.ToString(dsEmp.Tables[0].Rows[0]["emp_razao_social"]);
        emp2.Emp_cnpj = Convert.ToString(dsEmp.Tables[0].Rows[0]["emp_cnpj"]);
        emp2.Emp_foto_url = Convert.ToString(dsEmp.Tables[0].Rows[0]["emp_foto_url"]);

        emp2.End_id = new Enderecos();
        emp2.End_id.End_id = Convert.ToInt32(dsEmp.Tables[0].Rows[0]["end_id"]);

        DataSet ds = EnderecosDB.SelectEndereco(emp.Emp_id);
        emp2.End_id.End_tipo = Convert.ToString(ds.Tables[0].Rows[0]["End_tipo"]);
        emp2.End_id.End_cep = Convert.ToString(ds.Tables[0].Rows[0]["End_cep"]);

        emp2.End_id.Bai_id = new Bairros();
        emp2.End_id.Bai_id.Bai_id = Convert.ToInt32(ds.Tables[0].Rows[0]["Bai_id"]);


        DataSet dsBai = BairrosDB.SelectBairro(emp2.End_id.Bai_id.Bai_id);
        emp2.End_id.Bai_id.Bai_nome = Convert.ToString(dsBai.Tables[0].Rows[0]["bai_nome"]);
        emp2.End_id.Bai_id.Bai_rua = Convert.ToString(dsBai.Tables[0].Rows[0]["bai_rua"]);

        emp2.End_id.Bai_id.Cid_id = new Cidades();
        emp2.End_id.Bai_id.Cid_id.Cid_id = Convert.ToInt32(dsBai.Tables[0].Rows[0]["cid_id"]);

        DataSet dsCid = CidadesDB.SelectCid(emp2.End_id.Bai_id.Cid_id.Cid_id);
        emp2.End_id.Bai_id.Cid_id.Cid_nome = Convert.ToString(dsCid.Tables[0].Rows[0]["cid_nome"]);

        emp2.End_id.Bai_id.Cid_id.Est_id = new Estados();
        emp2.End_id.Bai_id.Cid_id.Est_id.Est_id = Convert.ToInt32(dsCid.Tables[0].Rows[0]["est_id"]);
        emp2.End_id.Bai_id.Cid_id.Est_id.Est_nome = Convert.ToString(dsCid.Tables[0].Rows[0]["est_nome"]);
        emp2.End_id.Bai_id.Cid_id.Est_id.Est_uf = Convert.ToString(dsCid.Tables[0].Rows[0]["est_uf"]);

        emp2.End_id.Bai_id.Bai_nome = textBairro.Text;
        emp2.End_id.End_cep = textCep.Text;
        emp2.Emp_numero_endereco = textNumero.Text;
        emp2.End_id.Bai_id.Bai_rua = textRua.Text;
        emp2.End_id.End_tipo = textComplemento.Text;
        emp2.End_id.Bai_id.Cid_id.Cid_id = Convert.ToInt32(rblCidade.SelectedValue);
        emp2.End_id.Bai_id.Cid_id.Est_id.Est_id = Convert.ToInt32(rblEstado.SelectedValue);


        switch (EmpresasDB.Update(emp2) & BairrosDB.Update(emp2.End_id.Bai_id) & EnderecosDB.Update(emp2.End_id))
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

    protected void BuscaCep_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(textCep.Text))
        {
            CorreiosApi correiosApi = new CorreiosApi();
            var address = correiosApi.consultaCEP(textCep.Text);

            textRua.Text = address.end;
            textBairro.Text = address.bairro;
            DDLSelecionaItem(rblCidade, address.cidade);
            DDLSelecionaItem(rblEstado, address.uf);
        }
    }

    public static DropDownList DDLSelecionaItem(DropDownList ddl, string valor)
    {
        for (int i = 0; i <= ddl.Items.Count - 1; i++)
        {
            ddl.Items[i].Selected = false;
        }
        for (int i = 0; i <= ddl.Items.Count - 1; i++)
        {
            if (ddl.Items[i].Text == valor)
            {
                ddl.Items[i].Selected = true;
                break;
            }
        }
        return ddl;
    }
}