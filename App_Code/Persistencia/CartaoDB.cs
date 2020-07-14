using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CartaoDB
/// </summary>
public class CartaoDB
{
    public static DataSet SelectCartao(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from car_cartao where car_id = ?car_id";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?car_id", id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Insert(Cartao cartao)
    {
        int retorno = 0;

        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "insert into car_cartao(car_cpf, car_num, car_nome, car_bandeira, car_cod_seguranca, car_data_vencimento, cli_id)" +
                " values(?car_cpf, ?car_num, ?car_nome, ?car_bandeira, ?car_cod_seguranca, ?car_data_vencimento, ?cli_id); " +
                "select last_insert_id();";

            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?car_cpf", cartao.Car_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?car_num", cartao.Car_num));
            objCommand.Parameters.Add(Mapped.Parameter("?car_nome", cartao.Car_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?car_bandeira", cartao.Car_bandeira));
            objCommand.Parameters.Add(Mapped.Parameter("?car_cod_seguranca", cartao.Car_cod_seguranca));
            objCommand.Parameters.Add(Mapped.Parameter("?car_data_vencimento", cartao.Car_data_vencimento));


            //FK
            objCommand.Parameters.Add(Mapped.Parameter("?cli_id", cartao.Cli_id.Cli_id));

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
    public static int Delete(int id)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;
            string sql = "delete from car_cartao where car_id = ?car_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?car_id", id));
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
    public static DataSet SelectPorCliente(int cli_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select*from car_cartao car  where cli_id = ?cli_id;";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?cli_id", cli_id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }
    public static DataSet SelectAll(int car_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from car_cartao where car_id= ?car_id";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?car_id", car_id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Update(Cartao cartao)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "update car_cartao set car_cpf = ?car_cpf, car_num = ?car_num, car_nome = ?car_nome " +
                "car_bandeira = ?car_bandeira, car_cod_seguranca = ?car_cod_seguranca, car_data_vencimentowhere = ?car_data_vencimento" +
                " car_id = ?car_id;";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?car_cpf", cartao.Car_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?car_num", cartao.Car_num));
            objCommand.Parameters.Add(Mapped.Parameter("?car_nome", cartao.Car_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?car_bandeira", cartao.Car_bandeira));
            objCommand.Parameters.Add(Mapped.Parameter("?car_cod_seguranca", cartao.Car_cod_seguranca));
            objCommand.Parameters.Add(Mapped.Parameter("?car_data_vencimento", cartao.Car_data_vencimento));

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