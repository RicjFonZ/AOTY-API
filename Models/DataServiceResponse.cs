using Models.Enums;

namespace Models
{
    /// <summary>
    /// DataServiceResponse
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DataServiceResponse<T>
    {
        public T Data { get; set; } = default!;
        public DataServiceResponseStatusEnum Status { get; set; }
        public string Message { get; set; } = null!;
    }
}
