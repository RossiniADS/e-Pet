using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using UpFoto.Classes;

public partial class PaginaEmpresa_AddProduto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Emp_empresa"] == null)
        {
            Response.Redirect("../Pag/Login.aspx");
        }
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
            pro.Pro_descricao = ProDesc.Text.Replace("\n", "<br />");
            pro.Pro_caracteristica = ProCarac.Text.Replace("\n", "<br />");
            pro.Pro_quantidade = Convert.ToInt32(ProQtd.Text);
            pro.Pro_vencimento = Convert.ToDateTime(ProVenc.Text);
            pro.Pro_valor = Convert.ToDouble(ProValor.Text);

            //FK
            emp.Emp_id = Convert.ToInt32(id.Emp_id);
            pro.Emp_id = emp;
            pro.Pro_id = ProdutosDB.Insert(pro);


            img.Pro_id = pro;

            if (FileUploadControl.PostedFile.ContentLength < 8388608)
            {
                try
                {
                    if (FileUploadControl.HasFile)
                    {
                        try
                        {
                            //Aqui ele vai filtrar pelo tipo de arquivo
                            if (FileUploadControl.PostedFile.ContentType == "image/jpeg" ||
                                FileUploadControl.PostedFile.ContentType == "image/png" ||
                                FileUploadControl.PostedFile.ContentType == "image/gif" ||
                                FileUploadControl.PostedFile.ContentType == "image/bmp")
                            {
                                try
                                {
                                    //Obtem o  HttpFileCollection
                                    HttpFileCollection hfc = Request.Files;
                                    for (int i = 0; i < hfc.Count; i++)
                                    {
                                        HttpPostedFile hpf = hfc[i];
                                        if (hpf.ContentLength > 0)
                                        {
                                            //Pega o nome do arquivo
                                            string nome = System.IO.Path.GetFileName(hpf.FileName);
                                            //Pega a extensão do arquivo
                                            string extensao = Path.GetExtension(hpf.FileName);
                                            //Gera nome novo do Arquivo numericamente
                                            string filename = string.Format("{0:00000000000000}", GerarID());
                                            //Caminho a onde será salvo
                                            hpf.SaveAs(Server.MapPath("~/FotoProduto/") + filename + i
                                            + extensao);

                                            //Prefixo p/ img m
                                            var prefixoG = "-m";

                                            //pega o arquivo já carregado
                                            string pth = Server.MapPath("~/FotoProduto/")
                                            + filename + i + extensao;

                                            //Redefine altura e largura da imagem e Salva o arquivo + prefixo
                                            Redefinir.resizeImageAndSave(pth, 500, 331, prefixoG);
                                            //     H    V    

                                            img.Img_url = "../FotoProduto/" + filename + i + prefixoG + extensao;

                                            File.Delete(Request.PhysicalApplicationPath + "FotoProduto\\" + filename + i + extensao);

                                            switch (ImagensDB.InsertImgProduto(img))
                                            {
                                                case -2:
                                                    ltl.Text = "<p class='text-success'>Erro no produto</p>";
                                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                                                    File.Delete(Request.PhysicalApplicationPath + "FotoProduto\\" + filename + i + prefixoG + extensao);
                                                    break;
                                                default:
                                                    ltl.Text = "<p class='text-success'>Produto adicionado com sucesso</p>";
                                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                                                    LimpaCampos();
                                                    break;
                                            }
                                        }

                                    }
                                }
                                catch (Exception ex)
                                {
                                    throw;
                                }
                                // Mensagem se tudo ocorreu bem
                                StatusLabel.Text = "Todas imagens carregadas com sucesso!";

                            }
                            else
                            {
                                // Mensagem notifica que é permitido carregar apenas 
                                // as imagens definida la em cima.
                                StatusLabel.Text = "É permitido carregar apenas imagens!";
                            }
                        }
                        catch (Exception ex)
                        {
                            // Mensagem notifica quando ocorre erros
                            StatusLabel.Text = "O arquivo não pôde ser carregado. O seguinte erro ocorreu: " + ex.Message;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mensagem notifica quando ocorre erros
                    StatusLabel.Text = "O arquivo não pôde ser carregado. O seguinte erro ocorreu: " + ex.Message;
                }
            }
            else
            {
                // Mensagem notifica quando imagem é superior a 8 MB
                StatusLabel.Text = "Não é permitido carregar mais do que 8 MB";
            }
        }
        else
        {
            Servicos ser = new Servicos();
            ser.Ser_nome = ServNome.Text;
            ser.Ser_descricao = ServDesc.Text.Replace("\n", "<br />");
            ser.Ser_caracteristica = ServCarac.Text.Replace("\n", "<br />");
            ser.Ser_valor = float.Parse(ServValor.Text);

            //FK
            emp.Emp_id = Convert.ToInt32(id.Emp_id);
            ser.Emp_id = emp;
            ser.Ser_id = ServicosDB.Insert(ser);

            img.Ser_id = ser;



            if (FileUploadControl.PostedFile.ContentLength < 8388608)
            {
                try
                {
                    if (FileUploadControl.HasFile)
                    {
                        try
                        {
                            //Aqui ele vai filtrar pelo tipo de arquivo
                            if (FileUploadControl.PostedFile.ContentType == "image/jpeg" ||
                                FileUploadControl.PostedFile.ContentType == "image/png" ||
                                FileUploadControl.PostedFile.ContentType == "image/gif" ||
                                FileUploadControl.PostedFile.ContentType == "image/bmp")
                            {
                                try
                                {
                                    //Obtem o  HttpFileCollection
                                    HttpFileCollection hfc = Request.Files;
                                    for (int i = 0; i < hfc.Count; i++)
                                    {
                                        HttpPostedFile hpf = hfc[i];
                                        if (hpf.ContentLength > 0)
                                        {
                                            //Pega o nome do arquivo
                                            string nome = System.IO.Path.GetFileName(hpf.FileName);
                                            //Pega a extensão do arquivo
                                            string extensao = Path.GetExtension(hpf.FileName);
                                            //Gera nome novo do Arquivo numericamente
                                            string filename = string.Format("{0:00000000000000}", GerarID());
                                            //Caminho a onde será salvo
                                            hpf.SaveAs(Server.MapPath("~/FotoServiço/") + filename + i
                                            + extensao);

                                            //Prefixo p/ img m
                                            var prefixoG = "-m";

                                            //pega o arquivo já carregado
                                            string pth = Server.MapPath("~/FotoServiço/")
                                            + filename + i + extensao;

                                            //Redefine altura e largura da imagem e Salva o arquivo + prefixo
                                            Redefinir.resizeImageAndSave(pth, 500, 331, prefixoG);
                                            //     H    V    

                                            img.Img_url = "../FotoServiço/" + filename + i + prefixoG + extensao;

                                            File.Delete(Request.PhysicalApplicationPath + "FotoServiço\\" + filename + i + extensao);

                                            switch (ImagensDB.InsertImgServico(img))
                                            {
                                                case -2:
                                                    ltl.Text = "<p class='text-success'>Erro no serviço</p>";
                                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                                                    File.Delete(Request.PhysicalApplicationPath + "FotoServiço\\" + filename + i + prefixoG + extensao);
                                                    break;

                                                default:
                                                    ltl.Text = "<p class='text-success'>Serviço adicionado com sucesso</p>";
                                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
                                                    LimpaCampos();
                                                    break;
                                            }
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    throw;
                                }
                                // Mensagem se tudo ocorreu bem
                                StatusLabel.Text = "Todas imagens carregadas com sucesso!";
                            }
                            else
                            {
                                // Mensagem notifica que é permitido carregar apenas 
                                // as imagens definida la em cima.
                                StatusLabel.Text = "É permitido carregar apenas imagens!";
                            }
                        }
                        catch (Exception ex)
                        {
                            // Mensagem notifica quando ocorre erros
                            StatusLabel.Text = "O arquivo não pôde ser carregado. O seguinte erro ocorreu: " + ex.Message;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mensagem notifica quando ocorre erros
                    StatusLabel.Text = "O arquivo não pôde ser carregado. O seguinte erro ocorreu: " + ex.Message;
                }
            }
            else
            {
                // Mensagem notifica quando imagem é superior a 8 MB
                StatusLabel.Text = "Não é permitido carregar mais do que 8 MB";
            }
        }
    }

    public Int64 GerarID()
    {
        try
        {
            DateTime data = new DateTime();
            data = DateTime.Now;
            string s = data.ToString().Replace("/", "").Replace(":", "").Replace(" ", "");
            return Convert.ToInt64(s);
        }
        catch (Exception erro)
        {
            throw;
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