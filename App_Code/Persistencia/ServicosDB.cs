using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ServicosDB
/// </summary>
public class ServicosDB
{
    public static int Insert(Servicos servicos)
    {
        int retorno = 0;

        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "insert into ser_servico(ser_nome, ser_descricao, ser_caracteristica, ser_valor, emp_id) " +
                "values(?ser_nome, ?ser_descricao, ?ser_caracteristica, ?ser_valor, ?emp_id); select last_insert_id();";

            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?ser_nome", servicos.Ser_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_descricao", servicos.Ser_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_caracteristica", servicos.Ser_caracteristica));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_valor", servicos.Ser_valor));

            //FK
            objCommand.Parameters.Add(Mapped.Parameter("?emp_id", servicos.Emp_id.Emp_id));

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

    public static DataSet ServicoImagem(int emp_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        string sql = "select * from ser_servico ser inner join img_imagem img on ser.ser_id = img.ser_id where emp_id = ?emp_id;";

        objConnection = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?emp_id", emp_id));


        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;

    }

    public static DataSet SelectAll(int ser_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from ser_servico where ser_id= ?ser_id";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?ser_id", ser_id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Delete(Servicos serviços)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;
            string sql = "delete from img_imagem where ser_id = ?ser_id; " +
                "delete from ser_servico where ser_id = ?ser_id;";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?ser_id", serviços.Ser_id));
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

    public static int Update(Servicos servicos)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "update ser_servico set ser_nome = ?ser_nome, ser_descricao = ?ser_descricao, ser_caracteristica = ?ser_caracteristica " +
                "ser_valor = ?ser_valor where ser_id = ?ser_id;";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?ser_id", servicos.Ser_id));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_nome", servicos.Ser_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_descricao", servicos.Ser_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_caracteristica", servicos.Ser_caracteristica));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_valor", servicos.Ser_valor));

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