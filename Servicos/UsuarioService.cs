using aula_testes_unitarios_10_03_2020.Interfaces;
using aula_testes_unitarios_10_03_2020.Repositorio;
using aula_testes_unitarios_10_03_2020.Entidades;
using System;
using System.Linq;

namespace aula_testes_unitarios_10_03_2020.Servicos
{
    internal class UsuarioService : ISubitemMenu
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public UsuarioService(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void Executar()
        {
            Console.WriteLine("Informe seu usuário: ");
            var nomeUsuario = Console.ReadLine();

            Console.WriteLine("Informe sua senha: ");
            var senhaUsuario = Console.ReadLine();

            var usuarioExiste = _usuarioRepositorio.GetAll().FirstOrDefault(
              obj => obj.Nome == nomeUsuario && obj.Senha == senhaUsuario
            );

            if (usuarioExiste != null) {
              Console.WriteLine("O usuário já existe");
              return;
            }

            var usuario = new Usuario(nomeUsuario, senhaUsuario);

            _usuarioRepositorio.Add(usuario);
        }
    }
}
