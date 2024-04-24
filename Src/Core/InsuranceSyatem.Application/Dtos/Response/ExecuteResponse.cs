using InsuranceSyatem.Application.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Dtos.Response
{
    public static class ExecuteResponse<T>
    {
        public static BaseResponse Response(int statusCode, bool success, string message, T? data)
        {
            return new BaseResponse
            {
                StatusCode = statusCode,
                Success = success,
                Message = message,
                Data = data
            };
        }
    }
}
