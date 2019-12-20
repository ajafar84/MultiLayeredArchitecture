using MultilayeredArchitecture.Common.Interfaces;
using MultilayeredArchitecture.Common.Interfaces.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayeredArchitecture.Common.Classes.Search
{
    public class SearchField : IBaseSearchField
    {
        public string Name { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
    }
}
