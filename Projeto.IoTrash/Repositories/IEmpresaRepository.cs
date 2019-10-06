using Projeto.IoTrash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Repositories
{
    public interface IEmpresaRepository
    {

        void Create(Empresa empresa);

        void Update(Empresa empresa);

        void Delete(int id);

        IList<Empresa> List();

        Empresa FindById(int id);

        void Save();

        IList<Empresa> FindBy(Expression<Func<Empresa, bool>> filtro);
    }
}
