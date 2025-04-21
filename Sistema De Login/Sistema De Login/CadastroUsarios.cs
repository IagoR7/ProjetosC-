using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Login
{
    internal static class CadastroUsarios
    {
        private static Usuario[] usuarios = 
        { 
           new Usuario(){Nome = "Iago", Senha = "abc123"},
           new Usuario(){Nome = "KimDokja", Senha = "Leitor"},
           new Usuario(){Nome = "Sunny", Senha = "Sunless"}
        
        };

        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado 
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }

            }
            return false;
        }
    }
}
