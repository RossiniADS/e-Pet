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
    private string car_cpf;
    private string car_num;
    private string car_nome;
    private DateTime car_data_vencimento;
    private string car_bandeira;
    private string car_cod_seguranca;

    private Clientes cli_id;

    public int Car_id { get => car_id; set => car_id = value; }
    public string Car_cpf { get => car_cpf; set => car_cpf = value; }
    public string Car_num { get => car_num; set => car_num = value; }
    public string Car_nome { get => car_nome; set => car_nome = value; }
    public DateTime Car_data_vencimento { get => car_data_vencimento; set => car_data_vencimento = value; }
    public string Car_bandeira { get => car_bandeira; set => car_bandeira = value; }
    public string Car_cod_seguranca { get => car_cod_seguranca; set => car_cod_seguranca = value; }
    public Clientes Cli_id { get => cli_id; set => cli_id = value; }
}