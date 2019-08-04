using MVCProject.Constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Model
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String login, String senha)
        {
            LoginComandos loginComando = new LoginComandos();
            tem = loginComando.verificarLogin(login, senha);
            if (!loginComando.mensagem.Equals(""))
            {
                this.mensagem = loginComando.mensagem;
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            return mensagem;
        }
    }
}
