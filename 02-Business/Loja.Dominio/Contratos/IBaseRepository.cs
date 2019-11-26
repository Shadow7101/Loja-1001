using System;
using System.Collections.Generic;

namespace Loja.Dominio.Contratos {
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class {
        int Inserir (TEntity entity);

        void Atualizar (TEntity entity);

        bool Remover (TEntity entity);

        IEnumerable<TEntity> Listar ();

        TEntity ObterPorId (int id);
    }
}