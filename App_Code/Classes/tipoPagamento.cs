using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de tipoPagamento
/// </summary>
public class tipoPagamentos
{
    private int tip_id;
    private DateTime tip_data;
    private int tip_transacao;
    //private Enum tip_tipo;
    private Boolean tip_presencial;

    private Cartao car_id;
    private Vendas ven_id;

    public int Tip_id { get => tip_id; set => tip_id = value; }
    public DateTime Tip_data { get => tip_data; set => tip_data = value; }
    public int Tip_transacao { get => tip_transacao; set => tip_transacao = value; }
    public bool Tip_presencial { get => tip_presencial; set => tip_presencial = value; }
    public global::Cartao Car_id { get => car_id; set => car_id = value; }
    public global::Vendas Ven_id { get => ven_id; set => ven_id = value; }
}