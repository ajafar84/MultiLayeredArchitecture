using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayeredArchitecture.Common.Interfaces.Search
{
    public interface IBaseSearchModel
    {
        string OrderBy { get; set; }
        string OrderType { get; set; }
        int PageNumber { get; set; }
        int PageSize { get; set; }
    }
}
