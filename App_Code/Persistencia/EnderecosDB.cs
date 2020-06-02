using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descrição resumida de EnderecosDB
/// </summary>
public class EnderecosDB
{
    public static int Insert(Enderecos enderecos)
    {
        int retorno = 0;

       // try
       // {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "insert into end_endereco(end_cep, end_tipo, bai_id) values(?end_cep, ?end_tipo, ?bai_id)";

            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?end_cep", enderecos.End_cep));
            objCommand.Parameters.Add(Mapped.Parameter("?end_tipo", enderecos.End_tipo));

            //FK
            objCommand.Parameters.Add(Mapped.Parameter("?bai_id", enderecos.Bai_id.Bai_id));

            objCommand.ExecuteNonQuery();
            objConnection.Close();
            objConnection.Dispose();
            objCommand.Dispose();

       // }
       // catch (Exception ex)
       // {
        //    retorno = -2;
        //}
        return retorno;
    }
}