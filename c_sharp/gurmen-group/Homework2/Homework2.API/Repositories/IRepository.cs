using Homework2.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Homework2.API.Repositories
{
    public interface IRepository<T> where T: BaseEntity
    {
        public Task<bool> Any(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(T model);
        public Task<int> Save(T model);
        public Task<T> GetById(int id);
        public Task<IEnumerable<T>> GetAll();
    }
}
