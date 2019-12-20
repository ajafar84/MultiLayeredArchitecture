using System.Collections;

namespace MultilayeredArchitecture.Common.Interfaces.Search
{
    public interface ISearchModel<TSearchGroup>: IBaseSearchModel 
        where TSearchGroup : ICollection
    {
        TSearchGroup SearchGroups { get; set; } 
    }
}
