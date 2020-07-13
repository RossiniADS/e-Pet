using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Correios;
using System.Web.UI.WebControls;
using System.ServiceModel.Description;
using System.Data;
public partial class PaginaEmpresa_AddFrete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            CarregaRBL();
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
        rblBairro.DataSource = BairrosDB.SelectAll();
        rblBairro.DataTextField = "bai_nome";
        rblBairro.DataValueField = "bai_id";
        rblBairro.DataBind();
    }

    protected void Salvar_Click(object sender, EventArgs e)
    {
        Entregas ent = new Entregas();
        ent.Ent_frete = Convert.ToInt32(txtFrete.Text);
        //FK  
        Cidades cid = new Cidades();
        cid.Cid_id = Convert.ToInt32(rblCidade.SelectedValue);
        ent.Cid_id = cid;

        //FK
        Estados est = new Estados();
        est.Est_id = Convert.ToInt32(rblEstado.SelectedValue);
        cid.Est_id = est;

        //FK
        Bairros bai = new Bairros();
        bai.Bai_id = Convert.ToInt32(rblBairro.SelectedValue);
        ent.Bai_id = bai;

        Empresas emp = new Empresas();
        Empresas id = (Empresas)Session["emp_empresa"];
        emp.Emp_id = Convert.ToInt32(id.Emp_id);
        ent.Emp_id = emp;

        ent.Ent_id = EntregasDB.Insert(ent);
    }
}

private void CarregarGrid()
{
    DataSet ds = EntregasDB.SelectAll();

    int qtd = ds.Tables[0].Rows.Count;
    if (qtd > 0)
    {
        grid.DataSource = ds.Tables[0].DefaultView;
        grid.DataBind();
        grid.Visible = true;
        ltl.Text = "Foram encontrados " + qtd + "de registros";
    }
    else
    {
        grid.Visible = false;
        ltl.Text = "Foram encontrados " + qtd + "de registros";
    }
}
}