using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de avaliacao
/// </summary>
public class avaliacao
{
    private int ava_id;
    private float ava_nota;
    private string ava_comentario;

    private venda_has_produtos ven_pro_id;
    private Empresas emp_id;

    public int Ava_id { get => ava_id; set => ava_id = value; }
    public float Ava_nota { get => ava_nota; set => ava_nota = value; }
    public string Ava_comentario { get => ava_comentario; set => ava_comentario = value; }
    public global::venda_has_produtos Ven_pro_id { get => ven_pro_id; set => ven_pro_id = value; }
    public global::Empresas Emp_id { get => emp_id; set => emp_id = value; }
}