using System.Collections.Generic;
using System.Threading.Tasks;

namespace DStack.Common
{
    public interface IQueryById
    {
        Task<T> GetById<T>(string id);
        Task<List<T>> GetByIds<T>(IEnumerable<string> ids);
    }
}