using System.Collections.Generic;

namespace Cepdi.Models.Models
{
    public  class Response<T>
    {
        public Response()
        {
            Success = false;
        }

        public bool Success { get; set; }
        public Errors Errors { get; set; }
        public IEnumerable<T> DataList { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }
}
