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
            if (Session["emp_empresa"] == null)
            {
                Response.Redirect("../Pag/Login.aspx");
            }
            CarregaRBL();
            CarregarGrid();
            CarregaDLLUpdate();

             
        }
    }

    void CarregaRBL()
    {

        //rblEstado.DataSource = EstadosDB.SelectAll();
        //rblEstado.DataTextField = "est_uf";
        //rblEstado.DataValueField = "est_id";
        //rblEstado.DataBind();
        rblCidade.DataSource = CidadesDB.SelectAll();
        rblCidade.DataTextField = "cid_nome";
        rblCidade.DataValueField = "cid_id";
        rblCidade.DataBind();
        rblBairro.DataSource = BairrosDB.SelectAll();
        rblBairro.DataTextField = "bai_nome";
        rblBairro.DataValueField = "bai_id";
        rblBairro.DataBind();
    }

    void CarregaDLLUpdate()
    {

        DDLEstado.DataSource = EstadosDB.SelectAll();
        DDLEstado.DataTextField = "est_uf";
        DDLEstado.DataValueField = "est_id";
        DDLEstado.DataBind();
        DDLCidade.DataSource = CidadesDB.SelectAll();
        DDLCidade.DataTextField = "cid_nome";
        DDLCidade.DataValueField = "cid_id";
        DDLCidade.DataBind();
        DDLBairro.DataSource = BairrosDB.SelectAll();
        DDLBairro.DataTextField = "bai_nome";
        DDLBairro.DataValueField = "bai_id";
        DDLBairro.DataBind();
    }

    protected void Salvar_Click(object sender, EventArgs e)
    {
        Entregas ent = new Entregas();
        ent.Ent_frete = float.Parse(txtFrete.Text);
        //FK  
        Cidades cid = new Cidades();
        cid.Cid_id = Convert.ToInt32(rblCidade.SelectedValue);
        ent.Cid_id = cid;

        //FK
        //Estados est = new Estados();
        //est.Est_id = Convert.ToInt32(rblEstado.SelectedValue);
        //cid.Est_id = est;

        //FK
        Bairros bai = new Bairros();
        bai.Bai_id = Convert.ToInt32(rblBairro.SelectedValue);
        ent.Bai_id = bai;

        Empresas emp = new Empresas();
        Empresas id = (Empresas)Session["emp_empresa"];
        emp.Emp_id = Convert.ToInt32(id.Emp_id);
        ent.Emp_id = emp;

        ent.Ent_id = EntregasDB.Insert(ent);
        CarregarGrid();
    }

    private void CarregarGrid()
    {

        Empresas id = (Empresas)Session["emp_empresa"];

        DataSet ds = EntregasDB.SelectPorEmpresa(id.Emp_id);

        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            grid.DataSource = ds.Tables[0].DefaultView;
            grid.DataBind();
            grid.Visible = true;
        }
        else
        {
            grid.Visible = false;
        }
    }

    protected void grid_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName == "Editar")
        {

            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = grid.Rows[index];
            int id = Convert.ToInt32(row.Cells[0].Text);

            Entregas ent = new Entregas();
            DataSet ds = EntregasDB.SelectPorEntrega(id);

            ent.Ent_frete = Convert.ToInt32(ds.Tables[0].Rows[0]["ent_frete"]);

            ent.Bai_id = new Bairros();
            ent.Bai_id.Bai_id = Convert.ToInt32(ds.Tables[0].Rows[0]["bai_id"]);

            ent.Cid_id = new Cidades();
            ent.Cid_id.Cid_id = Convert.ToInt32(ds.Tables[0].Rows[0]["cid_id"]);

            ent.Cid_id.Est_id = new Estados();
            ent.Cid_id.Est_id.Est_id = Convert.ToInt32(ds.Tables[0].Rows[0]["est_id"]);

            DDLEstado.SelectedValue = ent.Cid_id.Est_id.Est_id.ToString();
            DDLCidade.SelectedValue = ent.Cid_id.Cid_id.ToString();
            DDLBairro.SelectedValue = ent.Bai_id.Bai_id.ToString();
            textFrete.Text = ent.Ent_frete.ToString();
            txtEnt_id.Text = id.ToString();

            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModalUpdate').modal('show');</script>", false);



        }

        if (e.CommandName == "Deletar")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = grid.Rows[index];
            int id = Convert.ToInt32(row.Cells[0].Text);

            int retorno;
            retorno = EntregasDB.Delete(id);
            if (retorno == 0)
            {
                CarregarGrid();
            }

        }
    }
    protected void grid_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {

    }

    protected void grid_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }


    protected void btn_Atualizar_Click(object sender, EventArgs e)
    {
        Entregas ent = new Entregas();
        int id = Convert.ToInt32(txtEnt_id.Text);
        DataSet ds = EntregasDB.SelectPorEntrega(id);

        ent.Ent_id = Convert.ToInt32(ds.Tables[0].Rows[0]["ent_id"]);
        ent.Ent_frete = Convert.ToInt32(ds.Tables[0].Rows[0]["ent_frete"]);

        ent.Bai_id = new Bairros();
        ent.Bai_id.Bai_id = Convert.ToInt32(ds.Tables[0].Rows[0]["bai_id"]);

        ent.Cid_id = new Cidades();
        ent.Cid_id.Cid_id = Convert.ToInt32(ds.Tables[0].Rows[0]["cid_id"]);

        ent.Cid_id.Est_id = new Estados();
        ent.Cid_id.Est_id.Est_id = Convert.ToInt32(ds.Tables[0].Rows[0]["est_id"]);

        ent.Cid_id.Est_id.Est_id = Convert.ToInt32(DDLEstado.SelectedValue);
        ent.Cid_id.Cid_id = Convert.ToInt32(DDLCidade.SelectedValue);
        ent.Bai_id.Bai_id = Convert.ToInt32(DDLBairro.SelectedValue);
        ent.Ent_frete = float.Parse(textFrete.Text);


        if (EntregasDB.Update(ent) == 2)
        {
            ltl.Text = ErrorPage;
        }
        else
        {
            CarregarGrid();
        }


    }
}