using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayeredArchitecture.Common.Interfaces.Search
{
    public interface IBaseSearchGroup
    {
        string Name { get; set; }
        string Operator { get; set; }
    }
}
