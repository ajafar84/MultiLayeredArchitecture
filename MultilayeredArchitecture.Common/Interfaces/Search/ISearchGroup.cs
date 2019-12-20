using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayeredArchitecture.Common.Interfaces.Search
{
    interface ISearchGroup<TSearchField> : IBaseSearchGroup
        where TSearchField : ICollection, ISearchField
    {
        TSearchField SearchFields { get; set; }
    }
}
