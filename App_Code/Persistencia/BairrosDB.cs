using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descrição resumida de BairrosDB
/// </summary>
public class BairrosDB
{
    public static int Insert(Bairros bairros)
    {
        int retorno = 0;

       // try
       // {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "insert into bai_bairro(bai_nome, cid_id) values(?bai_nome, ?cid_id)";

            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?bai_nome", bairros.Bai_nome));

            //FK
            objCommand.Parameters.Add(Mapped.Parameter("?cid_id", bairros.Cid_id.Cid_id));

            objCommand.ExecuteNonQuery();
            objConnection.Close();
            objConnection.Dispose();
            objCommand.Dispose();

      //  }
       // catch (Exception ex)
       // {
       //     return -2;
       // }
        return retorno;
    }
}