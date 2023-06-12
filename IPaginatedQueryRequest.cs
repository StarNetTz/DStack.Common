namespace DStack.Common
{
    public interface IPaginatedQueryRequest
    {
        int CurrentPage { get; }
        int PageSize { get; }
    }

    public class PaginatedQueryRequest : IPaginatedQueryRequest
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
    }

    public interface IPaginatedQueryRequest<TQueryParams>
    {
        TQueryParams QryParams { get; }
        int CurrentPage { get; }
        int PageSize { get; }
    }

    public class PaginatedQueryRequest<TQueryParams> : IPaginatedQueryRequest<TQueryParams>
    {
        public TQueryParams QryParams { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
    }
}
