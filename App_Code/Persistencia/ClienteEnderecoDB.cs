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

    public static DataSet SelectEndereco(int cli_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from cle_cliente_endereco where cli_id = ?cli_id";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?cli_id", cli_id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Update(ClienteEndereco clienteEndereco)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "update cle_cliente_endereco set cle_num = ?cle_num where cle_id = ?cle_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?cle_id", clienteEndereco.Cle_id));
            objCommand.Parameters.Add(Mapped.Parameter("?cle_num", clienteEndereco.Cle_num));

            objCommand.ExecuteNonQuery();

            objConnection.Close();
            objConnection.Dispose();
            objCommand.Dispose();

        }
        catch (Exception ex)
        {
            retorno = -2;
        }
        return retorno;

    }
}