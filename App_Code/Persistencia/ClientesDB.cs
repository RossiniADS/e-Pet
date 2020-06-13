using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

using System.Text;
using System.IO;
using System.Security.Cryptography;

/// <summary>
/// Descrição resumida de ClientesDB
/// </summary>
public class ClientesDB
{
    public static int Insert(Clientes clientes)
    {
        int retorno = 0;

        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "insert into cli_cliente(cli_nome,cli_email,cli_senha,cli_sexo,cli_data_nascimento)" +
                " values(?cli_nome, ?cli_email, ?cli_senha, ?cli_sexo, ?cli_data_nascimento); select last_insert_id();";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?cli_nome", clientes.Cli_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?cli_email", clientes.Cli_email));
            objCommand.Parameters.Add(Mapped.Parameter("?cli_senha", clientes.Cli_senha));
            objCommand.Parameters.Add(Mapped.Parameter("?cli_sexo", clientes.Cli_sexo));
            objCommand.Parameters.Add(Mapped.Parameter("?cli_data_nascimento", clientes.Cli_data_nascimento));

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

    public static string PWD(string senha)
    {
        UnicodeEncoding UE = new UnicodeEncoding();
        byte[] HashValue, MessageBytes = UE.GetBytes(senha);
        SHA512Managed SHash = new SHA512Managed();
        string strHEx = "";
        HashValue = SHash.ComputeHash(MessageBytes);
        foreach (byte b in HashValue)
        {
            strHEx += String.Format("{0:x2}", b);
        }
        return strHEx;
    }

    public static DataSet SelectAll(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from cli_cliente where cli_id = ?cli_id";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?cli_id", id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }



    public static DataSet SelectLogin(string email, string pwd)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from cli_cliente where cli_email = ?cli_email and cli_senha = ?cli_senha";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?cli_email", email));
        objCommand.Parameters.Add(Mapped.Parameter("?cli_senha", pwd));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Update(Clientes cliente)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "update cli_cliente set cli_nome = ?cli_nome, cli_email = ?cli_email, cli_senha = ?cli_senha, cli_sexo = " +
            "?cli_sexo,  cli_data_nascimento =  ?cli_data_nascimento, cli_foto_url = ?cli_foto_url where cli_id = ?cli_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?cli_nome", cliente.Cli_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?cli_email", cliente.Cli_email));
            objCommand.Parameters.Add(Mapped.Parameter("?cli_senha", cliente.Cli_senha));
            objCommand.Parameters.Add(Mapped.Parameter("?cli_sexo", cliente.Cli_sexo));
            objCommand.Parameters.Add(Mapped.Parameter("?cli_data_nascimento", cliente.Cli_data_nascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?cli_foto_url", cliente.Cli_foto_url));
            objCommand.Parameters.Add(Mapped.Parameter("?cli_id", cliente.Cli_id));

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