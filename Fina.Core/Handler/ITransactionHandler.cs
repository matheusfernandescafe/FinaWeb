using Fina.Core.Models;
using Fina.Core.Requests.Transactions;
using Fina.Core.Responses;

namespace Fina.Core.Handler;

public interface ITransactionHandler : IBaseHandler<
    CreateTransactionRequest,
    UpdateTransactionRequest,
    DeleteTransactionRequest,
    GetTransactionByIdRequest,
    Transaction>
{
    Task<PagedResponse<List<Transaction>?>> GetByPeriodAsync(GetTransactionByPeriodRequest request);
}
