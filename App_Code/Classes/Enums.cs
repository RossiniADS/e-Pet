using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Enums
/// </summary>
public class Enums
{
    public enum Ven_status_entrega
    {
        SEPARAÇÃO_PRODUTO, 
        PRODUTO_CAMINHO, 
        PRODUTO_ENTREGUE
    }

    public enum ven_status_pagamento
    {
        AGUARDANDO_CONFIRMAÇÃO, 
        PAGAMENTO_CONFIRMADO,
        PAGAMENTO_NÃO_EFETUADO
    }

    public enum tip_tipo_pagamento
    {
        CARTAO_CREDITO, 
        CARTAO_DEBITO, 
        DINHEIRO
    }
}