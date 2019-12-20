using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayeredArchitecture.Common.Interfaces.Search
{
    public interface IBaseSearchField
    {
        string Name { get; set; }
        string Operator { get; set; }
        string Value { get; set; }
    }
}
