using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ProdutosDB
/// </summary>
public class ProdutosDB
{
    public static int Insert(Produtos produtos)
    {
        int retorno = 0;

        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "insert into pro_produto(pro_nome, pro_tipo, pro_descricao, pro_caracteristica, pro_quantidade, pro_valor, pro_vencimento," +
                " emp_id) values(?pro_nome, ?pro_tipo, ?pro_descricao, ?pro_caracteristica, ?pro_quantidade, ?pro_valor, ?pro_vencimento, ?emp_id); " +
                "select last_insert_id();";

            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?pro_nome", produtos.Pro_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_tipo", produtos.Pro_tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_descricao", produtos.Pro_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_caracteristica", produtos.Pro_caracteristica));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_quantidade", produtos.Pro_quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_valor", produtos.Pro_valor));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_vencimento", produtos.Pro_vencimento));

            //FK
            objCommand.Parameters.Add(Mapped.Parameter("?emp_id", produtos.Emp_id.Emp_id));

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


    public static DataSet SelectAll(int pro_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from pro_produto where pro_id= ?pro_id";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?pro_id", pro_id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Delete(Produtos produtos)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;
            string sql = "delete from img_imagem where pro_id = ?pro_id; " +
                "delete from pro_produto where pro_id = ?pro_id;";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?pro_id", produtos.Pro_id));
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
    public static int Update(Produtos produtos)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "update pro_produto set pro_nome = ?pro_nome, pro_caracteristica = ?pro_caracteristica, " +
                "pro_descricao = ?pro_descricao, pro_tipo = ?pro_tipo, pro_quantidade = ?pro_quantidade, " +
                "pro_valor = ?pro_valor, pro_vencimento = ?pro_vencimento where pro_id = ?pro_id;";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?pro_id", produtos.Pro_id));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_nome", produtos.Pro_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_tipo", produtos.Pro_tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_caracteristica", produtos.Pro_caracteristica));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_descricao", produtos.Pro_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_vencimento", produtos.Pro_vencimento));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_quantidade", produtos.Pro_quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?pro_valor", produtos.Pro_valor));

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