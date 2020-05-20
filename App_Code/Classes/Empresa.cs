using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Empresa
/// </summary>
public class Empresa
{
    private int emp_id;
    private int emp_cnpj;
    private string emp_nome;
    private string emp_email;
    private string emp_senha;

    private Endereco end_id;

    public int Emp_id { get => emp_id; set => emp_id = value; }
    public int Emp_cnpj { get => emp_cnpj; set => emp_cnpj = value; }
    public string Emp_nome { get => emp_nome; set => emp_nome = value; }
    public string Emp_email { get => emp_email; set => emp_email = value; }
    public string Emp_senha { get => emp_senha; set => emp_senha = value; }
    public Endereco End_id { get => end_id; set => end_id = value; }
}