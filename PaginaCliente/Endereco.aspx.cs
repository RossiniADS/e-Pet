﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Correios;
using System.Web.UI.WebControls;
using System.ServiceModel.Description;
using System.Data;

public partial class PaginaCliente_Endereco : System.Web.UI.Page
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
        Clientes cli = (Clientes)Session["cli_cliente"];

        ClienteEndereco cle = new ClienteEndereco();
        DataSet ds = ClienteEnderecoDB.SelectEndereco(cli.Cli_id);
        cle.Cle_id = Convert.ToInt32(ds.Tables[0].Rows[0]["Cle_id"]);
        cle.Cle_descricao = Convert.ToString(ds.Tables[0].Rows[0]["Cle_descricao"]);
        cle.Cle_num = Convert.ToString(ds.Tables[0].Rows[0]["Cle_num"]);
        //cle.Cle_principal = Convert.ToBoolean(ds.Tables[0].Rows[0]["cle_principal"]);
        cle.End_id = new Enderecos();
        cle.End_id.End_id = Convert.ToInt32(ds.Tables[0].Rows[0]["end_id"]);


        DataSet dsEnd = EnderecosDB.SelectEndereco(cle.End_id.End_id);
        cle.End_id.End_cep = Convert.ToString(dsEnd.Tables[0].Rows[0]["End_cep"]);
        cle.End_id.End_tipo = Convert.ToString(dsEnd.Tables[0].Rows[0]["end_tipo"]);

        cle.End_id.Bai_id = new Bairros();
        cle.End_id.Bai_id.Bai_id = Convert.ToInt32(dsEnd.Tables[0].Rows[0]["bai_id"]);


        DataSet dsBai = BairrosDB.SelectBairro(cle.End_id.Bai_id.Bai_id);
        cle.End_id.Bai_id.Bai_nome = Convert.ToString(dsBai.Tables[0].Rows[0]["bai_nome"]);

        cle.End_id.Bai_id.Cid_id = new Cidades();
        cle.End_id.Bai_id.Cid_id.Cid_id = Convert.ToInt32(dsBai.Tables[0].Rows[0]["cid_id"]);
        DataSet dsCid = CidadesDB.SelectCid(cle.End_id.Bai_id.Cid_id.Cid_id);

        cle.End_id.Bai_id.Cid_id.Cid_nome = Convert.ToString(dsCid.Tables[0].Rows[0]["cid_nome"]);
        cle.End_id.Bai_id.Cid_id.Est_id = new Estados();
        cle.End_id.Bai_id.Cid_id.Est_id.Est_id = Convert.ToInt32(dsCid.Tables[0].Rows[0]["est_id"]);
        cle.End_id.Bai_id.Cid_id.Est_id.Est_nome = Convert.ToString(dsCid.Tables[0].Rows[0]["est_nome"]);
        cle.End_id.Bai_id.Cid_id.Est_id.Est_uf = Convert.ToString(dsCid.Tables[0].Rows[0]["est_uf"]);

        textBairro.Text = cle.End_id.Bai_id.Bai_nome;
        textCep.Text = cle.End_id.End_cep;
        textNumero.Text = cle.Cle_num;
        textRua.Text = "";
        textComplemento.Text = cle.End_id.End_tipo;
        rblCidade.SelectedValue = cle.End_id.Bai_id.Cid_id.Cid_id.ToString();
        rblEstado.SelectedValue = cle.End_id.Bai_id.Cid_id.Est_id.Est_id.ToString();


    }

    protected void btnAtualizar_Click(object sender, EventArgs e)
    {
        Clientes cli = (Clientes)Session["cli_cliente"];

        ClienteEndereco cle = new ClienteEndereco();
        DataSet ds = ClienteEnderecoDB.SelectEndereco(cli.Cli_id);
        cle.Cle_id = Convert.ToInt32(ds.Tables[0].Rows[0]["cle_id"]);
        cle.Cle_descricao = Convert.ToString(ds.Tables[0].Rows[0]["Cle_descricao"]);
        cle.Cle_num = Convert.ToString(ds.Tables[0].Rows[0]["Cle_num"]);
        //cle.Cle_principal = Convert.ToBoolean(ds.Tables[0].Rows[0]["cle_principal"]);
        cle.End_id = new Enderecos();
        cle.End_id.End_id = Convert.ToInt32(ds.Tables[0].Rows[0]["end_id"]);


        DataSet dsEnd = EnderecosDB.SelectEndereco(cle.End_id.End_id);
        cle.End_id.End_cep = Convert.ToString(dsEnd.Tables[0].Rows[0]["End_cep"]);
        cle.End_id.End_tipo = Convert.ToString(dsEnd.Tables[0].Rows[0]["end_tipo"]);

        cle.End_id.Bai_id = new Bairros();
        cle.End_id.Bai_id.Bai_id = Convert.ToInt32(dsEnd.Tables[0].Rows[0]["bai_id"]);


        DataSet dsBai = BairrosDB.SelectBairro(cle.End_id.Bai_id.Bai_id);
        cle.End_id.Bai_id.Bai_nome = Convert.ToString(dsBai.Tables[0].Rows[0]["bai_nome"]);

        cle.End_id.Bai_id.Cid_id = new Cidades();
        cle.End_id.Bai_id.Cid_id.Cid_id = Convert.ToInt32(dsBai.Tables[0].Rows[0]["cid_id"]);
        DataSet dsCid = CidadesDB.SelectCid(cle.End_id.Bai_id.Cid_id.Cid_id);

        cle.End_id.Bai_id.Cid_id.Cid_nome = Convert.ToString(dsCid.Tables[0].Rows[0]["cid_nome"]);
        cle.End_id.Bai_id.Cid_id.Est_id = new Estados();
        cle.End_id.Bai_id.Cid_id.Est_id.Est_id = Convert.ToInt32(dsCid.Tables[0].Rows[0]["est_id"]);
        cle.End_id.Bai_id.Cid_id.Est_id.Est_nome = Convert.ToString(dsCid.Tables[0].Rows[0]["est_nome"]);
        cle.End_id.Bai_id.Cid_id.Est_id.Est_uf = Convert.ToString(dsCid.Tables[0].Rows[0]["est_uf"]);

        cle.End_id.Bai_id.Bai_nome = textBairro.Text;
        cle.End_id.End_cep = textCep.Text;
        cle.Cle_num = textNumero.Text;
        //textRua.Text = "";
        cle.End_id.End_tipo = textComplemento.Text;
        cle.End_id.Bai_id.Cid_id.Cid_id = Convert.ToInt32(rblCidade.SelectedValue);
        cle.End_id.Bai_id.Cid_id.Est_id.Est_id = Convert.ToInt32(rblEstado.SelectedValue);

        BairrosDB.Update(cle.End_id.Bai_id);
        EnderecosDB.Update(cle.End_id);
        ClienteEnderecoDB.Update(cle);
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