using MultilayeredArchitecture.Common.Interfaces.Search;
using System.Collections.Generic;

namespace MultilayeredArchitecture.Common.Classes.Search
{
    public class SearchModel : IBaseSearchModel
    {
        public string OrderBy { get; set; }
        public string OrderType { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public List<SearchField> SearchFields { get; set; }
        public List<SearchField> SearchGroups { get; set; }
    }
}
