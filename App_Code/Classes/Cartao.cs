using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

/// <summary>
/// Descrição resumida de Cartao
/// </summary>
public class Cartao
{
    private int car_id;
    private int car_cpf;
    private int car_num;
    private string car_nome;
    private DateTime car_vencimento;
    private string car_bandeira;
    private int car_cod;

    private Cliente cli_id;

    public int Car_id { get => car_id; set => car_id = value; }
    public int Car_cpf { get => car_cpf; set => car_cpf = value; }
    public int Car_num { get => car_num; set => car_num = value; }
    public string Car_nome { get => car_nome; set => car_nome = value; }
    public DateTime Car_vencimento { get => car_vencimento; set => car_vencimento = value; }
    public int Car_cod { get => car_cod; set => car_cod = value; }
    public Cliente Cli_id { get => cli_id; set => cli_id = value; }
    public string Car_bandeira { get => car_bandeira; set => car_bandeira = value; }
}