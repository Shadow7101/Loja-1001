using System.Collections.Generic;
using Loja.Dominio.Contratos;

namespace Loja.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        public BaseRepositorio()
        {
        }

        public void Atualizar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public int Inserir(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> Listar()
        {
            throw new System.NotImplementedException();
        }

        public TEntity ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Remover(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}