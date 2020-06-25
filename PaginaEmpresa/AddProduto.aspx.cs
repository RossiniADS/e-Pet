using System;
using System.Collections.Generic;
using System.IO;
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
        Imagens img = new Imagens();



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
            pro.Pro_id = ProdutosDB.Insert(pro);

            // Você tem que criar uma pasta para o Upload de imagens
            // em nosso exemplo e a pasta foto
            string path = Path.Combine(Request.PhysicalApplicationPath, "FotoProduto");
            if (fileArquivo.HasFile)
            {
                string extensao =
                System.IO.Path.GetExtension(fileArquivo.FileName).ToLower();
                string[] extensoesPermitidas = { ".png", ".jpeg", ".jpg" };
                if (extensoesPermitidas.Contains(extensao))
                {
                    try
                    {
                        string fileName = fileArquivo.FileName.Replace(" ", "");
                        string caminhoUpload = Path.Combine(path, fileName);
                        caminhoUpload = Path.Combine(path, fileName);
                        fileArquivo.PostedFile.SaveAs(caminhoUpload);
                        lblMsg.Text = "<div class='alert alert-success'>Upload da foto realizado com sucesso!</ div > ";
                        img.Img_url = ltlUrl.Text = "<img src='../FotoProduto/" + fileName + "'class='img-responsive img-thumbnail' alt='Logo'/>";
                    }
                    catch (Exception ex)
                    {
                        lblMsg.Text = "Erro arquivo:" + ex.Message;
                    }
                }
                else
                    lblMsg.Text = "<div class='alert alert-danger'>Arquivo com extensão não permitida!</div>";
            }

            img.Pro_id = pro;
            switch (ImagensDB.InsertImgProduto(img))
            {
                case -2:
                    ltl.Text = "<p class='text-success'>Erro no produto</p>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                    break;

                default:
                    ltl.Text = "<p class='text-success'>Produto adicionado com sucesso</p>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                    LimpaCampos();
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
            ser.Ser_id = ServicosDB.Insert(ser);

            // Você tem que criar uma pasta para o Upload de imagens
            // em nosso exemplo e a pasta foto
            string path = Path.Combine(Request.PhysicalApplicationPath, "FotoProduto");
            if (fileArquivo.HasFile)
            {
                string extensao =
                System.IO.Path.GetExtension(fileArquivo.FileName).ToLower();
                string[] extensoesPermitidas = { ".png", ".jpeg", ".jpg" };
                if (extensoesPermitidas.Contains(extensao))
                {
                    try
                    {
                        string fileName = fileArquivo.FileName.Replace(" ", "");
                        string caminhoUpload = Path.Combine(path, fileName);
                        caminhoUpload = Path.Combine(path, fileName);
                        fileArquivo.PostedFile.SaveAs(caminhoUpload);
                        lblMsg.Text = "<div class='alert alert-success'>Upload da foto realizado com sucesso!</ div > ";
                        img.Img_url = ltlUrl.Text = "<img src='../FotoProduto/" + fileName + "'class='img-responsive img-thumbnail' style = 'width: 10%; height: 10%;' alt='Logo'/>";
                    }
                    catch (Exception ex)
                    {
                        lblMsg.Text = "Erro arquivo:" + ex.Message;
                    }
                }
                else
                    lblMsg.Text = "<div class='alert alert-danger'>Arquivo com extensão não permitida!</div>";
            }

            img.Ser_id = ser;
            switch (ImagensDB.InsertImgServico(img))
            {
                case -2:
                    ltl.Text = "<p class='text-success'>Erro no produto</p>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                    break;

                default:
                    ltl.Text = "<p class='text-success'>Produto adicionado com sucesso</p>";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                    LimpaCampos();
                    break;
            }

        }
    }
    public void LimpaCampos()
    {
        ProNome.Text = string.Empty;
        ProTipo.Text = string.Empty;
        ProDesc.Text = string.Empty;
        ProCarac.Text = string.Empty;
        ProQtd.Text = string.Empty;
        ProVenc.Text = string.Empty;
        ProValor.Text = string.Empty;

        ServNome.Text = string.Empty;
        ServDesc.Text = string.Empty;
        ServCarac.Text = string.Empty;
        ServValor.Text = string.Empty;

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