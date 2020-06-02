using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Class1
/// </summary>
public class Cidades
{
    private int cid_id;
    private string cid_nome;

    private Estados est_id;

    public int Cid_id { get => cid_id; set => cid_id = value; }
    public string Cid_nome { get => cid_nome; set => cid_nome = value; }
    public global::Estados Est_id { get => est_id; set => est_id = value; }
}