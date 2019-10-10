using Projeto.IoTrash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Projeto.IoTrash.Repositories
{
    public interface ICaminhaoRepository
    {

        void Create(Caminhao caminhao);

        void Update(Caminhao caminhao);

        void Delete(int id);

        IList<Caminhao> List();

        Caminhao FindById(int id);

        void Save();

        IList<Caminhao> FindBy(Expression<Func<Caminhao, bool>> filtro);

        void CarregarSelectEmpresas();

    }
}
