using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Entregas
/// </summary>
public class Entregas
{
    private int ent_id;
    private Boolean ent_ativo;
    private string ent_frete;

    private Bairros bai_id;
    private Cidades cid_id;
    private Empresas emp_id;

    public int Ent_id { get => ent_id; set => ent_id = value; }
    public bool Ent_ativo { get => ent_ativo; set => ent_ativo = value; }
    public string Ent_frete { get => ent_frete; set => ent_frete = value; }
    public global::Bairros Bai_id { get => bai_id; set => bai_id = value; }
    public global::Cidades Cid_id { get => cid_id; set => cid_id = value; }
    public global::Empresas Emp_id { get => emp_id; set => emp_id = value; }
}