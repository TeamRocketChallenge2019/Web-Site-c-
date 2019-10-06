using Projeto.IoTrash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Repositories
{
    public interface IRotaRepository
    {

        void Create(Rota rota);

        void Update(Rota rota);

        void Delete(int id);

        IList<Rota> List();

        Rota FindById(int id);

        void Save();

        IList<Rota> FindBy(Expression<Func<Rota, bool>> filtro);
    }
}
