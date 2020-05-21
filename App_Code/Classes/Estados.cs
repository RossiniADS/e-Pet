using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Estados
/// </summary>
public class Estados
{
    private int est_id;
    private string est_nome;
    private string est_uf;

    public int Est_id { get => est_id; set => est_id = value; }
    public string Est_nome { get => est_nome; set => est_nome = value; }
    public string Est_uf { get => est_uf; set => est_uf = value; }
}