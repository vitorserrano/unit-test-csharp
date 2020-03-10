using aula_testes_unitarios_10_03_2020.Interfaces;
using aula_testes_unitarios_10_03_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_testes_unitarios_10_03_2020.Servicos
{
    internal class LoginService : ISubitemMenu
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public LoginService(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void Executar()
        {
            Console.WriteLine("Informe seu usuário: ");
            var nomeUsuario = Console.ReadLine();

            Console.WriteLine("Informe sua senha: ");
            var senhaUsuario = Console.ReadLine();

            var usuario = _usuarioRepositorio.GetAll().FirstOrDefault(x => x.Nome.Equals(nomeUsuario) && x.Senha.Equals(senhaUsuario));
            if (usuario != null)
                Console.WriteLine($"Bem vindo {usuario.Nome}");
            else
                Console.WriteLine("Usuário ou senha inválidos! Verifique.");
        }
    }
}
