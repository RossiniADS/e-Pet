using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de imagens
/// </summary>
public class imagens
{
    private int img_id;
    private string img_descricao;
    private string img_url;

    private Produtos pro_id;

    public int Img_id { get => img_id; set => img_id = value; }
    public string Img_descricao { get => img_descricao; set => img_descricao = value; }
    public string Img_url { get => img_url; set => img_url = value; }
    public Produtos Pro_id { get => pro_id; set => pro_id = value; }
}