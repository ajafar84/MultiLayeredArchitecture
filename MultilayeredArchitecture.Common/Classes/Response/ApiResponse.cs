using MultilayeredArchitecture.Common.Interfaces;

namespace MultilayeredArchitecture.Common.Classes.Response
{
    public class ApiResponse : IResponse
    {
        public bool IsSuccess { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
    }
}
