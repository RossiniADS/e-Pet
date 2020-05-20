using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Endereco
/// </summary>
public class Endereco
{
    private int end_id;
    private string end_local;
    private string end_cep;
    private string end_tipo;
    private string end_num;
    private string end_bairro;
    private string end_cidade;
    private string end_estado;
    private string end_uf;

    public int End_id { get => end_id; set => end_id = value; }
    public string End_local { get => end_local; set => end_local = value; }
    public string End_cep { get => end_cep; set => end_cep = value; }
    public string End_tipo { get => end_tipo; set => end_tipo = value; }
    public string End_num { get => end_num; set => end_num = value; }
    public string End_bairro { get => end_bairro; set => end_bairro = value; }
    public string End_cidade { get => end_cidade; set => end_cidade = value; }
    public string End_estado { get => end_estado; set => end_estado = value; }
    public string End_uf { get => end_uf; set => end_uf = value; }
}