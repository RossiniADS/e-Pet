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
                "values(?emp_razao_social, ?emp_email, ?emp_nome_fantasia, ?emp_cnpj, ?emp_senha, ?emp_numero_endereco, ?end_id)";

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
}