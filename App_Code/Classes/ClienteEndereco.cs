using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ClienteEndereco
/// </summary>
public class ClienteEndereco
{
    private int cle_id;
    private Boolean cle_principal;
    private string cle_descricao;
    private string cle_num;


    private Clientes cli_id;
    private Enderecos end_id;

    public int Cle_id { get => cle_id; set => cle_id = value; }
    public bool Cle_principal { get => cle_principal; set => cle_principal = value; }
    public string Cle_descricao { get => cle_descricao; set => cle_descricao = value; }
    public global::Clientes Cli_id { get => cli_id; set => cli_id = value; }
    public global::Enderecos End_id { get => end_id; set => end_id = value; }
    public string Cle_num { get => cle_num; set => cle_num = value; }
}