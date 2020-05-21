using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Endereco
/// </summary>
public class Enderecos
{
    private int end_id;
    private string end_cep;
    private string end_tipo;

    private Bairros bai_id;

    public int End_id { get => end_id; set => end_id = value; }
    public string End_cep { get => end_cep; set => end_cep = value; }
    public string End_tipo { get => end_tipo; set => end_tipo = value; }
    public global::Bairros Bai_id { get => bai_id; set => bai_id = value; }
}