﻿namespace DStack.Common
{
    public interface ISearchQueryRequest
    {
        string Collection { get; set; }
        string Qry { get; }
        int CurrentPage { get; }
        int PageSize { get; }
    }

    public class SearchQueryRequest : ISearchQueryRequest
    {
        public string Collection { get; set; }
        public string Qry { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
    }
}