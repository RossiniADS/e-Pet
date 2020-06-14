using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de TelefonesDB
/// </summary>
public class TelefonesDB
{
    public static int Insert(Telefones telefones)
    {
        int retorno = 0;

        //try
        //  {
        IDbConnection objConnection;
        IDbCommand objCommand;

        string sql = "insert into tel_telefone(tel_ddd, tel_num, emp_id) values(?tel_ddd, ?tel_num, ?emp_id); select last_insert_id();";

        objConnection = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?tel_ddd", telefones.Tel_ddd));
        objCommand.Parameters.Add(Mapped.Parameter("?tel_num", telefones.Tel_num));

        //FK
        objCommand.Parameters.Add(Mapped.Parameter("?emp_id", telefones.Emp_id.Emp_id));

        retorno = Convert.ToInt32(objCommand.ExecuteScalar());
        objConnection.Close();
        objConnection.Dispose();
        objCommand.Dispose();
        // }
        //catch (Exception ex)
        // {
        //    retorno = -2;
        // }
        return retorno;
    }

    public static DataSet SelectTel(int tel_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from tel_telefone where tel_id = ?tel_id";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?tel_id", tel_id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Update(Telefones tel)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "update tel_telefone set tel_ddd = ?tel_ddd, tel_num = ?tel_num where emp_id = ?emp_id;";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?tel_ddd", tel.Tel_ddd));
            objCommand.Parameters.Add(Mapped.Parameter("?tel_num", tel.Tel_num));
            objCommand.Parameters.Add(Mapped.Parameter("?emp_id", tel.Emp_id.Emp_id));

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