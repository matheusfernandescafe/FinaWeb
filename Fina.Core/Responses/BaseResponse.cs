using System.Text.Json.Serialization;

namespace Fina.Core.Responses;

public class BaseResponse<TData>
{
    private int _code = Configuration.DefaultStatusCode;

    [JsonConstructor]
    public BaseResponse()
        => _code = Configuration.DefaultStatusCode;

    public BaseResponse(
        TData? data,
        int code = 200,
        string? message = null)
    {
        Data = data;
        _code = code;
        Message = message;
    }

    public TData? Data { get; set; }
    public string? Message { get; set; }

    [JsonIgnore]
    public bool IsSuccess => _code is >= 200 and <= 299;
}
