using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgenixMember.Application.Common
{
    public class ApiResponse<T>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public bool Success { get; set; }
        public List<string>? Errors { get; set; }

        public ApiResponse(T data, string message = "Success", int statusCode = 200)
        {
            Success = true;
            StatusCode = statusCode;
            Message = message;
            Data = data;
        }

        public ApiResponse(string message, int statusCode = 400, List<string>? errors = null)
        {
            Success = false;
            StatusCode = statusCode;
            Message = message;
            Errors = errors;
        }
    }
}
