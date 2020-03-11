using aula_testes_unitarios_10_03_2020.Interfaces;
using aula_testes_unitarios_10_03_2020.Repositorio;
using aula_testes_unitarios_10_03_2020.Entidades;
using System;
using System.Linq;

namespace aula_testes_unitarios_10_03_2020.Servicos
{
    internal class AlterarSenhaService : ISubitemMenu
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public AlterarSenhaService(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void Executar()
        {
            Console.WriteLine("Informe seu usuário: ");
            var nomeUsuario = Console.ReadLine();
            
            var usuarioEncontrado = _usuarioRepositorio.GetAll().FirstOrDefault(
              obj => obj.Nome == nomeUsuario
            );

            if (usuarioEncontrado != null) {
              Console.WriteLine("Informe sua senha: ");
              var senhaUsuario = Console.ReadLine();

              Console.WriteLine("Informe sua senha novamente: ");
              var senhaUsuarioAgain = Console.ReadLine();

              if (senhaUsuario == senhaUsuarioAgain) {
                usuarioEncontrado.setSenha(senhaUsuario);
              }
            } 

            _usuarioRepositorio.Update(usuarioEncontrado);
        }
    }
}
