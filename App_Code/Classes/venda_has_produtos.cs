using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de venda_has_produtos
/// </summary>
public class venda_has_produtos
{

    private int ven_pro_id;
    private string ven_pro_valor;
    private string ven_pro_quantidade;

    private Produtos pro_id;
    private Vendas ven_id;

    public int Ven_pro_id { get => ven_pro_id; set => ven_pro_id = value; }
    public string Ven_pro_valor { get => ven_pro_valor; set => ven_pro_valor = value; }
    public string Ven_pro_quantidade { get => ven_pro_quantidade; set => ven_pro_quantidade = value; }
    public global::Produtos Pro_id { get => pro_id; set => pro_id = value; }
    public global::Vendas Ven_id { get => ven_id; set => ven_id = value; }
}