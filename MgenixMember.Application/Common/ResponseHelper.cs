using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgenixMember.Application.Common
{
    public static class ResponseHelper
    {
        public static ApiResponse<T> Success<T>(T data, string message = "Success", int statusCode = 200)
        {
            return new ApiResponse<T>(data, message, statusCode);
        }

        public static ApiResponse<T> Failure<T>(string message, int statusCode = 400, List<string>? errors = null)
        {
            return new ApiResponse<T>(message, statusCode, errors);
        }
    }
}
