using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de imagens
/// </summary>
public class Imagens
{
    private int img_id;
    private string img_descricao;
    private string img_url;

    private Produtos pro_id;
    private Servicos ser_id;

    public int Img_id { get => img_id; set => img_id = value; }
    public string Img_descricao { get => img_descricao; set => img_descricao = value; }
    public string Img_url { get => img_url; set => img_url = value; }
    public global::Produtos Pro_id { get => pro_id; set => pro_id = value; }
    public global::Servicos Ser_id { get => ser_id; set => ser_id = value; }
}