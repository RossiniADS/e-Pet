using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descrição resumida de CidadesDB
/// </summary>
public class CidadesDB
{
    public static int Insert(Cidades cidades)
    {
        int retorno = 0;

        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "insert into cid_cidade(cid_nome, est_id) values(?cid_nome, ?est_id); select last_insert_id();";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?cid_nome", cidades.Cid_nome));

            // FK
            objCommand.Parameters.Add(Mapped.Parameter("?est_id", cidades.Est_id.Est_id));

            retorno = Convert.ToInt32(objCommand.ExecuteScalar());
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

    public static DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from cid_cidade order by cid_nome;";
        objCommand = Mapped.Command(sql, objConnection);

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;

    }
}