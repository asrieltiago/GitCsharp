using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Constructor
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //Construtor servirá para conectar com o banco de dados.
        public Conexao()
        {
            con.ConnectionString = @"";
        }

        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
