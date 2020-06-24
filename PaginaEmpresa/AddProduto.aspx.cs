using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaginaEmpresa_AddProduto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            pnlProduto.Visible = true;
            pnlServico.Visible = false;
        }
    }



    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Empresas id = (Empresas)Session["emp_empresa"];
        Empresas emp = new Empresas();
        if (EscolheCategoria.SelectedValue == "1")
        {
            Produtos pro = new Produtos();
            pro.Pro_nome = ProNome.Text;
            pro.Pro_tipo = ProTipo.Text;
            pro.Pro_descricao = ProDesc.Text;
            pro.Pro_caracteristica = ProCarac.Text;
            pro.Pro_quantidade = Convert.ToInt32(ProQtd.Text);
            pro.Pro_vencimento = Convert.ToDateTime(ProVenc.Text);
            pro.Pro_valor = Convert.ToDouble(ProValor.Text);

            //FK
            emp.Emp_id = Convert.ToInt32(id.Emp_id);
            pro.Emp_id = emp;
            switch (ProdutosDB.Insert(pro))
            {
                case -2:
                    ltl.Text = "<p class='text-success'>Erro no produto</p>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                    break;

                default:
                    ltl.Text = "<p class='text-success'>Produto adicionado com sucesso</p>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                    limpaCampos();
                    break;
            }
        }
        else
        {
            Servicos ser = new Servicos();
            ser.Ser_nome = ServNome.Text;
            ser.Ser_descricao = ServDesc.Text;
            ser.Ser_caracteristica = ServCarac.Text;
            ser.Ser_valor = Convert.ToInt32(ServValor.Text);

            //FK
            emp.Emp_id = Convert.ToInt32(id.Emp_id);
            ser.Emp_id = emp;

            switch (ServicosDB.Insert(ser))
            {
                case -2:
                    ltl.Text = "<p class='text-success'>Erro no produto</p>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                    break;

                default:
                    ltl.Text = "<p class='text-success'>Produto adicionado com sucesso</p>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                    limpaCampos();
                    break;
            }

        }
    }
    public void limpaCampos()
    {
        ProNome.Text = string.Empty;
        ProTipo.Text = string.Empty;
        ProDesc.Text = string.Empty;
        ProCarac.Text = string.Empty;
        ProQtd.Text = string.Empty;
        ProVenc.Text = string.Empty;
        ProValor.Text = string.Empty;
    }

    protected void EscolheCategoria_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (EscolheCategoria.SelectedValue)
        {
            case "1":
                pnlProduto.Visible = true;
                pnlServico.Visible = false;
                break;
            case "2":
                pnlProduto.Visible = false;
                pnlServico.Visible = true;
                break;
        }
    }
}