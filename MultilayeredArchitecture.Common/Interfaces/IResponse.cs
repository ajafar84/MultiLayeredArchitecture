using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayeredArchitecture.Common.Interfaces
{
    public interface IResponse
    {
        bool IsSuccess { get; set; }
        object Data { get; set; }
    }
}
