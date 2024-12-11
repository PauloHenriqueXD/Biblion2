using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblion.DAL;

namespace Biblion.Modelo
{
    class Controle
    {
        public bool tem;
        public string mensagem = "";

        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            return mensagem;
        }
    }
}
