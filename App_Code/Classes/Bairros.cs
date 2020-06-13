using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Bairros
/// </summary>
public class Bairros
{
    private int bai_id;
    private string bai_nome;
    private string bai_rua;

    private Cidades cid_id;

    public int Bai_id { get => bai_id; set => bai_id = value; }
    public string Bai_nome { get => bai_nome; set => bai_nome = value; }
    public global::Cidades Cid_id { get => cid_id; set => cid_id = value; }
    public string Bai_rua { get => bai_rua; set => bai_rua = value; }
}