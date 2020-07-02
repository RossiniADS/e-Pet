using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

using System.Text;
using System.IO;
using System.Security.Cryptography;

/// <summary>
/// Descrição resumida de EmpresasDB
/// </summary>
public class EmpresasDB
{
    public static int Insert(Empresas empresas)
    {
        int retorno = 0;

        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "insert into emp_empresa(emp_razao_social, emp_email, emp_nome_fantasia, emp_cnpj, emp_senha, emp_numero_endereco, end_id) " +
                "values(?emp_razao_social, ?emp_email, ?emp_nome_fantasia, ?emp_cnpj, ?emp_senha, ?emp_numero_endereco, ?end_id); select last_insert_id();";

            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?emp_razao_social", empresas.Emp_razao_social));
            objCommand.Parameters.Add(Mapped.Parameter("?emp_email", empresas.Emp_email));
            objCommand.Parameters.Add(Mapped.Parameter("?emp_nome_fantasia", empresas.Emp_nome_fantasia));
            objCommand.Parameters.Add(Mapped.Parameter("?emp_cnpj", empresas.Emp_cnpj));
            objCommand.Parameters.Add(Mapped.Parameter("?emp_senha", empresas.Emp_senha));
            objCommand.Parameters.Add(Mapped.Parameter("?emp_numero_endereco", empresas.Emp_numero_endereco));

            //FK
            objCommand.Parameters.Add(Mapped.Parameter("?end_id", empresas.End_id.End_id));

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

    public static DataSet ProdutoID(int pro_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        string sql = "select * " +
            "from pro_produto pro " +
            "inner join img_imagem img " +
            "on pro.pro_id = img.pro_id " +
            "where pro.pro_id = ?pro_id;";

        objConnection = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?pro_id", pro_id));


        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;

    }

    public static DataSet ProdutoImagem(int emp_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        string sql = "select * " +
            "from pro_produto pro " +
            "inner join img_imagem img " +
            "on pro.pro_id = img.pro_id " +
            "where emp_id = ?emp_id;";

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

    public static DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from emp_empresa";
        objCommand = Mapped.Command(sql, objConnection);

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }
    public static DataSet SelectID(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = "select * from emp_empresa where emp_id= ?emp_id";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?emp_id", id));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static DataSet SelectPorCidade(string cidade)
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;

        objConnection = Mapped.Connection();
        string sql = " select emp_nome_fantasia, emp_id " +
            "from emp_empresa emp " +
            "inner join end_endereco end " +
            "on emp.end_id = end.end_id " +
            "inner join bai_bairro bai " +
            "on bai.bai_id = end.bai_id " +
            "inner join cid_cidade cid " +
            "on cid.cid_id = bai.cid_id " +
            "where cid.cid_nome = ?cid_nome;";


        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?cid_nome", cidade));

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
        string sql = "select * from emp_empresa where emp_email = ?emp_email and emp_senha = ?emp_senha";
        objCommand = Mapped.Command(sql, objConnection);

        objCommand.Parameters.Add(Mapped.Parameter("?emp_email", email));
        objCommand.Parameters.Add(Mapped.Parameter("?emp_senha", pwd));

        objDataDadapter = Mapped.adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static int Update(Empresas emp)
    {
        int retorno = 0;
        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "update emp_empresa set emp_nome_fantasia = ?Emp_nome_fantasia, emp_numero_endereco = ?emp_numero_endereco, " +
                "Emp_email = ?Emp_email, Emp_razao_social = ?Emp_razao_social, Emp_cnpj = " +
            "?Emp_cnpj,  Emp_senha =  ?Emp_senha, Emp_foto_url = ?Emp_foto_url where Emp_id = ?Emp_id";
            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);

            objCommand.Parameters.Add(Mapped.Parameter("?Emp_nome_fantasia", emp.Emp_nome_fantasia));
            objCommand.Parameters.Add(Mapped.Parameter("?emp_numero_endereco", emp.Emp_numero_endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?Emp_email", emp.Emp_email));
            objCommand.Parameters.Add(Mapped.Parameter("?Emp_razao_social", emp.Emp_razao_social));
            objCommand.Parameters.Add(Mapped.Parameter("?Emp_cnpj", emp.Emp_cnpj));
            objCommand.Parameters.Add(Mapped.Parameter("?Emp_senha", emp.Emp_senha));
            objCommand.Parameters.Add(Mapped.Parameter("?Emp_foto_url", emp.Emp_foto_url));
            objCommand.Parameters.Add(Mapped.Parameter("?Emp_id", emp.Emp_id));

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