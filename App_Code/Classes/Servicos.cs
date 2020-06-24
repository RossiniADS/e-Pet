using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Servicos
/// </summary>
public class Servicos
{
    private int ser_id;
    private string ser_nome;
    private string ser_descricao;
    private string ser_caracteristica;
    private float ser_valor;

    private Empresas emp_id;

    public int Ser_id { get => ser_id; set => ser_id = value; }
    public string Ser_nome { get => ser_nome; set => ser_nome = value; }
    public string Ser_descricao { get => ser_descricao; set => ser_descricao = value; }
    public string Ser_caracteristica { get => ser_caracteristica; set => ser_caracteristica = value; }
    public float Ser_valor { get => ser_valor; set => ser_valor = value; }
    public global::Empresas Emp_id { get => emp_id; set => emp_id = value; }
}