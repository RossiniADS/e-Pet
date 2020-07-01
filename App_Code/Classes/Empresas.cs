using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Empresa
/// </summary>
public class Empresas
{
    private int emp_id;
    private string emp_razao_social;
    private string emp_email;
    private string emp_nome_fantasia;
    private string emp_cnpj;
    private string emp_senha;
    private string emp_img_url;
    private string emp_numero_endereco;
    private string emp_foto_url;

    private Enderecos end_id;

    public int Emp_id { get => emp_id; set => emp_id = value; }
    public string Emp_razao_social { get => emp_razao_social; set => emp_razao_social = value; }
    public string Emp_email { get => emp_email; set => emp_email = value; }
    public string Emp_nome_fantasia { get => emp_nome_fantasia; set => emp_nome_fantasia = value; }
    public string Emp_cnpj { get => emp_cnpj; set => emp_cnpj = value; }
    public string Emp_senha { get => emp_senha; set => emp_senha = value; }
    public string Emp_numero_endereco { get => emp_numero_endereco; set => emp_numero_endereco = value; }
    public string Emp_foto_url { get => emp_foto_url; set => emp_foto_url = value; }
    public global::Enderecos End_id { get => end_id; set => end_id = value; }
    public string Emp_img_url { get => emp_img_url; set => emp_img_url = value; }
}