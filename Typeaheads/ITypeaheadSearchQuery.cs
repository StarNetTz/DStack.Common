using System.Threading.Tasks;

namespace DStack.Common
{
    public interface ITypeaheadSearchQuery
    {
        Task<PaginatedResult<TypeaheadItem>> Execute(ISearchQueryRequest qry);
    }
}
