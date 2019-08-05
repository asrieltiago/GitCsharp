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
        public bool tem = false;
        public String mensagem = ""; //se a mensagem continuar vazia, está tudo Ok.
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String Login, String Senha)
        {
            //vai ir até o banco de dados checar se existe o login e senha e retornar com true or false.
            // sendo true irá retornar dizendo que podemos continuar com o acesso.
            //ou seja, iremos procurar no banco esse login e senha
            cmd.CommandText = "select * from Usuarios where Login = @Login and Senha = @Senha";
            cmd.Parameters.AddWithValue("@Login", Login);
            cmd.Parameters.AddWithValue("@Senha", Senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) // se o login e senha for encontrado
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;
        }

        /*public String cadastrar(String Nome, String Login, String Senha, String Email, bool Ativo, int UsuInc, int UsuAlt, DateTime DatInc, DateTime DatAlt)
        {
            tem = false;
            //comandos para inserir no banco caso o cadastro tenha dado certo
            if(Senha != "")
            {
                cmd.CommandText = "insert into [dbo.Usuarios] values (@Nome,@Login,@Senha,@Email,@Ativo,@UsuInc,@UsuAlt,@DatInc,@DatAlt)";
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Senha", Senha);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@true", Ativo);
                cmd.Parameters.AddWithValue("@1", UsuInc);
                cmd.Parameters.AddWithValue("@1", UsuAlt);
                cmd.Parameters.AddWithValue("@DateTime.Now", DatInc);
                cmd.Parameters.AddWithValue("@DateTime.Now", DatAlt);


                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com Sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro no banco de Dados!";
                }
            }            
            return mensagem; 
        }*/
    }
}
