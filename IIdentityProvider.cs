using System.Collections.Generic;
using System.Threading.Tasks;

namespace DStack.Common
{
    public interface IIdProvider
    {
        Task<List<long>> GetSnowflakeIds(int nrOfIds);
        Task<List<long>> GetSequential(int nrOfIds);
    }
}
