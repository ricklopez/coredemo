using System.Collections.Generic;
using System.Data;

namespace coredemo.contracts.Repositories
{
    public interface IBaseRepository<TModel> where TModel : class 
    {
        IDbConnection Connection { get; }
        void Add(TModel prod);
        IEnumerable<TModel> GetAll();
        TModel GetByID(int id);
        void Delete(int id);
        void Update(TModel prod);
    }
}