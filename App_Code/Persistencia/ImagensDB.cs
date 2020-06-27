using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ImagensDB
/// </summary>
public class ImagensDB
{

    public static int InsertImgProduto(Imagens imagem)
    {
        int retorno = 0;

        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "insert into img_imagem(img_descricao, img_url, pro_id) values(?img_descricao, ?img_url, ?pro_id); " +
                "select last_insert_id();";

            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?img_descricao", imagem.Img_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?img_url", imagem.Img_url));
            //FK
            objCommand.Parameters.Add(Mapped.Parameter("?pro_id", imagem.Pro_id.Pro_id));

            objCommand.ExecuteNonQuery();
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


    public static int InsertImgServico(Imagens imagem)
    {
        int retorno = 0;

        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "insert into img_imagem(img_descricao, img_url, ser_id) values(?img_descricao, ?img_url, ?ser_id); " +
                "select last_insert_id();";

            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?img_descricao", imagem.Img_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?img_url", imagem.Img_url));
            //FK
            objCommand.Parameters.Add(Mapped.Parameter("?ser_id", imagem.Ser_id.Ser_id));

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

    public static DataSet SelectPorProduto(int pro_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select img_url from img_imagem where pro_id= ?pro_id";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?pro_id", pro_id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static DataSet SelectID(int img_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from img_imagem where img_id= ?img_id";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?img_id", img_id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Update(Imagens imagem)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "update img_imagem set img_descricao = ?img_descricao, img_url = ?img_url where img_id = ?img_id;";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?img_id", imagem.Img_id));
            objCommand.Parameters.Add(Mapped.Parameter("?img_descricao", imagem.Img_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?img_url", imagem.Img_url));

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