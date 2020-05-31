using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

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

            string sql = "insert into cli_cliente(cli_nome,cli_email,cli_senha,cli_sexo,cli_nascimento) values(?cli_nome, ?cli_email, ?cli_senha, ?cli_sexo, ?cli_nascimento)";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?cli_nome", clientes.Cli_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?cli_email", clientes.Cli_email));
            objCommand.Parameters.Add(Mapped.Parameter("?cli_senha", clientes.Cli_senha));
            objCommand.Parameters.Add(Mapped.Parameter("?cli_sexo", clientes.Cli_sexo));
            objCommand.Parameters.Add(Mapped.Parameter("?cli_nascimento", clientes.Cli_nascimento));

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