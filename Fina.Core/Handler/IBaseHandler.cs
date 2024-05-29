using Fina.Core.Responses;

namespace Fina.Core.Handler;

public interface IBaseHandler<TCreateRequest, TUpdateRequest, TDeleteRequest, TGetByIdRequest, TEntity>
{
    Task<BaseResponse<TEntity?>> CreateAsync(TCreateRequest request);
    Task<BaseResponse<TEntity?>> UpdateAsync(TUpdateRequest request);
    Task<BaseResponse<TEntity?>> DeleteAsync(TDeleteRequest request);
    Task<BaseResponse<TEntity?>> GetByIdAsync(TGetByIdRequest request);
    //Task<PagedResponse<List<TEntity>?>> GetAllAsync(TGetAllRequest request);
}
