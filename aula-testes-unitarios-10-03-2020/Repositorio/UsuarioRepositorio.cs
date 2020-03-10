using aula_testes_unitarios_10_03_2020.Entidades;
using aula_testes_unitarios_10_03_2020.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_testes_unitarios_10_03_2020.Repositorio
{
    public class UsuarioRepositorio : IRepositorioGenerico<Usuario>
    {
        private List<Usuario> _usuarios = new List<Usuario>();

        public UsuarioRepositorio()
        {
            _usuarios.Add(new Usuario("admin", "admin"));
        }

        public void Add(Usuario entity) => _usuarios.Add(entity);
        public ICollection<Usuario> GetAll() => _usuarios;
        public void Remove(Usuario entity) => _usuarios.Remove(entity);

        public void Update(Usuario entity)
        {
            Remove(entity);
            Add(entity);
        }
    }
}