using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Descrição resumida de EntregasDB
/// </summary>
public class EntregasDB
{
    public static DataSet SelectID(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from ent_entrega where ent_id= ?ent_id";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?ent_id", id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }
    public static DataSet SelectPorEntrega(int ent_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from ent_entrega ent inner join bai_bairro bai " +
            "on ent.bai_id = bai.bai_id inner join cid_cidade cid " +
            "on bai.cid_id = cid.cid_id inner join est_estado est " +
            "on cid.est_id = est.est_id where ent_id = ?ent_id;";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?ent_id", ent_id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static DataSet SelectPorEmpresa(int emp_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from ent_entrega ent inner join bai_bairro bai " +
            "on ent.bai_id = bai.bai_id " +
            "inner join cid_cidade cid " +
            "on cid.cid_id = ent.cid_id " +
            "inner join est_estado est " +
            "on cid.est_id = est.est_id where emp_id = ?emp_id;";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?emp_id", emp_id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }


    public static int Insert(Entregas entregas)
    {
        int retorno = 0;

        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "insert into ent_entrega(ent_frete, bai_id, cid_id, emp_id)" +
                "values(?ent_frete, ?bai_id, ?cid_id, ?emp_id); select last_insert_id();";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?ent_frete", entregas.Ent_frete));

            objCommand.Parameters.Add(Mapped.Parameter("?bai_id", entregas.Bai_id.Bai_id));
            objCommand.Parameters.Add(Mapped.Parameter("?cid_id", entregas.Cid_id.Cid_id));
            objCommand.Parameters.Add(Mapped.Parameter("?emp_id", entregas.Emp_id.Emp_id));

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
            string sql = "delete from ent_entrega where ent_id = ?ent_id; ";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?ent_id", id));
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

    public static int Update(Entregas entregas)
    {
        int retorno = 0;
        //try
        //{
        IDbConnection objConnection;
        IDbCommand objCommand;

        string sql = "update ent_entrega set ent_frete= ?ent_frete, bai_id = ?bai_id, cid_id = ?cid_id where ent_id = ?ent_id;";
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?ent_frete", entregas.Ent_frete));
        objCommand.Parameters.Add(Mapped.Parameter("?bai_id", entregas.Bai_id.Bai_id));
        objCommand.Parameters.Add(Mapped.Parameter("?cid_id", entregas.Cid_id.Cid_id));
        objCommand.Parameters.Add(Mapped.Parameter("?ent_id", entregas.Ent_id));

        objCommand.ExecuteNonQuery();

        objConnection.Close();
        objConnection.Dispose();
        objCommand.Dispose();

        //}
        //catch (Exception ex)
        //{
        //    retorno = -2;
        //}
        return retorno;

    }
}