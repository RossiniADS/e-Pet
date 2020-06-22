using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Produto
/// </summary>
public class Produtos
{
    private int pro_id;
    private string pro_nome;
    private string pro_tipo;
    private string pro_descricao;
    private string pro_caracteristica;
    private int pro_quantidade;
    private double pro_valor;
    private DateTime pro_vencimento;

    private Empresas emp_id;

    public int Pro_id { get => pro_id; set => pro_id = value; }
    public string Pro_nome { get => pro_nome; set => pro_nome = value; }
    public string Pro_tipo { get => pro_tipo; set => pro_tipo = value; }
    public string Pro_descricao { get => pro_descricao; set => pro_descricao = value; }
    public string Pro_caracteristica { get => pro_caracteristica; set => pro_caracteristica = value; }
    public int Pro_quantidade { get => pro_quantidade; set => pro_quantidade = value; }
    public double Pro_valor { get => pro_valor; set => pro_valor = value; }
    public DateTime Pro_vencimento { get => pro_vencimento; set => pro_vencimento = value; }
    public global::Empresas Emp_id { get => emp_id; set => emp_id = value; }
}