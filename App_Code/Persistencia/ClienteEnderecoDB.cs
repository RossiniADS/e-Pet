using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descrição resumida de ClienteEnderecoDB
/// </summary>
public class ClienteEnderecoDB
{
    public static int Insert(ClienteEndereco clienteEndereco)
    {
        int retorno = 0;

        //try
        //{
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "insert into cle_cliente_endereco(cle_num, cli_id, end_id) values(?cle_num, ?cli_id, ?end_id)";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?cle_num", clienteEndereco.Cle_num));

            //FK
            objCommand.Parameters.Add(Mapped.Parameter("?cli_id", clienteEndereco.Cli_id.Cli_id));
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", clienteEndereco.End_id.End_id));

            objCommand.ExecuteNonQuery();
            objConnection.Close();
            objConnection.Dispose();
            objCommand.Dispose();
        //}
        /*catch (Exception ex)
        {
            retorno = -2;
        }*/
        return retorno;
    }
}