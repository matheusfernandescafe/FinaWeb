using Fina.Core.Responses;

namespace Fina.Core.Handlers;

public interface IBaseHandler<TCreateRequest, TUpdateRequest, TDeleteRequest, TGetByIdRequest, TEntity>
{
    Task<Response<TEntity?>> CreateAsync(TCreateRequest request);
    Task<Response<TEntity?>> UpdateAsync(TUpdateRequest request);
    Task<Response<TEntity?>> DeleteAsync(TDeleteRequest request);
    Task<Response<TEntity?>> GetByIdAsync(TGetByIdRequest request);
    //Task<PagedResponse<List<TEntity>?>> GetAllAsync(TGetAllRequest request);
}
