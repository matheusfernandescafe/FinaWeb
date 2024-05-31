using Fina.Core.Models;
using Fina.Core.Requests.Transactions;
using Fina.Core.Responses;

namespace Fina.Core.Handlers;

public interface ITransactionHandler : IBaseHandler<
    CreateTransactionRequest,
    UpdateTransactionRequest,
    DeleteTransactionRequest,
    GetTransactionByIdRequest,
    Transaction>
{
    Task<PagedResponse<List<Transaction>?>> GetByPeriodAsync(GetTransactionsByPeriodRequest request);
}
