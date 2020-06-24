using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de venda_has_servico
/// </summary>
public class venda_has_servico
{
    private int ven_ser_id;
    private float ven_ser_valor;
    private int ven_ser_quantidade;

    private Vendas ven_id;
    private Servicos ser_id;

    public int Ven_ser_id { get => ven_ser_id; set => ven_ser_id = value; }
    public float Ven_ser_valor { get => ven_ser_valor; set => ven_ser_valor = value; }
    public int Ven_ser_quantidade { get => ven_ser_quantidade; set => ven_ser_quantidade = value; }
    public global::Vendas Ven_id { get => ven_id; set => ven_id = value; }
    public global::Servicos Ser_id { get => ser_id; set => ser_id = value; }
}