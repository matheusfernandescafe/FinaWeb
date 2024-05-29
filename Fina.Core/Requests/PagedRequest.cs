namespace Fina.Core.Requests;

public class PagedRequest : BaseRequest
{
    public int PageSize { get; set; } = Configuration.DefaultPageSize;
    public int PageNumber { get; set; } = Configuration.DefaultPageNumber;
}
