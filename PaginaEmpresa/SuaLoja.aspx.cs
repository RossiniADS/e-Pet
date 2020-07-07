﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class PaginaEmpresa_SuaLoja : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            carregaGrid();
            carregaGridServico();
        }
    }

    protected void carregaGrid()
    {
        try
        {
            Empresas id = (Empresas)Session["emp_empresa"];
            DataSet ds = EmpresasDB.ProdutoImagem(Convert.ToInt32(id.Emp_id));
            rptCardProduto.DataSource = ds;
            rptCardProduto.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void carregaGridServico()
    {
        try
        {
            Empresas id = (Empresas)Session["emp_empresa"];
            DataSet ds = ServicosDB.ServicoImagem(Convert.ToInt32(id.Emp_id));
            rptCardServico.DataSource = ds;
            rptCardServico.DataBind();
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        //EXCLUI A IMAGEM NA PASTA FOTOPRODUTO
        DataSet ds = ImagensDB.SelectPorProduto(Convert.ToInt32(txtPro_id2.Text));
        string imgUrl = Convert.ToString(ds.Tables[0].Rows[0]["img_url"]);

        File.Delete(Request.PhysicalApplicationPath + "e-Pet\\" + imgUrl);


        Produtos pro = new Produtos();
        pro.Pro_id = Convert.ToInt32(txtPro_id2.Text);

        switch (ProdutosDB.Delete(pro))
        {
            case 0:
                ltlDelete.Text = "<p class='text-success'>Delete - OK!</p>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModalDelete').modal('show');</script>", false);

                Response.Redirect("SuaLoja.aspx");
                break;
            case -2:
                ltlDelete.Text = "<p class='text-Danger'>Delete - ERRO!</p>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModalDelete').modal('show');</script>", false);
                break;
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Button btn = (sender as Button);

        string[] arr = btn.CommandArgument.ToString().Split('|');
        hdUpdate.Value = arr[0];
        txtNome.Text = arr[0];
        txtTipo.Text = arr[1];
        txtVencimento.Text = arr[2];
        txtQuantidade.Text = arr[3];
        txtValor.Text = arr[4];
        txtPro_id.Text = arr[5];
        txtCaracteristica.Text = arr[6].Replace("<br />", "\n");
        txtDescricao.Text = arr[7].Replace("<br />", "\n");

        //ltlUpdate.Text = btn.CommandArgument.ToString();
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModalUpdate').modal('show');</script>", false);

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Button btn = (sender as Button);

        string[] arr = btn.CommandArgument.ToString().Split('|');
        txtNomeProduto.Text = arr[0];
        txtPro_id2.Text = arr[1];
        ltlDelete.Text = "<h5 class='text-danger'>Deseja excluir esse produto?</h5>";

        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModalDelete').modal('show');</script>", false);

    }

    protected void btn_Salvar_Click(object sender, EventArgs e)
    {
        Produtos pro = new Produtos();
        pro.Pro_nome = txtNome.Text;
        pro.Pro_vencimento = Convert.ToDateTime(txtVencimento.Text);
        pro.Pro_quantidade = Convert.ToInt32(txtQuantidade.Text);
        pro.Pro_tipo = txtTipo.Text;
        pro.Pro_valor = Convert.ToDouble(txtValor.Text);
        pro.Pro_id = Convert.ToInt32(txtPro_id.Text);
        pro.Pro_caracteristica = txtCaracteristica.Text.Replace("\n", "<br />");
        pro.Pro_descricao = txtDescricao.Text.Replace("\n", "<br />");

        switch (ProdutosDB.Update(pro))
        {
            case 0:
                ltlUpdate.Text = "<p class='text-success'>Update - OK!</p>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModalUpdate').modal('show');</script>", false);
                Response.Redirect("SuaLoja.aspx");
                break;
            case -2:
                ltlUpdate.Text = "<p class='text-Danger'>Update - ERRO!</p>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModalUpdate').modal('show');</script>", false);
                break;
        }
    }

    protected void btnDeleteServico_Click(object sender, EventArgs e)
    {

    }

    protected void btnUpdateServico_Click(object sender, EventArgs e)
    {

    }
}