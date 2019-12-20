
using MultilayeredArchitecture.Common.Enums;
using MultilayeredArchitecture.Common.Interfaces;

namespace MultilayeredArchitecture.Common.Classes.Response
{
    public class ServiceResponse : IResponse
    {
        public bool IsSuccess { get; set; }
        public object Data { get; set; }
        public FailReason FailReason { get; set; }
    }
}
