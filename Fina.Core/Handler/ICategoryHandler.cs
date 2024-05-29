using Fina.Core.Models;
using Fina.Core.Requests.Categories;
using Fina.Core.Responses;

namespace Fina.Core.Handler;

public interface ICategoryHandler : IBaseHandler<
    CreateCategoryRequest,
    UpdateCategoryRequest,
    DeleteCategoryRequest,
    GetCategoryByIdRequest,
    Category>
{
    Task<PagedResponse<List<Category>?>> GetAllAsync(GetAllCategoryRequest request);
}
