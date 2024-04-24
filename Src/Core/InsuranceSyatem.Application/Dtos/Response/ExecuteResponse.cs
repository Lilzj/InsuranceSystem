using InsuranceSyatem.Application.Dtos.Response;

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
