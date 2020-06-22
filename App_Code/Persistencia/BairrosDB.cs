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

        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "insert into bai_bairro(bai_nome, bai_rua, cid_id) values(?bai_nome, ?bai_rua, ?cid_id); select last_insert_id();";

            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?bai_nome", bairros.Bai_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?bai_rua", bairros.Bai_rua));

            //FK
            objCommand.Parameters.Add(Mapped.Parameter("?cid_id", bairros.Cid_id.Cid_id));

            retorno = Convert.ToInt32(objCommand.ExecuteScalar());
            objConnection.Close();
            objConnection.Dispose();
            objCommand.Dispose();

        }
        catch (Exception ex)
        {
            return -2;
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
        string sql = "select * from bai_bairro";
        objCommand = Mapped.Command(sql, objConnection);

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }


    public static DataSet SelectBairro(int bai_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from bai_bairro where bai_id= ?bai_id";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?bai_id", bai_id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Update(Bairros bairros)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "update bai_bairro set bai_nome = ?bai_nome, bai_rua = ?bai_rua, cid_id = ?cid_id where bai_id = ?bai_id;";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?bai_nome", bairros.Bai_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?bai_rua", bairros.Bai_rua));
            objCommand.Parameters.Add(Mapped.Parameter("?cid_id", bairros.Cid_id.Cid_id));
            objCommand.Parameters.Add(Mapped.Parameter("?bai_id", bairros.Bai_id));

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
}