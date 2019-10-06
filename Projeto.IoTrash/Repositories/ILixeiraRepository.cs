using Projeto.IoTrash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Repositories
{
    public interface ILixeiraRepository
    {

        void Create(Lixeira lixeira);

        void Update(Lixeira lixeira);

        void Delete(int id);

        IList<Lixeira> List();

        Lixeira FindById(int id);

        void Save();

        IList<Lixeira> FindBy(Expression<Func<Lixeira, bool>> filtro);
    }
}
