using System.Collections.Generic;

namespace aula_testes_unitarios_10_03_2020.Interfaces
{
    public interface IRepositorioGenerico<T>
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        ICollection<T> GetAll();
    }
}
