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
    private string tel_ddd;
    private string tel_num;

    private Empresas emp_id;

    public int Tel_id { get => tel_id; set => tel_id = value; }
    public string Tel_ddd { get => tel_ddd; set => tel_ddd = value; }
    public string Tel_num { get => tel_num; set => tel_num = value; }
    public global::Empresas Emp_id { get => emp_id; set => emp_id = value; }
}