using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace FORUMDIA25MES08
{
    public static class bancoDados
    { 
     public static MySqlConnection Abrirconexao()
    {

        string conexao = "SERVER=localhost; DATABASE=test; UID=root; PWD=; PORT=;";
        MySqlConnection conectar = new MySqlConnection(conexao);
        conectar.Open();
        return conectar;
    }

    public static MySqlConnection Fecharconexao()
    {

        string conexao = "SERVER=localhost; DATABASE=test; UID=root; PWD=; PORT=;";
        MySqlConnection conectar = new MySqlConnection(conexao);
        conectar.Close();
        return conectar;
    }

    public static DataTable dql(string sql)
    {
        MySqlDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            var vcon = Abrirconexao();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = sql;
            da = new MySqlDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            vcon.Close();
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
       

    }
