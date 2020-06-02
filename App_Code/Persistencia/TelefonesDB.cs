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

        string sql = "insert into tel_telefone(tel_ddd, tel_num, cli_cliente, emp_id) values(?tel_ddd, ?tel_num, ?cli_cliente, ?emp_id)";

        objConnection = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?tel_ddd", telefones.Tel_ddd));
        objCommand.Parameters.Add(Mapped.Parameter("?tel_num", telefones.Tel_num));

        //FK
        objCommand.Parameters.Add(Mapped.Parameter("?cli_cliente", telefones.Cli_id.Cli_id));
        objCommand.Parameters.Add(Mapped.Parameter("?emp_id", telefones.Emp_id.Emp_id));

        objCommand.ExecuteNonQuery();
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
}