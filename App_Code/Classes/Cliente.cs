using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Cliente
/// </summary>
public class Cliente
{
    private int cli_id;
    private string cli_nome;
    private string cli_email;
    private string cli_senha;
    private char cli_sexo;

    private Endereco end_id;    //FK

    public int Cli_id { get => cli_id; set => cli_id = value; }
    public string Cli_nome { get => cli_nome; set => cli_nome = value; }
    public string Cli_email { get => cli_email; set => cli_email = value; }
    public string Cli_senha { get => cli_senha; set => cli_senha = value; }
    public char Cli_sexo { get => cli_sexo; set => cli_sexo = value; }
    public global::Endereco End_id { get => end_id; set => end_id = value; }
}