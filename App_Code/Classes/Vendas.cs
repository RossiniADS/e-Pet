using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Venda
/// </summary>
public class Vendas
{
    private int ven_id;
    private DateTime ven_data_compra;
    private double ven_valor;
    private int ven_quantidade;

    public int Ven_id { get => ven_id; set => ven_id = value; }
    public DateTime Ven_data_compra { get => ven_data_compra; set => ven_data_compra = value; }
    public double Ven_valor { get => ven_valor; set => ven_valor = value; }
    public int Ven_quantidade { get => ven_quantidade; set => ven_quantidade = value; }
}