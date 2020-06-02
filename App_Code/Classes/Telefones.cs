using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Telefones
/// </summary>
public class Telefones
{
    private int tel_id;
    private int tel_ddd;
    private int tel_num;

    private Clientes cli_id;
    private Empresas emp_id;

    public int Tel_id { get => tel_id; set => tel_id = value; }
    public int Tel_ddd { get => tel_ddd; set => tel_ddd = value; }
    public int Tel_num { get => tel_num; set => tel_num = value; }
    public Clientes Cli_id { get => cli_id; set => cli_id = value; }
    public Empresas Emp_id { get => emp_id; set => emp_id = value; }
}