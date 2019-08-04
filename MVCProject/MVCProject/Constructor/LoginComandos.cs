using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Constructor
{
    class LoginComandos
    {
        public bool tem;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public bool verificarLogin(String login, String senha)
        {
            //vai ir até o banco de dados checar se existe o login e senha e retornar com true or false.
            // sendo true irá retornar dizendo que podemos continuar com o acesso.
            //ou seja, iremos procurar no banco esse login e senha
            cmd.CommandText = "select * from [dbo.Usuarios] where login = @Login and senha = @Senha";
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteReader();
            }
            catch (SqlException)
            {

                throw;
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            //comandos para inserir no banco caso o cadastro tenha dado certo
            return mensagem;
        }
    }
}
